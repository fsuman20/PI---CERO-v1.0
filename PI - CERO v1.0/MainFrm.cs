using PI___CERO_v1._0.Repositories;
using System;
using System.Windows.Forms;

namespace PI___CERO_v1._0
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fsuman20_DBDataSetMain.Oprema' table. You can move, or remove it, as needed.
            this.opremaTableAdapter.Fill(this.fsuman20_DBDataSetMain.Oprema);
          //  DataShowEquipment();
        }

     /*   private void DataShowEquipment()
        {
            var equipment = EquipmentRepository.GetEquimpent();
            DataGridEquipment.DataSource = equipment;
            DataGridEquipment.Columns["ID"].DisplayIndex = 0;
            DataGridEquipment.Columns["Naziv"].DisplayIndex = 1;
            DataGridEquipment.Columns["Opis"].DisplayIndex = 2;
            DataGridEquipment.Columns["Financiranje"].DisplayIndex = 3;
            DataGridEquipment.Columns["Projekt"].DisplayIndex = 4;
            DataGridEquipment.Columns["Zaposlenik"].DisplayIndex = 5;
        }
       */

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = DataGridEquipment.CurrentCell.RowIndex;
            DataGridEquipment.Rows.RemoveAt(index);

        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            EditFrm editFrm = new EditFrm();
            editFrm.ShowDialog();

        }

        private void DB_Search_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        public void RefreshForm()
        {
            DataGridEquipment.Update();
        }
    }
}
