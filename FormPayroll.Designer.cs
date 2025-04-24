
namespace Hotel_Management_System
{
    partial class FormPayroll
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayroll));
            this.salaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbloginDataSet6 = new Hotel_Management_System.cmbloginDataSet6();
            this.salaryTableAdapter = new Hotel_Management_System.cmbloginDataSet6TableAdapters.SalaryTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.btnDis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bonusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbloginDataSet16 = new Hotel_Management_System.cmbloginDataSet16();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.salaryTableAdapter1 = new Hotel_Management_System.cmbloginDataSet16TableAdapters.SalaryTableAdapter();
            this.btnback = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet16)).BeginInit();
            this.SuspendLayout();
            // 
            // salaryBindingSource
            // 
            this.salaryBindingSource.DataMember = "Salary";
            this.salaryBindingSource.DataSource = this.cmbloginDataSet6;
            // 
            // cmbloginDataSet6
            // 
            this.cmbloginDataSet6.DataSetName = "cmbloginDataSet6";
            this.cmbloginDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // salaryTableAdapter
            // 
            this.salaryTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tan;
            this.button4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(122, 590);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 41);
            this.button4.TabIndex = 88;
            this.button4.Text = "Update";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnDis
            // 
            this.btnDis.BackColor = System.Drawing.Color.Tan;
            this.btnDis.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDis.Location = new System.Drawing.Point(229, 535);
            this.btnDis.Name = "btnDis";
            this.btnDis.Size = new System.Drawing.Size(110, 46);
            this.btnDis.TabIndex = 87;
            this.btnDis.Text = "Display";
            this.btnDis.UseVisualStyleBackColor = false;
            this.btnDis.Click += new System.EventHandler(this.btnDis_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(55, 535);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 49);
            this.button1.TabIndex = 86;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Linen;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 35);
            this.label6.TabIndex = 85;
            this.label6.Text = "Salary Status";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Linen;
            this.comboBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Received",
            "Pending"});
            this.comboBox1.Location = new System.Drawing.Point(192, 448);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 43);
            this.comboBox1.TabIndex = 84;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Linen;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 35);
            this.label5.TabIndex = 83;
            this.label5.Text = "Bonus";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Linen;
            this.textBox4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(181, 363);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(193, 43);
            this.textBox4.TabIndex = 82;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Linen;
            this.textBox3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(181, 294);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(193, 43);
            this.textBox3.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Linen;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 35);
            this.label4.TabIndex = 80;
            this.label4.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.PeachPuff;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(375, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(212, 54);
            this.label8.TabIndex = 79;
            this.label8.Text = "Payroll page";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Tan;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(468, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 25);
            this.label7.TabIndex = 78;
            this.label7.Text = "SALARY INFO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn,
            this.bonusDataGridViewTextBoxColumn,
            this.salaryStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.salaryBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(467, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(549, 392);
            this.dataGridView1.TabIndex = 77;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 74;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.Width = 66;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            this.salaryDataGridViewTextBoxColumn.Width = 77;
            // 
            // bonusDataGridViewTextBoxColumn
            // 
            this.bonusDataGridViewTextBoxColumn.DataPropertyName = "Bonus";
            this.bonusDataGridViewTextBoxColumn.HeaderText = "Bonus";
            this.bonusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bonusDataGridViewTextBoxColumn.Name = "bonusDataGridViewTextBoxColumn";
            this.bonusDataGridViewTextBoxColumn.Width = 77;
            // 
            // salaryStatusDataGridViewTextBoxColumn
            // 
            this.salaryStatusDataGridViewTextBoxColumn.DataPropertyName = "SalaryStatus";
            this.salaryStatusDataGridViewTextBoxColumn.HeaderText = "SalaryStatus";
            this.salaryStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salaryStatusDataGridViewTextBoxColumn.Name = "salaryStatusDataGridViewTextBoxColumn";
            this.salaryStatusDataGridViewTextBoxColumn.Width = 117;
            // 
            // salaryBindingSource1
            // 
            this.salaryBindingSource1.DataMember = "Salary";
            this.salaryBindingSource1.DataSource = this.cmbloginDataSet16;
            // 
            // cmbloginDataSet16
            // 
            this.cmbloginDataSet16.DataSetName = "cmbloginDataSet16";
            this.cmbloginDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Linen;
            this.textBox2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(181, 229);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(193, 35);
            this.textBox2.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Linen;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 35);
            this.label3.TabIndex = 75;
            this.label3.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Linen;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 35);
            this.label2.TabIndex = 74;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Linen;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 35);
            this.label1.TabIndex = 73;
            this.label1.Text = "ID";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Linen;
            this.textBox1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(181, 112);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 35);
            this.textBox1.TabIndex = 71;
            // 
            // salaryTableAdapter1
            // 
            this.salaryTableAdapter1.ClearBeforeFill = true;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Tan;
            this.btnback.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnback.Location = new System.Drawing.Point(978, -1);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(50, 39);
            this.btnback.TabIndex = 89;
            this.btnback.Text = "<-";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Linen;
            this.textBox5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(181, 177);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(193, 35);
            this.textBox5.TabIndex = 90;
            // 
            // FormPayroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 668);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPayroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPayroll";
            this.Load += new System.EventHandler(this.FormPayroll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salaryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet16)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private cmbloginDataSet6 cmbloginDataSet6;
        private System.Windows.Forms.BindingSource salaryBindingSource;
        private cmbloginDataSet6TableAdapters.SalaryTableAdapter salaryTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnDis;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private cmbloginDataSet16 cmbloginDataSet16;
        private System.Windows.Forms.BindingSource salaryBindingSource1;
        private cmbloginDataSet16TableAdapters.SalaryTableAdapter salaryTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bonusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.TextBox textBox5;
    }
}