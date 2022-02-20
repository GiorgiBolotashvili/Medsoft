using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MedsoftExercise1.Repository;
using MedsoftExercise1.DTO;

namespace MedsoftExercise1
{
    public partial class MainForm : Form
    {
        private int _index { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void dgvPatientList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex != -1)
                {
                    dgvPatientList.ClearSelection();
                    dgvPatientList.Rows[e.RowIndex].Selected = true;
                }
            }
        }

        public void LoadPatients()
        {
            List<string> headers = new List<string> { "ID", "პაციენტის გვარი სახელი", "დაბადების თარიღი", "სქესი", "მობილურის ნომერი", "მისამართი" };
            BaseRepository repository = new BaseRepository();
            dgvPatientList.DataSource = repository.GetAllObjects(new Patient());
            int index = 0;
            foreach (var item in headers)
            {
                dgvPatientList.Columns[index].HeaderText = item;
                dgvPatientList.Columns[index].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                index++;
            }
            dgvPatientList.RowHeadersWidth = 25;
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm(this);
            addPatientForm.ShowDialog();

        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void Delete()
        {
            DialogResult result = MessageBox.Show("გსურთ მონიშნული ჩანაწერის წაშლა?", "პაციენტის წაშლა", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                PatientRepository prodRep = new PatientRepository();
                prodRep.Delete(new Patient(), (int)dgvPatientList.Rows[dgvPatientList.CurrentRow.Index].Cells[0].Value);
            }
            LoadPatients();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            AddPatientForm addPatientForm = new AddPatientForm(this, dgvPatientList.Rows[dgvPatientList.CurrentRow.Index]);
            addPatientForm.ShowDialog();
        }
    }
}
