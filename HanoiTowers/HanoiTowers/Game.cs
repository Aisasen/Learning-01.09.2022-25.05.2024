using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HanoiTowers
{
    public partial class Game : Form
    {
        private Point initialPosition;
        private int startColumn = 0;

        private int NumDiscs = 1;
        private const int RodWidth = 10;
        private const int RodHeight = 300;
        private const int RodSpacing = 265;
        private const int DiscWidthMin = 50;
        private const int DiscWidthStep = 20;
        private int stepsCount = 1;

        private Panel[] rods;
        private PictureBox[] discs;
        private int[,] rodStates;

        private bool isDragging = false;
        private PictureBox selectedDisk = null;
        private Point offset;
        private bool solvingStopped = false;

        public Game()
        {
            InitializeComponent();
        }

        private void circlesCount_Scroll(object sender, EventArgs e)
        {
            NumDiscs = circlesCount.Value;
            label1.Text = circlesCount.Value.ToString() + " Колец";
        }
        private void startTower_Scroll(object sender, EventArgs e)
        {
            startColumn = startTower.Value-1;
            label2.Text = startTower.Value.ToString() + " Башня";
        }
        private void rules_Click(object sender, EventArgs e)
        {
            Rules rules = new Rules();
            rules.Show();
        }

        private void InitializeGame()
        {
            stepsCount = 1;
            // Очистим предыдущие диски перед созданием новых
            if (discs != null)
            {
                foreach (var disc in discs)
                {
                    if (disc != null)
                    {
                        this.Controls.Remove(disc);
                        disc.Dispose();
                    }
                }
            }
 
            rods = new Panel[3];
            for (int i = 0; i < 3; i++)
            {
                rods[i] = new Panel
                {
                    Width = RodWidth,
                    Height = RodHeight,
                    BackColor = Color.Black,
                    Left = (i + 1) * RodSpacing - RodWidth / 2,
                    Top = ClientSize.Height - RodHeight - 150,
                    Parent = this
                };
            }

            discs = new PictureBox[NumDiscs];
            for (int i = 0; i < NumDiscs; i++)
            {
                discs[i] = new PictureBox();
                discs[i].Width = DiscWidthMin + (NumDiscs - i - 1) * DiscWidthStep; //Правило уменьшения ширины дисков, с больших до малых
                discs[i].Height = 20;
                discs[i].BackColor = Color.Orange;
                discs[i].Left = rods[startColumn].Left + (RodWidth - discs[i].Width) / 2; // Координата по ширине
                discs[i].Top = rods[startColumn].Top + RodHeight - (i + 1) * discs[i].Height; // Координата по высоте
                discs[i].Parent = this;
                discs[i].Tag = startColumn; // Изначально все диски на стартовом стержне
                discs[i].BringToFront();
                discs[i].MouseDown += new MouseEventHandler(Disc_MouseDown);
                discs[i].MouseMove += new MouseEventHandler(Disc_MouseMove);
                discs[i].MouseUp += new MouseEventHandler(Disc_MouseUp);
            }

            rodStates = new int[3, NumDiscs]; //Какие диски есть на стержнях
            for (int i = 0; i < 3; i++)
            {
                    
                for (int j = 0; j<NumDiscs; j++)
                {
                    if (i == startColumn)
                    {
                        rodStates[i, j] = Array.IndexOf(discs, discs[j]); //Записываем в таблицу стержней индекс диска - его вес
                    }
                    else
                        rodStates[i, j] = NumDiscs; //Наименьший диск = NumDiscs-1, поэтому 0 = NumDiscs
                }
            }   
        }

        private void begin_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void Disc_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox clickedDisk = sender as PictureBox;

            int currentRod = (int)clickedDisk.Tag;
            int diskWeight = Array.IndexOf(discs, clickedDisk);

            int topDiskOnRod = GetTopDiskWeight(currentRod);

            // Проверяем, является ли данный диск верхним на стержне
            if (diskWeight == topDiskOnRod)
            {
                isDragging = true;
                selectedDisk = clickedDisk;
                offset = e.Location;
                selectedDisk.BringToFront();

                initialPosition = selectedDisk.Location;
            }
        }

        private void Disc_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && selectedDisk != null) //Если выбран диск, он перемещается с мышкой
            {
                selectedDisk.Left = e.X + selectedDisk.Left - offset.X;
                selectedDisk.Top = e.Y + selectedDisk.Top - offset.Y;
            }
        }

        private void Disc_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging && selectedDisk != null)
            {
                isDragging = false;

                int targetRod = -1;
                bool droppedOnRod = false;

                for (int i = 0; i < 3; i++)
                {
                    Rectangle expandedBounds = rods[i].Bounds;
                    expandedBounds.Inflate(30, 30); // Увеличение хитбокса стержня

                    if (expandedBounds.Contains(this.PointToClient(MousePosition)))
                    {
                        targetRod = i;
                        droppedOnRod = true;
                        break;
                    }
                }

                if (droppedOnRod) //Если отпущен на стержень
                {
                    if (CanMove(selectedDisk, targetRod))
                    {
                        MoveDisk(selectedDisk, targetRod);
                    }
                    else
                    {
                        selectedDisk.Location = initialPosition; // Возвращаем диск на исходную позицию
                    }
                }
                else
                    selectedDisk.Location = initialPosition;
            }
        }

        private bool CanMove(PictureBox disk, int targetRod)
        {
            int upperDisk = GetTopDiskWeight(targetRod); // Вес верхнего диска

            // Если верхний диск целевого стержня больше перемещаемого диска или целевой стержень пустой
            if (upperDisk == NumDiscs || Array.IndexOf(discs, disk) > upperDisk)
            {
                return true;
            }
            return false;
        }

        private int GetTopDiskWeight(int targetRod)
        {
            for (int j = NumDiscs - 1; j >= 0; j--)
            {
                if (rodStates[targetRod, j] != NumDiscs)
                {
                    return rodStates[targetRod, j];
                }
            }
            return NumDiscs;
        }

        private void MoveDisk(PictureBox disk, int targetRod)
        {
            int currentDiskIndex = 0;
            int destinationDiskIndex = 0;
            int currentRod = (int)disk.Tag; //Тег - номер стержня, на котором находится диск
            int DiskWeight = Array.IndexOf(discs, disk); //Где 0 - самый тяжёлый
            for (int j = 0;j < NumDiscs; j++)
            {
               if (rodStates[currentRod, j] == DiskWeight)
                {
                    currentDiskIndex = j; //Позиция диска на старом стержне, где 0 - самый низ
                }
            }
            for (int j = 0; j<NumDiscs; j++)
            {
                if (rodStates[targetRod, j] == NumDiscs)
                {
                    destinationDiskIndex = j; //Позиция диска на стержне назначения, где 0 - самый низ
                    break;
                }
            }
            // Обновить состояния для старого и целевого стрежня
            rodStates[currentRod, currentDiskIndex] = NumDiscs;
            rodStates[targetRod, destinationDiskIndex] = DiskWeight;

            // Позиция диска на целевом стержне
            disk.Left = rods[targetRod].Left + (RodWidth - disk.Width) / 2;
            disk.Top = rods[targetRod].Top + RodHeight - (destinationDiskIndex + 1) * disk.Height;
            // Обновить номер стержня, на котором находится диск
            disk.Tag = targetRod;

            steps.Text = "Колличество ходов: " + stepsCount++;
            CheckGameCompletion();
        }

        private void CheckGameCompletion()
        {
            if (rodStates[2, NumDiscs - 1] == NumDiscs - 1) //Если на 3-м стержне в наивысшей позиции находится наименьший диск
            {
                stepsCount--;
                Victory victory = new Victory();
                victory.Show();
                victory.label1.Text = "Вы одержали победу за " + stepsCount + " ходов!";
                solvingStopped = true; // Установить флаг solvingStopped в true при победе
            }
        }

        private void solution_Click(object sender, EventArgs e)
        {
            solvingStopped = false;
            SolveHanoi(NumDiscs, startColumn, 2, 1-startColumn);
        }

        private void SolveHanoi(int n, int sourceRod, int destinationRod, int auxiliaryRod)
        {
            if (n > 0 && !solvingStopped)
            {
                SolveHanoi(n - 1, sourceRod, auxiliaryRod, destinationRod);

                // Добавляем проверку кнопки стоп внутри цикла
                Application.DoEvents();
                if (solvingStopped)
                    return; // Выйти из метода, если кнопка стоп была нажата
                if(CanMove(discs[NumDiscs - n], destinationRod))
                {
                    MoveDisk(discs[NumDiscs - n], destinationRod);
                }
                // Проверяем кнопку стоп после перемещения
                Application.DoEvents();
                if (solvingStopped)
                    return; // Выйти из метода, если кнопка стоп была нажата

                SolveHanoi(n - 1, auxiliaryRod, destinationRod, sourceRod);
                System.Threading.Thread.Sleep(5000 / (NumDiscs*NumDiscs));
            }
        }

        private void stopSolution_Click(object sender, EventArgs e)
        {
            solvingStopped = true;
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
