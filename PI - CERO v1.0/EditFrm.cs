using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI___CERO_v1._0
{
    public partial class EditFrm : Form

    {
        public EditFrm()
        {
            InitializeComponent();
        }

        private void edit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fsuman20_DBDataSetMain.Oprema' table. You can move, or remove it, as needed.
            this.opremaTableAdapter.Fill(this.fsuman20_DBDataSetMain.Oprema);
            // TODO: This line of code loads data into the 'fsuman20_DBDataSet.Zaposlenik' table. You can move, or remove it, as needed.
            this.zaposlenikTableAdapter.Fill(this.fsuman20_DBDataSet.Zaposlenik);

        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            if (1 > 3)
            {
                MessageBox.Show("Podaci nisu upisani!", "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { MessageBox.Show("Podaci uspješno spremljeni"); }
            Refresh();
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            Close();
        }
    }
}
