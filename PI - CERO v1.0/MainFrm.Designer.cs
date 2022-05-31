namespace PI___CERO_v1._0
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.btnManage = new System.Windows.Forms.Button();
            this.DB_Search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.opremaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fsuman20_DBDataSetMain = new PI___CERO_v1._0.fsuman20_DBDataSetMain();
            this.popisopreme = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.opremaTableAdapter = new PI___CERO_v1._0.fsuman20_DBDataSetMainTableAdapters.OpremaTableAdapter();
            this.dospijeceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaposlenikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projektDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.financiranjeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridEquipment = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opremaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsuman20_DBDataSetMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEquipment)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManage.Location = new System.Drawing.Point(940, 399);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(129, 50);
            this.btnManage.TabIndex = 0;
            this.btnManage.Text = "Upravljaj podacima";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // DB_Search
            // 
            this.DB_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DB_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_Search.Location = new System.Drawing.Point(498, 33);
            this.DB_Search.Name = "DB_Search";
            this.DB_Search.Size = new System.Drawing.Size(423, 30);
            this.DB_Search.TabIndex = 1;
            this.DB_Search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DB_Search_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(940, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // opremaBindingSource
            // 
            this.opremaBindingSource.DataMember = "Oprema";
            this.opremaBindingSource.DataSource = this.fsuman20_DBDataSetMain;
            // 
            // fsuman20_DBDataSetMain
            // 
            this.fsuman20_DBDataSetMain.DataSetName = "fsuman20_DBDataSetMain";
            this.fsuman20_DBDataSetMain.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // popisopreme
            // 
            this.popisopreme.AutoSize = true;
            this.popisopreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.popisopreme.Location = new System.Drawing.Point(22, 26);
            this.popisopreme.Name = "popisopreme";
            this.popisopreme.Size = new System.Drawing.Size(210, 36);
            this.popisopreme.TabIndex = 3;
            this.popisopreme.Text = "Popis opreme";
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.Location = new System.Drawing.Point(940, 333);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(129, 50);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Dodaj novu stavku";
            this.btnNew.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(940, 268);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 50);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Obriši odabranu stavku";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // opremaTableAdapter
            // 
            this.opremaTableAdapter.ClearBeforeFill = true;
            // 
            // dospijeceDataGridViewTextBoxColumn
            // 
            this.dospijeceDataGridViewTextBoxColumn.DataPropertyName = "Dospijece";
            this.dospijeceDataGridViewTextBoxColumn.HeaderText = "Dospijece";
            this.dospijeceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dospijeceDataGridViewTextBoxColumn.Name = "dospijeceDataGridViewTextBoxColumn";
            this.dospijeceDataGridViewTextBoxColumn.Width = 125;
            // 
            // zaposlenikDataGridViewTextBoxColumn
            // 
            this.zaposlenikDataGridViewTextBoxColumn.DataPropertyName = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.HeaderText = "Zaposlenik";
            this.zaposlenikDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.zaposlenikDataGridViewTextBoxColumn.Name = "zaposlenikDataGridViewTextBoxColumn";
            this.zaposlenikDataGridViewTextBoxColumn.Width = 125;
            // 
            // projektDataGridViewTextBoxColumn
            // 
            this.projektDataGridViewTextBoxColumn.DataPropertyName = "Projekt";
            this.projektDataGridViewTextBoxColumn.HeaderText = "Projekt";
            this.projektDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.projektDataGridViewTextBoxColumn.Name = "projektDataGridViewTextBoxColumn";
            this.projektDataGridViewTextBoxColumn.Width = 125;
            // 
            // financiranjeDataGridViewTextBoxColumn
            // 
            this.financiranjeDataGridViewTextBoxColumn.DataPropertyName = "Financiranje";
            this.financiranjeDataGridViewTextBoxColumn.HeaderText = "Financiranje";
            this.financiranjeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.financiranjeDataGridViewTextBoxColumn.Name = "financiranjeDataGridViewTextBoxColumn";
            this.financiranjeDataGridViewTextBoxColumn.Width = 125;
            // 
            // opisDataGridViewTextBoxColumn
            // 
            this.opisDataGridViewTextBoxColumn.DataPropertyName = "Opis";
            this.opisDataGridViewTextBoxColumn.HeaderText = "Opis";
            this.opisDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.opisDataGridViewTextBoxColumn.Name = "opisDataGridViewTextBoxColumn";
            this.opisDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // DataGridEquipment
            // 
            this.DataGridEquipment.AutoGenerateColumns = false;
            this.DataGridEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEquipment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nazivDataGridViewTextBoxColumn,
            this.opisDataGridViewTextBoxColumn,
            this.financiranjeDataGridViewTextBoxColumn,
            this.projektDataGridViewTextBoxColumn,
            this.zaposlenikDataGridViewTextBoxColumn,
            this.dospijeceDataGridViewTextBoxColumn});
            this.DataGridEquipment.DataSource = this.opremaBindingSource;
            this.DataGridEquipment.Location = new System.Drawing.Point(28, 81);
            this.DataGridEquipment.Name = "DataGridEquipment";
            this.DataGridEquipment.RowHeadersWidth = 51;
            this.DataGridEquipment.RowTemplate.Height = 24;
            this.DataGridEquipment.Size = new System.Drawing.Size(893, 368);
            this.DataGridEquipment.TabIndex = 5;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 504);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.DataGridEquipment);
            this.Controls.Add(this.popisopreme);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DB_Search);
            this.Controls.Add(this.btnManage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Text = "CERO v1.0";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opremaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fsuman20_DBDataSetMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEquipment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.TextBox DB_Search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label popisopreme;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private fsuman20_DBDataSetMain fsuman20_DBDataSetMain;
        private System.Windows.Forms.BindingSource opremaBindingSource;
        private fsuman20_DBDataSetMainTableAdapters.OpremaTableAdapter opremaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dospijeceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaposlenikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn projektDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn financiranjeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn opisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView DataGridEquipment;
    }
}