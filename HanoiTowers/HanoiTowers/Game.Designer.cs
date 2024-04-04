namespace HanoiTowers
{
    partial class Game
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
            this.title = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.circlesCount = new System.Windows.Forms.TrackBar();
            this.begin = new System.Windows.Forms.Button();
            this.rules = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.startTower = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.steps = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circlesCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTower)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.ForeColor = System.Drawing.Color.Violet;
            this.title.Location = new System.Drawing.Point(332, 35);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(427, 56);
            this.title.TabIndex = 2;
            this.title.Text = "Ханойские башни";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.button2.Location = new System.Drawing.Point(875, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Стоп";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.stopSolution_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(697, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Решить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.solution_Click);
            // 
            // circlesCount
            // 
            this.circlesCount.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.circlesCount.LargeChange = 1;
            this.circlesCount.Location = new System.Drawing.Point(221, 509);
            this.circlesCount.Maximum = 9;
            this.circlesCount.Minimum = 1;
            this.circlesCount.Name = "circlesCount";
            this.circlesCount.Size = new System.Drawing.Size(104, 45);
            this.circlesCount.TabIndex = 7;
            this.circlesCount.Value = 1;
            this.circlesCount.Scroll += new System.EventHandler(this.circlesCount_Scroll);
            // 
            // begin
            // 
            this.begin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.begin.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.begin.ForeColor = System.Drawing.Color.IndianRed;
            this.begin.Location = new System.Drawing.Point(43, 492);
            this.begin.Name = "begin";
            this.begin.Size = new System.Drawing.Size(172, 55);
            this.begin.TabIndex = 4;
            this.begin.Text = "Нарисовать";
            this.begin.UseVisualStyleBackColor = true;
            this.begin.Click += new System.EventHandler(this.begin_Click);
            // 
            // rules
            // 
            this.rules.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rules.Font = new System.Drawing.Font("Georgia", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rules.ForeColor = System.Drawing.SystemColors.Highlight;
            this.rules.Location = new System.Drawing.Point(875, 35);
            this.rules.Name = "rules";
            this.rules.Size = new System.Drawing.Size(172, 55);
            this.rules.TabIndex = 8;
            this.rules.Text = "Правила";
            this.rules.UseVisualStyleBackColor = true;
            this.rules.Click += new System.EventHandler(this.rules_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(331, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "1 Кольцо";
            // 
            // startTower
            // 
            this.startTower.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.startTower.LargeChange = 1;
            this.startTower.Location = new System.Drawing.Point(440, 509);
            this.startTower.Maximum = 3;
            this.startTower.Minimum = 1;
            this.startTower.Name = "startTower";
            this.startTower.Size = new System.Drawing.Size(104, 45);
            this.startTower.TabIndex = 10;
            this.startTower.Value = 1;
            this.startTower.Scroll += new System.EventHandler(this.startTower_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(545, 509);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "1 Башня";
            // 
            // steps
            // 
            this.steps.AutoSize = true;
            this.steps.Font = new System.Drawing.Font("Georgia", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.steps.Location = new System.Drawing.Point(24, 35);
            this.steps.Name = "steps";
            this.steps.Size = new System.Drawing.Size(232, 25);
            this.steps.TabIndex = 12;
            this.steps.Text = "Колличество ходов: 0";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1071, 587);
            this.Controls.Add(this.steps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startTower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rules);
            this.Controls.Add(this.circlesCount);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.begin);
            this.Controls.Add(this.title);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.circlesCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startTower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar circlesCount;
        private System.Windows.Forms.Button begin;
        private System.Windows.Forms.Button rules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar startTower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label steps;
    }
}