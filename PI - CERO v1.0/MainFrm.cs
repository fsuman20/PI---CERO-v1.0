using PI___CERO_v1._0.Repositories;
using System;
using System.Windows.Forms;
using PI___CERO_v1._0.Models;

namespace PI___CERO_v1._0
{
    public partial class MainFrm : Form
    {
        int selected;
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            DataShowEquipment();
        }

        private void DataShowEquipment()
        {
            var equipment = EquipmentRepository.GetEquimpent();
            DataGridEquipment.DataSource = equipment;
            DataGridEquipment.Columns["Id"].DisplayIndex = 0;
            DataGridEquipment.Columns["EquipmentName"].DisplayIndex = 1;
            DataGridEquipment.Columns["Description"].DisplayIndex = 2;
            DataGridEquipment.Columns["Project_finance"].DisplayIndex = 3;
            DataGridEquipment.Columns["Project"].DisplayIndex = 4;
            DataGridEquipment.Columns["Employee"].DisplayIndex = 5;
        }
       

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = DataGridEquipment.CurrentRow.Cells["Id"].Value.ToString();
            EquipmentRepository.DeleteEquipment(id);
            DataShowEquipment();

        }

        private void btnManage_Click(object sender, EventArgs e)
        {

            selected = 1;
            string id = DataGridEquipment.CurrentRow.Cells["Id"].Value.ToString();
            string name = DataGridEquipment.CurrentRow.Cells["EquipmentName"].Value.ToString();
            string description = DataGridEquipment.CurrentRow.Cells["Description"].Value.ToString();
            string finance = DataGridEquipment.CurrentRow.Cells["Project_finance"].Value.ToString();
            string project = DataGridEquipment.CurrentRow.Cells["Project"].Value.ToString();
            string employee = DataGridEquipment.CurrentRow.Cells["Employee"].Value.ToString();
          //  EditFrm editFrm = new EditFrm(selected, id, name, description, finance, project, employee);
            //editFrm.ShowDialog();

        }

        private void DB_Search_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.btnManage = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DataGridEquipment = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEquipment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnManage.Location = new System.Drawing.Point(717, 386);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(132, 51);
            this.btnManage.TabIndex = 0;
            this.btnManage.Text = "Upravljaj podacima";
            this.btnManage.UseCompatibleTextRendering = true;
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(758, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(8, 8);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // DataGridEquipment
            // 
            this.DataGridEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridEquipment.Location = new System.Drawing.Point(30, 118);
            this.DataGridEquipment.Name = "DataGridEquipment";
            this.DataGridEquipment.RowHeadersWidth = 51;
            this.DataGridEquipment.RowTemplate.Height = 24;
            this.DataGridEquipment.Size = new System.Drawing.Size(655, 319);
            this.DataGridEquipment.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(717, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(364, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(321, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 36);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prikaz opreme";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(717, 329);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 51);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Obriši odabranu stavku";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // MainFrm
            // 
            this.ClientSize = new System.Drawing.Size(877, 461);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DataGridEquipment);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnManage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainFrm";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEquipment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnManage;
        private Button button3;
        private DataGridView DataGridEquipment;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label1;
        private Button btnDelete;
    }
}
