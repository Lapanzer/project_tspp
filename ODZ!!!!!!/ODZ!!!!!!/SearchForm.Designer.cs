namespace ODZ______
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dGVX = new System.Windows.Forms.DataGridView();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abitResultX = new System.Windows.Forms.BindingSource(this.components);
            this.searchXBut = new System.Windows.Forms.Button();
            this.minMarkXTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dGVXY = new System.Windows.Forms.DataGridView();
            this.surnameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abitResultXY = new System.Windows.Forms.BindingSource(this.components);
            this.searchXYBut = new System.Windows.Forms.Button();
            this.schoolNumXYTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.minMarkXYTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveDataBut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abitResultX)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abitResultXY)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dGVX);
            this.groupBox1.Controls.Add(this.searchXBut);
            this.groupBox1.Controls.Add(this.minMarkXTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 297);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список зарахованих";
            // 
            // dGVX
            // 
            this.dGVX.AllowUserToAddRows = false;
            this.dGVX.AllowUserToDeleteRows = false;
            this.dGVX.AllowUserToResizeColumns = false;
            this.dGVX.AllowUserToResizeRows = false;
            this.dGVX.AutoGenerateColumns = false;
            this.dGVX.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGVX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn});
            this.dGVX.DataSource = this.abitResultX;
            this.dGVX.Location = new System.Drawing.Point(10, 139);
            this.dGVX.Name = "dGVX";
            this.dGVX.RowHeadersVisible = false;
            this.dGVX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVX.Size = new System.Drawing.Size(303, 133);
            this.dGVX.TabIndex = 3;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // markDataGridViewTextBoxColumn
            // 
            this.markDataGridViewTextBoxColumn.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn.HeaderText = "Оцінка";
            this.markDataGridViewTextBoxColumn.Name = "markDataGridViewTextBoxColumn";
            this.markDataGridViewTextBoxColumn.ReadOnly = true;
            this.markDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // abitResultX
            // 
            this.abitResultX.DataSource = typeof(ODZ______.AbitResult);
            // 
            // searchXBut
            // 
            this.searchXBut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchXBut.Location = new System.Drawing.Point(117, 94);
            this.searchXBut.Name = "searchXBut";
            this.searchXBut.Size = new System.Drawing.Size(89, 30);
            this.searchXBut.TabIndex = 4;
            this.searchXBut.TabStop = false;
            this.searchXBut.Text = "Пошук";
            this.searchXBut.UseVisualStyleBackColor = true;
            this.searchXBut.Click += new System.EventHandler(this.SearchXBut_Click);
            // 
            // minMarkXTxt
            // 
            this.minMarkXTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minMarkXTxt.Location = new System.Drawing.Point(144, 45);
            this.minMarkXTxt.MaxLength = 20;
            this.minMarkXTxt.Name = "minMarkXTxt";
            this.minMarkXTxt.Size = new System.Drawing.Size(62, 24);
            this.minMarkXTxt.TabIndex = 1;
            this.minMarkXTxt.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прохідний бал";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dGVXY);
            this.groupBox2.Controls.Add(this.searchXYBut);
            this.groupBox2.Controls.Add(this.schoolNumXYTxt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.minMarkXYTxt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(332, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 297);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список зарахованих по школі";
            // 
            // dGVXY
            // 
            this.dGVXY.AllowUserToAddRows = false;
            this.dGVXY.AllowUserToDeleteRows = false;
            this.dGVXY.AllowUserToResizeColumns = false;
            this.dGVXY.AllowUserToResizeRows = false;
            this.dGVXY.AutoGenerateColumns = false;
            this.dGVXY.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGVXY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVXY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.surnameDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn1,
            this.markDataGridViewTextBoxColumn1});
            this.dGVXY.DataSource = this.abitResultXY;
            this.dGVXY.Location = new System.Drawing.Point(8, 139);
            this.dGVXY.Name = "dGVXY";
            this.dGVXY.RowHeadersVisible = false;
            this.dGVXY.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGVXY.Size = new System.Drawing.Size(304, 133);
            this.dGVXY.TabIndex = 3;
            // 
            // surnameDataGridViewTextBoxColumn1
            // 
            this.surnameDataGridViewTextBoxColumn1.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn1.HeaderText = "Прізвище";
            this.surnameDataGridViewTextBoxColumn1.Name = "surnameDataGridViewTextBoxColumn1";
            this.surnameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Ім\'я";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // markDataGridViewTextBoxColumn1
            // 
            this.markDataGridViewTextBoxColumn1.DataPropertyName = "Mark";
            this.markDataGridViewTextBoxColumn1.HeaderText = "Оцінка";
            this.markDataGridViewTextBoxColumn1.Name = "markDataGridViewTextBoxColumn1";
            this.markDataGridViewTextBoxColumn1.ReadOnly = true;
            this.markDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // abitResultXY
            // 
            this.abitResultXY.DataSource = typeof(ODZ______.AbitResult);
            // 
            // searchXYBut
            // 
            this.searchXYBut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchXYBut.Location = new System.Drawing.Point(114, 94);
            this.searchXYBut.Name = "searchXYBut";
            this.searchXYBut.Size = new System.Drawing.Size(89, 30);
            this.searchXYBut.TabIndex = 5;
            this.searchXYBut.TabStop = false;
            this.searchXYBut.Text = "Пошук";
            this.searchXYBut.UseVisualStyleBackColor = true;
            this.searchXYBut.Click += new System.EventHandler(this.SearchXYBut_Click);
            // 
            // schoolNumXYTxt
            // 
            this.schoolNumXYTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.schoolNumXYTxt.Location = new System.Drawing.Point(133, 59);
            this.schoolNumXYTxt.MaxLength = 20;
            this.schoolNumXYTxt.Name = "schoolNumXYTxt";
            this.schoolNumXYTxt.Size = new System.Drawing.Size(179, 24);
            this.schoolNumXYTxt.TabIndex = 1;
            this.schoolNumXYTxt.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Номер школи";
            // 
            // minMarkXYTxt
            // 
            this.minMarkXYTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minMarkXYTxt.Location = new System.Drawing.Point(133, 29);
            this.minMarkXYTxt.MaxLength = 20;
            this.minMarkXYTxt.Name = "minMarkXYTxt";
            this.minMarkXYTxt.Size = new System.Drawing.Size(60, 24);
            this.minMarkXYTxt.TabIndex = 1;
            this.minMarkXYTxt.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Прохідний бал";
            // 
            // saveDataBut
            // 
            this.saveDataBut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveDataBut.Location = new System.Drawing.Point(285, 315);
            this.saveDataBut.Name = "saveDataBut";
            this.saveDataBut.Size = new System.Drawing.Size(117, 30);
            this.saveDataBut.TabIndex = 4;
            this.saveDataBut.TabStop = false;
            this.saveDataBut.Text = "Зберегти дані";
            this.saveDataBut.UseVisualStyleBackColor = true;
            this.saveDataBut.Click += new System.EventHandler(this.SaveDataBut_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 350);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.saveDataBut);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пошук даних";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SearchForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abitResultX)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVXY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abitResultXY)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dGVX;
        private System.Windows.Forms.Button searchXBut;
        private System.Windows.Forms.TextBox minMarkXTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button searchXYBut;
        private System.Windows.Forms.TextBox schoolNumXYTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox minMarkXYTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dGVXY;
        private System.Windows.Forms.BindingSource abitResultX;
        private System.Windows.Forms.BindingSource abitResultXY;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button saveDataBut;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn1;
    }
}