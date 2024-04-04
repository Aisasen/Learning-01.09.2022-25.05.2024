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

namespace WindowsFormsApp27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 15;
            dataGridView1.ColumnCount = 15;
            String result = "";
            int[,] a = new int[15, 15];
            int i, j;
            Random rand = new Random();
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                }
                    
            }
            // Выводим матрицу в dataGridView1
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }   
            }
            //Поиск наименьших в строках
            int m = int.MaxValue;
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    if (a[i, j] < m)
                    {
                        m = a[i, j];
                    }
                }
                result = result + Convert.ToString(m) + "; ";
                m = int.MaxValue;
            }
            //Кол-во положительных в столбцах
            int PositiveCount = 0;
            int lower = int.MaxValue;
            int index = 0;
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    if (a[j, i] > 0)
                    {
                        PositiveCount++;
                    }
                }
                if (PositiveCount < lower)
                {
                    lower = PositiveCount;
                }
            }
            textBox1.Text = "Наименьшие элементы в каждой строке "+result +" Столбец с наименьшим колличеством положительных элементов "+Convert.ToString(lower);
        }
    }
}
