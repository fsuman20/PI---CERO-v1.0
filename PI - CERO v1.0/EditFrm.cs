using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PI___CERO_v1._0.Models;
using PI___CERO_v1._0.Repositories;

namespace PI___CERO_v1._0
{
    public partial class EditFrm : Form

    {
        int Selected;
        string SelectId;
        string Name;
        string Description;
        string Project;


        private void edit_Load(object sender, EventArgs e)
        {
           /* if(Selected == 0)
            {
                var sources = Fina.GetSources();
                cboSource.DataSource = sources;

                var cipemployees = CipEmployeeRepository.GetCipEmployees();
                cboEmployee.DataSource = cipemployees;

            }
            else if(Selected == 1)
            {
                int supplierid = FoiEmployeeRepository.GetCurrentId(selectedId);
                var foiemployees = FoiEmployeeRepository.GetFoiEmployees();
                cboSupplier.DataSource = foiemployees;
                cboSupplier.SelectedIndex = supplierid - 1;


                int sourceid = SourceRepository.GetCurrentId(selectedId);
                var sources = SourceRepository.GetSources();
                cboSource.DataSource = sources;
                cboSource.SelectedIndex = sourceid - 1;


                int employeeid = CipEmployeeRepository.GetCurrentId(selectedId);
                var cipemployees = CipEmployeeRepository.GetCipEmployees();
                cboEmployee.DataSource = cipemployees;
                cboEmployee.SelectedIndex = employeeid - 1;

                int eqiupmenttypeid = EquipmentTypeRepository.GetCurrentId(selectedId);
                var eqiupmenttypes = EquipmentTypeRepository.GetEquipmentTypes();
                cboEquipmentType.DataSource = eqiupmenttypes;
                cboEquipmentType.SelectedIndex = eqiupmenttypeid - 1;

                txtName.Text = Name;
                txtDescription.Text = Description;
                txtProjecte.Text = Project;
            }
            */
        }

        public EditFrm(int id,string index, string name, string project, string description)
        {
            Selected = id;
            SelectId = index;
            Name = name;
            Description = description;
            Project = project;
            InitializeComponent();

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