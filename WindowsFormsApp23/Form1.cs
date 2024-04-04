using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();   // вызов диалога задания шрифта
            textBox1.Font = fontDialog1.Font;

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();  // вызов диалога задания цвета
            textBox1.ForeColor = colorDialog1.Color;

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый редактор разработал: Владимир");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Завершить работу?", "предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes) Application.Exit();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                this.Text = "открыт файл " + fn;
                try
                {
                    StreamReader sr = new StreamReader(fn);
                    textBox1.Text = sr.ReadToEnd();
                    sr.Close();
                }
                catch (Exception ex)
                { MessageBox.Show("Ошибка чтения \n" + ex.ToString()); }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = saveFileDialog1.FileName;
                this.Text = "сохранен файл " + fn;
                if (fn != string.Empty)
                {
                    FileInfo fi = new FileInfo(fn);
                    try
                    {
                        StreamWriter sw = fi.CreateText();
                        sw.Write(textBox1.Text);
                        sw.Close();
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Ошибка записи \n" + ex.ToString()); }
                }
            }
        }

        private void Form1_DoubleClick(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получите введенные данные
            string name = textBox2.Text;
            string selectedClass = radioButton1.Checked ? "9" : "10";
            string selectedSubject = comboBox1.SelectedItem.ToString();

            // Откройте диалоговое окно для выбора пути сохранения файла
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Создайте строку для записи в файл
                    string dataToWrite = $"Имя: {name}, Класс: {selectedClass}, Предмет: {selectedSubject}";

                    // Запишите данные в выбранный файл
                    File.WriteAllText(saveFileDialog.FileName, dataToWrite);

                    MessageBox.Show("Данные успешно записаны в файл");
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Откройте диалоговое окно для выбора файла для чтения
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Прочитайте данные из выбранного файла
                    string data = File.ReadAllText(openFileDialog.FileName);

                    // Разберите данные и заполните соответствующие поля
                    string[] parts = data.Split(new string[] { ", " }, StringSplitOptions.None);
                    if (parts.Length == 3)
                    {
                        string name = parts[0].Replace("Имя: ", "");
                        string selectedClass = parts[1].Replace("Класс: ", "");
                        string selectedSubject = parts[2].Replace("Предмет: ", "");

                        textBox2.Text = name;
                        if (selectedClass == "9")
                            radioButton1.Checked = true;
                        else if (selectedClass == "10")
                            radioButton2.Checked = true;

                        comboBox1.SelectedItem = selectedSubject;

                        MessageBox.Show("Данные успешно прочитаны из файла");
                    }
                    else
                    {
                        MessageBox.Show("Формат данных в файле неверный");
                    }
                }
            }
        }
    }
}
