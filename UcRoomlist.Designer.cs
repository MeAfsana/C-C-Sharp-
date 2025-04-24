
namespace Hotel_Management_System.User_Controls
{
    partial class UcRoomlist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcRoomlist));
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avaliableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addRoomNEwBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbloginDataSet4 = new Hotel_Management_System.cmbloginDataSet4();
            this.addroomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new Hotel_Management_System.masterDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.addroomTableAdapter = new Hotel_Management_System.masterDataSetTableAdapters.AddroomTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.addRoomNEwTableAdapter = new Hotel_Management_System.cmbloginDataSet4TableAdapters.AddRoomNEwTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRoomNEwBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addroomBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNoDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.bedDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.avaliableDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.addRoomNEwBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(66, 183);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1142, 294);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "RoomNo";
            this.roomNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            this.roomNoDataGridViewTextBoxColumn.Width = 92;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.Width = 69;
            // 
            // bedDataGridViewTextBoxColumn
            // 
            this.bedDataGridViewTextBoxColumn.DataPropertyName = "Bed";
            this.bedDataGridViewTextBoxColumn.HeaderText = "Bed";
            this.bedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bedDataGridViewTextBoxColumn.Name = "bedDataGridViewTextBoxColumn";
            this.bedDataGridViewTextBoxColumn.Width = 62;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 69;
            // 
            // avaliableDataGridViewTextBoxColumn
            // 
            this.avaliableDataGridViewTextBoxColumn.DataPropertyName = "Avaliable";
            this.avaliableDataGridViewTextBoxColumn.HeaderText = "Avaliable";
            this.avaliableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.avaliableDataGridViewTextBoxColumn.Name = "avaliableDataGridViewTextBoxColumn";
            this.avaliableDataGridViewTextBoxColumn.Width = 94;
            // 
            // addRoomNEwBindingSource
            // 
            this.addRoomNEwBindingSource.DataMember = "AddRoomNEw";
            this.addRoomNEwBindingSource.DataSource = this.cmbloginDataSet4;
            // 
            // cmbloginDataSet4
            // 
            this.cmbloginDataSet4.DataSetName = "cmbloginDataSet4";
            this.cmbloginDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addroomBindingSource
            // 
            this.addroomBindingSource.DataMember = "Addroom";
            this.addroomBindingSource.DataSource = this.masterDataSetBindingSource;
            // 
            // masterDataSetBindingSource
            // 
            this.masterDataSetBindingSource.DataSource = this.masterDataSet;
            this.masterDataSetBindingSource.Position = 0;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Olive;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 41);
            this.label1.TabIndex = 2;
            this.label1.Text = "Room List";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Olive;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1015, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 80);
            this.button1.TabIndex = 3;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addroomTableAdapter
            // 
            this.addroomTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Olive;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(69, 525);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.label2.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 71);
            this.label2.TabIndex = 0;
            this.label2.Text = "ADMIN";
            // 
            // addRoomNEwTableAdapter
            // 
            this.addRoomNEwTableAdapter.ClearBeforeFill = true;
            // 
            // UcRoomlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "UcRoomlist";
            this.Size = new System.Drawing.Size(1198, 525);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addRoomNEwBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbloginDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addroomBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource addroomBindingSource;
        private System.Windows.Forms.BindingSource masterDataSetBindingSource;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private masterDataSetTableAdapters.AddroomTableAdapter addroomTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn avaliableDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource addRoomNEwBindingSource;
        private cmbloginDataSet4 cmbloginDataSet4;
        private cmbloginDataSet4TableAdapters.AddRoomNEwTableAdapter addRoomNEwTableAdapter;
    }
}
