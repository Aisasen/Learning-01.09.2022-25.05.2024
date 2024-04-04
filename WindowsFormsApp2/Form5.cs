using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.база_данных1DataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "база_данных1DataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.база_данных1DataSet.Products);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.база_данных1DataSet);

        }
    }
}
