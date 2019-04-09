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
            this.changeData = new System.Windows.Forms.Button();
            this.selectData = new System.Windows.Forms.Button();
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
            this.greeting.Location = new System.Drawing.Point(72, 20);
            this.greeting.Name = "greeting";
            this.greeting.Size = new System.Drawing.Size(185, 52);
            this.greeting.TabIndex = 2;
            this.greeting.Text = "Вітаємо в програмі \r\n\"Облік абітурієнтів\"";
            this.greeting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // changeData
            // 
            this.changeData.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeData.Location = new System.Drawing.Point(77, 238);
            this.changeData.Name = "changeData";
            this.changeData.Size = new System.Drawing.Size(164, 36);
            this.changeData.TabIndex = 1;
            this.changeData.Text = "Курування даними\r\n";
            this.changeData.UseVisualStyleBackColor = true;
            // 
            // selectData
            // 
            this.selectData.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectData.Location = new System.Drawing.Point(77, 301);
            this.selectData.Name = "selectData";
            this.selectData.Size = new System.Drawing.Size(164, 36);
            this.selectData.TabIndex = 2;
            this.selectData.Text = "Обробка даних";
            this.selectData.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(34, 82);
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
            this.Controls.Add(this.selectData);
            this.Controls.Add(this.changeData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.greeting);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Облік абітурієнтів";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label greeting;
        private System.Windows.Forms.Button changeData;
        private System.Windows.Forms.Button selectData;
        private System.Windows.Forms.Label label1;
    }
}

