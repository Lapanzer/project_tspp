namespace ODZ______
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.greeting = new System.Windows.Forms.Label();
            this.changeDataBut = new System.Windows.Forms.Button();
            this.selectDataBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 380);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // greeting
            // 
            this.greeting.AutoSize = true;
            this.greeting.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greeting.Location = new System.Drawing.Point(72, 22);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(185, 52);
            this.greeting.TabIndex = 2;
            this.greeting.Text = "Вітаємо в програмі \r\n\"Облік абітурієнтів\"";
            this.greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeDataBut
            // 
            this.changeDataBut.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeDataBut.Location = new System.Drawing.Point(77, 238);
            this.changeDataBut.Name = "changeDataBut";
            this.changeDataBut.Size = new System.Drawing.Size(164, 36);
            this.changeDataBut.TabIndex = 1;
            this.changeDataBut.Text = "Керування даними\r\n";
            this.changeDataBut.UseVisualStyleBackColor = true;
            this.changeDataBut.Click += new System.EventHandler(this.ChangeDataBut_Click);
            // 
            // selectDataBut
            // 
            this.selectDataBut.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDataBut.Location = new System.Drawing.Point(77, 301);
            this.selectDataBut.Name = "selectDataBut";
            this.selectDataBut.Size = new System.Drawing.Size(164, 36);
            this.selectDataBut.TabIndex = 2;
            this.selectDataBut.Text = "Пошук даних";
            this.selectDataBut.UseVisualStyleBackColor = true;
            this.selectDataBut.Click += new System.EventHandler(this.SelectDataBut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 104);
            this.label1.TabIndex = 2;
            this.label1.Text = " Дана програма дозволить \r\nвам керувати інформацією \r\nпро абітурієнтів та швидко " +
    "\r\nїї оброблювати.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(320, 378);
            this.Controls.Add(this.selectDataBut);
            this.Controls.Add(this.changeDataBut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Облік абітурієнтів";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Button changeDataBut;
        private System.Windows.Forms.Button selectDataBut;
        private System.Windows.Forms.Label label1;
    }
}

