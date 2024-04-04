namespace WindowsFormsApp2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            System.Windows.Forms.Label iD_zakazLabel;
            System.Windows.Forms.Label iD_sotrudLabel;
            System.Windows.Forms.Label iD_UsersLabel;
            System.Windows.Forms.Label iD_productsLabel;
            System.Windows.Forms.Label data_razmLabel;
            System.Windows.Forms.Label data_ispolnLabel;
            this.база_данных1DataSet = new WindowsFormsApp2.База_данных1DataSet();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderTableAdapter = new WindowsFormsApp2.База_данных1DataSetTableAdapters.OrderTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp2.База_данных1DataSetTableAdapters.TableAdapterManager();
            this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_zakazTextBox = new System.Windows.Forms.TextBox();
            this.iD_sotrudTextBox = new System.Windows.Forms.TextBox();
            this.iD_UsersTextBox = new System.Windows.Forms.TextBox();
            this.iD_productsTextBox = new System.Windows.Forms.TextBox();
            this.data_razmTextBox = new System.Windows.Forms.TextBox();
            this.data_ispolnTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            iD_zakazLabel = new System.Windows.Forms.Label();
            iD_sotrudLabel = new System.Windows.Forms.Label();
            iD_UsersLabel = new System.Windows.Forms.Label();
            iD_productsLabel = new System.Windows.Forms.Label();
            data_razmLabel = new System.Windows.Forms.Label();
            data_ispolnLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.база_данных1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
            this.orderBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // база_данных1DataSet
            // 
            this.база_данных1DataSet.DataSetName = "База_данных1DataSet";
            this.база_данных1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            this.orderBindingSource.DataSource = this.база_данных1DataSet;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CatalogTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = this.orderTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SotrudnikTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp2.База_данных1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // orderBindingNavigator
            // 
            this.orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderBindingNavigator.BindingSource = this.orderBindingSource;
            this.orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orderBindingNavigatorSaveItem});
            this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderBindingNavigator.Name = "orderBindingNavigator";
            this.orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.orderBindingNavigator.TabIndex = 0;
            this.orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderBindingNavigatorSaveItem.Image")));
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.orderBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.orderBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderBindingNavigatorSaveItem_Click);
            // 
            // iD_zakazLabel
            // 
            iD_zakazLabel.AutoSize = true;
            iD_zakazLabel.Location = new System.Drawing.Point(314, 146);
            iD_zakazLabel.Name = "iD_zakazLabel";
            iD_zakazLabel.Size = new System.Drawing.Size(52, 13);
            iD_zakazLabel.TabIndex = 1;
            iD_zakazLabel.Text = "ID zakaz:";
            // 
            // iD_zakazTextBox
            // 
            this.iD_zakazTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ID_zakaz", true));
            this.iD_zakazTextBox.Location = new System.Drawing.Point(372, 143);
            this.iD_zakazTextBox.Name = "iD_zakazTextBox";
            this.iD_zakazTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_zakazTextBox.TabIndex = 2;
            // 
            // iD_sotrudLabel
            // 
            iD_sotrudLabel.AutoSize = true;
            iD_sotrudLabel.Location = new System.Drawing.Point(313, 191);
            iD_sotrudLabel.Name = "iD_sotrudLabel";
            iD_sotrudLabel.Size = new System.Drawing.Size(53, 13);
            iD_sotrudLabel.TabIndex = 3;
            iD_sotrudLabel.Text = "ID sotrud:";
            // 
            // iD_sotrudTextBox
            // 
            this.iD_sotrudTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ID_sotrud", true));
            this.iD_sotrudTextBox.Location = new System.Drawing.Point(372, 188);
            this.iD_sotrudTextBox.Name = "iD_sotrudTextBox";
            this.iD_sotrudTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_sotrudTextBox.TabIndex = 4;
            // 
            // iD_UsersLabel
            // 
            iD_UsersLabel.AutoSize = true;
            iD_UsersLabel.Location = new System.Drawing.Point(315, 234);
            iD_UsersLabel.Name = "iD_UsersLabel";
            iD_UsersLabel.Size = new System.Drawing.Size(51, 13);
            iD_UsersLabel.TabIndex = 5;
            iD_UsersLabel.Text = "ID Users:";
            // 
            // iD_UsersTextBox
            // 
            this.iD_UsersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ID_Users", true));
            this.iD_UsersTextBox.Location = new System.Drawing.Point(372, 231);
            this.iD_UsersTextBox.Name = "iD_UsersTextBox";
            this.iD_UsersTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_UsersTextBox.TabIndex = 6;
            // 
            // iD_productsLabel
            // 
            iD_productsLabel.AutoSize = true;
            iD_productsLabel.Location = new System.Drawing.Point(301, 281);
            iD_productsLabel.Name = "iD_productsLabel";
            iD_productsLabel.Size = new System.Drawing.Size(65, 13);
            iD_productsLabel.TabIndex = 7;
            iD_productsLabel.Text = "ID products:";
            // 
            // iD_productsTextBox
            // 
            this.iD_productsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ID_products", true));
            this.iD_productsTextBox.Location = new System.Drawing.Point(372, 278);
            this.iD_productsTextBox.Name = "iD_productsTextBox";
            this.iD_productsTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_productsTextBox.TabIndex = 8;
            // 
            // data_razmLabel
            // 
            data_razmLabel.AutoSize = true;
            data_razmLabel.Location = new System.Drawing.Point(308, 333);
            data_razmLabel.Name = "data_razmLabel";
            data_razmLabel.Size = new System.Drawing.Size(58, 13);
            data_razmLabel.TabIndex = 9;
            data_razmLabel.Text = "Data razm:";
            // 
            // data_razmTextBox
            // 
            this.data_razmTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Data_razm", true));
            this.data_razmTextBox.Location = new System.Drawing.Point(372, 330);
            this.data_razmTextBox.Name = "data_razmTextBox";
            this.data_razmTextBox.Size = new System.Drawing.Size(100, 20);
            this.data_razmTextBox.TabIndex = 10;
            // 
            // data_ispolnLabel
            // 
            data_ispolnLabel.AutoSize = true;
            data_ispolnLabel.Location = new System.Drawing.Point(303, 377);
            data_ispolnLabel.Name = "data_ispolnLabel";
            data_ispolnLabel.Size = new System.Drawing.Size(63, 13);
            data_ispolnLabel.TabIndex = 11;
            data_ispolnLabel.Text = "Data ispoln:";
            // 
            // data_ispolnTextBox
            // 
            this.data_ispolnTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "Data_ispoln", true));
            this.data_ispolnTextBox.Location = new System.Drawing.Point(372, 374);
            this.data_ispolnTextBox.Name = "data_ispolnTextBox";
            this.data_ispolnTextBox.Size = new System.Drawing.Size(100, 20);
            this.data_ispolnTextBox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(321, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 42);
            this.label1.TabIndex = 13;
            this.label1.Text = "Заказы";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(data_ispolnLabel);
            this.Controls.Add(this.data_ispolnTextBox);
            this.Controls.Add(data_razmLabel);
            this.Controls.Add(this.data_razmTextBox);
            this.Controls.Add(iD_productsLabel);
            this.Controls.Add(this.iD_productsTextBox);
            this.Controls.Add(iD_UsersLabel);
            this.Controls.Add(this.iD_UsersTextBox);
            this.Controls.Add(iD_sotrudLabel);
            this.Controls.Add(this.iD_sotrudTextBox);
            this.Controls.Add(iD_zakazLabel);
            this.Controls.Add(this.iD_zakazTextBox);
            this.Controls.Add(this.orderBindingNavigator);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.база_данных1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
            this.orderBindingNavigator.ResumeLayout(false);
            this.orderBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private База_данных1DataSet база_данных1DataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private База_данных1DataSetTableAdapters.OrderTableAdapter orderTableAdapter;
        private База_данных1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_zakazTextBox;
        private System.Windows.Forms.TextBox iD_sotrudTextBox;
        private System.Windows.Forms.TextBox iD_UsersTextBox;
        private System.Windows.Forms.TextBox iD_productsTextBox;
        private System.Windows.Forms.TextBox data_razmTextBox;
        private System.Windows.Forms.TextBox data_ispolnTextBox;
        private System.Windows.Forms.Label label1;
    }
}