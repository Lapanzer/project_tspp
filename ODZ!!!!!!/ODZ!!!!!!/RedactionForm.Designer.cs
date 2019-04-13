namespace ODZ______
{
    partial class RedactionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedactionForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addBut = new System.Windows.Forms.Button();
            this.addSurnameTxt = new System.Windows.Forms.TextBox();
            this.addSchoolNumTxt = new System.Windows.Forms.TextBox();
            this.addMarkTxt = new System.Windows.Forms.TextBox();
            this.addNameTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chBut = new System.Windows.Forms.Button();
            this.cB1 = new System.Windows.Forms.ComboBox();
            this.sampleAbitBS = new System.Windows.Forms.BindingSource(this.components);
            this.chSurnameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chSchoolNumTxt = new System.Windows.Forms.TextBox();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfSchoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chMarkTxt = new System.Windows.Forms.TextBox();
            this.chNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleAbitBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addBut);
            this.groupBox1.Controls.Add(this.addSurnameTxt);
            this.groupBox1.Controls.Add(this.addSchoolNumTxt);
            this.groupBox1.Controls.Add(this.addMarkTxt);
            this.groupBox1.Controls.Add(this.addNameTxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додати абітурієнта";
            // 
            // addBut
            // 
            this.addBut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBut.Location = new System.Drawing.Point(218, 79);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(89, 30);
            this.addBut.TabIndex = 2;
            this.addBut.Text = "Додати\r\n";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.AddBut_Click);
            // 
            // addSurnameTxt
            // 
            this.addSurnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSurnameTxt.Location = new System.Drawing.Point(6, 49);
            this.addSurnameTxt.MaxLength = 45;
            this.addSurnameTxt.Name = "addSurnameTxt";
            this.addSurnameTxt.Size = new System.Drawing.Size(137, 24);
            this.addSurnameTxt.TabIndex = 1;
            this.addSurnameTxt.TabStop = false;
            // 
            // addSchoolNumTxt
            // 
            this.addSchoolNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSchoolNumTxt.Location = new System.Drawing.Point(341, 49);
            this.addSchoolNumTxt.MaxLength = 45;
            this.addSchoolNumTxt.Name = "addSchoolNumTxt";
            this.addSchoolNumTxt.Size = new System.Drawing.Size(179, 24);
            this.addSchoolNumTxt.TabIndex = 1;
            this.addSchoolNumTxt.TabStop = false;
            // 
            // addMarkTxt
            // 
            this.addMarkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addMarkTxt.Location = new System.Drawing.Point(277, 49);
            this.addMarkTxt.MaxLength = 20;
            this.addMarkTxt.Name = "addMarkTxt";
            this.addMarkTxt.Size = new System.Drawing.Size(58, 24);
            this.addMarkTxt.TabIndex = 1;
            this.addMarkTxt.TabStop = false;
            // 
            // addNameTxt
            // 
            this.addNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNameTxt.Location = new System.Drawing.Point(149, 49);
            this.addNameTxt.MaxLength = 45;
            this.addNameTxt.Name = "addNameTxt";
            this.addNameTxt.Size = new System.Drawing.Size(122, 24);
            this.addNameTxt.TabIndex = 1;
            this.addNameTxt.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Номер школи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Оцінка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ім\'я";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chBut);
            this.groupBox2.Controls.Add(this.cB1);
            this.groupBox2.Controls.Add(this.chSurnameTxt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.chSchoolNumTxt);
            this.groupBox2.Controls.Add(this.dGV1);
            this.groupBox2.Controls.Add(this.chMarkTxt);
            this.groupBox2.Controls.Add(this.chNameTxt);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(8, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 320);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Змінити дані абітурієнта";
            // 
            // chBut
            // 
            this.chBut.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBut.Location = new System.Drawing.Point(218, 286);
            this.chBut.Name = "chBut";
            this.chBut.Size = new System.Drawing.Size(89, 30);
            this.chBut.TabIndex = 2;
            this.chBut.Text = "Змінити\r\n";
            this.chBut.UseVisualStyleBackColor = true;
            this.chBut.Click += new System.EventHandler(this.ChBut_Click);
            // 
            // cB1
            // 
            this.cB1.DataSource = this.sampleAbitBS;
            this.cB1.DisplayMember = "Id";
            this.cB1.DropDownHeight = 120;
            this.cB1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cB1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cB1.FormattingEnabled = true;
            this.cB1.IntegralHeight = false;
            this.cB1.Location = new System.Drawing.Point(233, 189);
            this.cB1.Name = "cB1";
            this.cB1.Size = new System.Drawing.Size(72, 24);
            this.cB1.TabIndex = 2;
            this.cB1.ValueMember = "Id";
            // 
            // sampleAbitBS
            // 
            this.sampleAbitBS.DataSource = typeof(ODZ______.SampleAbit);
            // 
            // chSurnameTxt
            // 
            this.chSurnameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chSurnameTxt.Location = new System.Drawing.Point(6, 249);
            this.chSurnameTxt.MaxLength = 45;
            this.chSurnameTxt.Name = "chSurnameTxt";
            this.chSurnameTxt.Size = new System.Drawing.Size(137, 24);
            this.chSurnameTxt.TabIndex = 1;
            this.chSurnameTxt.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Оберіть ID абітурієнта для змін";
            // 
            // chSchoolNumTxt
            // 
            this.chSchoolNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chSchoolNumTxt.Location = new System.Drawing.Point(344, 249);
            this.chSchoolNumTxt.MaxLength = 45;
            this.chSchoolNumTxt.Name = "chSchoolNumTxt";
            this.chSchoolNumTxt.Size = new System.Drawing.Size(177, 24);
            this.chSchoolNumTxt.TabIndex = 1;
            this.chSchoolNumTxt.TabStop = false;
            // 
            // dGV1
            // 
            this.dGV1.AllowUserToAddRows = false;
            this.dGV1.AllowUserToDeleteRows = false;
            this.dGV1.AllowUserToOrderColumns = true;
            this.dGV1.AllowUserToResizeColumns = false;
            this.dGV1.AllowUserToResizeRows = false;
            this.dGV1.AutoGenerateColumns = false;
            this.dGV1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dGV1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.markDataGridViewTextBoxColumn,
            this.numberOfSchoolDataGridViewTextBoxColumn});
            this.dGV1.DataSource = this.sampleAbitBS;
            this.dGV1.Location = new System.Drawing.Point(9, 21);
            this.dGV1.MultiSelect = false;
            this.dGV1.Name = "dGV1";
            this.dGV1.ReadOnly = true;
            this.dGV1.RowHeadersVisible = false;
            this.dGV1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV1.Size = new System.Drawing.Size(513, 150);
            this.dGV1.TabIndex = 0;
            this.dGV1.SelectionChanged += new System.EventHandler(this.DGV1_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.idDataGridViewTextBoxColumn.Width = 70;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.surnameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.surnameDataGridViewTextBoxColumn.Width = 110;
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
            this.markDataGridViewTextBoxColumn.Width = 60;
            // 
            // numberOfSchoolDataGridViewTextBoxColumn
            // 
            this.numberOfSchoolDataGridViewTextBoxColumn.DataPropertyName = "NumberOfSchool";
            this.numberOfSchoolDataGridViewTextBoxColumn.HeaderText = "Номер школи";
            this.numberOfSchoolDataGridViewTextBoxColumn.Name = "numberOfSchoolDataGridViewTextBoxColumn";
            this.numberOfSchoolDataGridViewTextBoxColumn.ReadOnly = true;
            this.numberOfSchoolDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.numberOfSchoolDataGridViewTextBoxColumn.Width = 170;
            // 
            // chMarkTxt
            // 
            this.chMarkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chMarkTxt.Location = new System.Drawing.Point(277, 249);
            this.chMarkTxt.MaxLength = 20;
            this.chMarkTxt.Name = "chMarkTxt";
            this.chMarkTxt.Size = new System.Drawing.Size(58, 24);
            this.chMarkTxt.TabIndex = 1;
            this.chMarkTxt.TabStop = false;
            // 
            // chNameTxt
            // 
            this.chNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chNameTxt.Location = new System.Drawing.Point(149, 249);
            this.chNameTxt.MaxLength = 45;
            this.chNameTxt.Name = "chNameTxt";
            this.chNameTxt.Size = new System.Drawing.Size(122, 24);
            this.chNameTxt.TabIndex = 1;
            this.chNameTxt.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Прізвище";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(341, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Номер школи";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(153, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ім\'я";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Оцінка";
            // 
            // RedactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RedactionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Керування даними";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RedactionForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleAbitBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox addSurnameTxt;
        private System.Windows.Forms.TextBox addSchoolNumTxt;
        private System.Windows.Forms.TextBox addMarkTxt;
        private System.Windows.Forms.TextBox addNameTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.ComboBox cB1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button chBut;
        private System.Windows.Forms.TextBox chSurnameTxt;
        private System.Windows.Forms.TextBox chSchoolNumTxt;
        private System.Windows.Forms.TextBox chMarkTxt;
        private System.Windows.Forms.TextBox chNameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.BindingSource sampleAbitBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfSchoolDataGridViewTextBoxColumn;
    }
}