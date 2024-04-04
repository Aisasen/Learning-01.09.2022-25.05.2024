namespace WindowsFormsApp53
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bomba = new System.Windows.Forms.PictureBox();
            this.samolet = new System.Windows.Forms.PictureBox();
            this.pula = new System.Windows.Forms.PictureBox();
            this.men = new System.Windows.Forms.PictureBox();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.samolet2 = new System.Windows.Forms.PictureBox();
            this.bomba2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bomba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samolet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.men)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.samolet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(362, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "10";
            // 
            // bomba
            // 
            this.bomba.Image = global::WindowsFormsApp53.Properties.Resources.pngimg_com___bomb_PNG30;
            this.bomba.Location = new System.Drawing.Point(29, 121);
            this.bomba.Name = "bomba";
            this.bomba.Size = new System.Drawing.Size(55, 53);
            this.bomba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bomba.TabIndex = 4;
            this.bomba.TabStop = false;
            this.bomba.Visible = false;
            // 
            // samolet
            // 
            this.samolet.Image = global::WindowsFormsApp53.Properties.Resources.Flying_Plane_PNG_Clipart;
            this.samolet.Location = new System.Drawing.Point(12, 58);
            this.samolet.Name = "samolet";
            this.samolet.Size = new System.Drawing.Size(100, 50);
            this.samolet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.samolet.TabIndex = 2;
            this.samolet.TabStop = false;
            // 
            // pula
            // 
            this.pula.Image = global::WindowsFormsApp53.Properties.Resources.ищьиф;
            this.pula.Location = new System.Drawing.Point(29, 246);
            this.pula.Name = "pula";
            this.pula.Size = new System.Drawing.Size(54, 55);
            this.pula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pula.TabIndex = 1;
            this.pula.TabStop = false;
            this.pula.Visible = false;
            // 
            // men
            // 
            this.men.Image = global::WindowsFormsApp53.Properties.Resources.yeah_bwoi_grin;
            this.men.Location = new System.Drawing.Point(12, 325);
            this.men.Name = "men";
            this.men.Size = new System.Drawing.Size(100, 84);
            this.men.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.men.TabIndex = 0;
            this.men.TabStop = false;
            // 
            // timer3
            // 
            this.timer3.Interval = 10;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // samolet2
            // 
            this.samolet2.Image = global::WindowsFormsApp53.Properties.Resources.Flying_Plane_PNG_Clipart;
            this.samolet2.Location = new System.Drawing.Point(643, 121);
            this.samolet2.Name = "samolet2";
            this.samolet2.Size = new System.Drawing.Size(100, 50);
            this.samolet2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.samolet2.TabIndex = 5;
            this.samolet2.TabStop = false;
            // 
            // bomba2
            // 
            this.bomba2.Image = global::WindowsFormsApp53.Properties.Resources.pngimg_com___bomb_PNG30;
            this.bomba2.Location = new System.Drawing.Point(671, 194);
            this.bomba2.Name = "bomba2";
            this.bomba2.Size = new System.Drawing.Size(55, 53);
            this.bomba2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bomba2.TabIndex = 6;
            this.bomba2.TabStop = false;
            this.bomba2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bomba2);
            this.Controls.Add(this.samolet2);
            this.Controls.Add(this.bomba);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.samolet);
            this.Controls.Add(this.pula);
            this.Controls.Add(this.men);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bomba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samolet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.men)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.samolet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bomba2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox men;
        private System.Windows.Forms.PictureBox pula;
        private System.Windows.Forms.PictureBox samolet;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox bomba;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox samolet2;
        private System.Windows.Forms.PictureBox bomba2;
    }
}

