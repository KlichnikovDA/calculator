namespace Calculator
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
            this.Degree1 = new System.Windows.Forms.TextBox();
            this.Degree2 = new System.Windows.Forms.TextBox();
            this.AnswerD = new System.Windows.Forms.TextBox();
            this.Minute1 = new System.Windows.Forms.TextBox();
            this.Second1 = new System.Windows.Forms.TextBox();
            this.Minute2 = new System.Windows.Forms.TextBox();
            this.Second2 = new System.Windows.Forms.TextBox();
            this.AnswerM = new System.Windows.Forms.TextBox();
            this.AnswerS = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Degree1
            // 
            this.Degree1.Location = new System.Drawing.Point(13, 13);
            this.Degree1.Name = "Degree1";
            this.Degree1.Size = new System.Drawing.Size(23, 20);
            this.Degree1.TabIndex = 0;
            this.Degree1.TextChanged += new System.EventHandler(this.Degree1_TextChanged);
            // 
            // Degree2
            // 
            this.Degree2.Location = new System.Drawing.Point(135, 13);
            this.Degree2.Name = "Degree2";
            this.Degree2.Size = new System.Drawing.Size(25, 20);
            this.Degree2.TabIndex = 1;
            // 
            // AnswerD
            // 
            this.AnswerD.Location = new System.Drawing.Point(13, 82);
            this.AnswerD.Name = "AnswerD";
            this.AnswerD.Size = new System.Drawing.Size(23, 20);
            this.AnswerD.TabIndex = 2;
            // 
            // Minute1
            // 
            this.Minute1.Location = new System.Drawing.Point(48, 13);
            this.Minute1.Name = "Minute1";
            this.Minute1.Size = new System.Drawing.Size(24, 20);
            this.Minute1.TabIndex = 3;
            // 
            // Second1
            // 
            this.Second1.Location = new System.Drawing.Point(79, 13);
            this.Second1.Name = "Second1";
            this.Second1.Size = new System.Drawing.Size(24, 20);
            this.Second1.TabIndex = 4;
            // 
            // Minute2
            // 
            this.Minute2.Location = new System.Drawing.Point(176, 13);
            this.Minute2.Name = "Minute2";
            this.Minute2.Size = new System.Drawing.Size(23, 20);
            this.Minute2.TabIndex = 5;
            // 
            // Second2
            // 
            this.Second2.Location = new System.Drawing.Point(206, 13);
            this.Second2.Name = "Second2";
            this.Second2.Size = new System.Drawing.Size(24, 20);
            this.Second2.TabIndex = 6;
            // 
            // AnswerM
            // 
            this.AnswerM.Location = new System.Drawing.Point(48, 82);
            this.AnswerM.Name = "AnswerM";
            this.AnswerM.Size = new System.Drawing.Size(24, 20);
            this.AnswerM.TabIndex = 7;
            // 
            // AnswerS
            // 
            this.AnswerS.Location = new System.Drawing.Point(78, 82);
            this.AnswerS.Name = "AnswerS";
            this.AnswerS.Size = new System.Drawing.Size(25, 20);
            this.AnswerS.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.AnswerS);
            this.Controls.Add(this.AnswerM);
            this.Controls.Add(this.Second2);
            this.Controls.Add(this.Minute2);
            this.Controls.Add(this.Second1);
            this.Controls.Add(this.Minute1);
            this.Controls.Add(this.AnswerD);
            this.Controls.Add(this.Degree2);
            this.Controls.Add(this.Degree1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox Degree1;
        public System.Windows.Forms.TextBox Degree2;
        public System.Windows.Forms.TextBox Minute1;
        public System.Windows.Forms.TextBox Second1;
        public System.Windows.Forms.TextBox Minute2;
        public System.Windows.Forms.TextBox Second2;
        public System.Windows.Forms.TextBox AnswerD;
        public System.Windows.Forms.TextBox AnswerM;
        public System.Windows.Forms.TextBox AnswerS;
    }
}

