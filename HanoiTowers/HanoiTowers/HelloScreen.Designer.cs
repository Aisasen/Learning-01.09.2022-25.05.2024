namespace HanoiTowers
{
    partial class HelloScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.title = new System.Windows.Forms.Label();
            this.author = new System.Windows.Forms.Label();
            this.begin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.Violet;
            this.title.Location = new System.Drawing.Point(190, 44);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(427, 56);
            this.title.TabIndex = 1;
            this.title.Text = "Ханойские башни";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author.ForeColor = System.Drawing.Color.Violet;
            this.author.Location = new System.Drawing.Point(174, 136);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(443, 178);
            this.author.TabIndex = 2;
            this.author.Text = "Выполнил Тарасов Владимир IS 202";
            this.author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // begin
            // 
            this.begin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.begin.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.begin.Location = new System.Drawing.Point(313, 356);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(172, 55);
            this.begin.TabIndex = 3;
            this.begin.Text = "Начать";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.button1_Click);
            // 
            // HelloScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Name = "HelloScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ханойские башни";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HelloScreen_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label author;
        private System.Windows.Forms.Button begin;
    }
}

