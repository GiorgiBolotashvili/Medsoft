using MedsoftExercise1.Repository;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace MedsoftExercise1
{
    public partial class AddPatientForm : Form
    {
        private MainForm _form;
        private bool _checkAddOrEdit;
        private int _id;
        public AddPatientForm(MainForm form)
        {
            InitializeComponent();
            _form = form;
            _checkAddOrEdit = true;
            btnAdd.Enabled = false;
        }
        public AddPatientForm(MainForm form, DataGridViewRow row)
        {
            InitializeComponent();
            _form = form;
            FillTextBoxes(row);
            btnAdd.Text = "შეცვლა";
            _checkAddOrEdit = false;
            this.Text = "პაციენტის რედაქტირება";
        }

        private void FillTextBoxes(DataGridViewRow row)
        {
            _id = (int)row.Cells[0].Value;
            tbFullName.Text = row.Cells[1].Value.ToString();
            dtpDob.Value = Convert.ToDateTime(row.Cells[2].Value);
            tbPhone.Text = string.Join("", row.Cells[4].Value.ToString().Split("-"));
            tbAddress.Text = row.Cells[5].Value.ToString();
            rbMale.Checked = row.Cells[3].Value.ToString().Equals("მამრობითი") ? true : false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_checkAddOrEdit)
            {
                Add();
            }
            else
                Edit();

            this.Close();
            _form.LoadPatients();
        }

        private void tbFullName_Validating(object sender, CancelEventArgs e)
        {
            errorFullName.Clear();
            if (string.IsNullOrWhiteSpace(tbFullName.Text))
            {
                errorFullName.SetError(tbFullName, "შეავსეთ ველი");
                btnAdd.Enabled = false;
            }
            else if (!ValidateFullName(tbFullName.Text))
            {
                errorFullName.SetError(tbFullName, "გამოიყენეთ ქართული შრიფტი");
                btnAdd.Enabled = false;
            }
            else if (tbFullName.Text.Split(" ").Length < 2 || tbFullName.Text.Split(" ").Where(x => x.Length == 1).Any())
            {
                errorFullName.SetError(tbFullName, "ჩაწერეთ გვარი და სახელი");
                btnAdd.Enabled = false;
            }
            else
                btnAdd.Enabled = true;
        }

        private bool ValidateFullName(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (!(text[i] == ' ') && text[i] < 4303 || text[i] > 4336)
                {
                    return false;
                }
            }
            return true;
        }

        private void tbPhone_Validating(object sender, CancelEventArgs e)
        {
            errorPhone.Clear();
            if (string.IsNullOrWhiteSpace(tbPhone.Text))
            {
                btnAdd.Enabled = true;
                return;
            }
            else if (tbPhone.Text.Length != 9)
            {
                errorPhone.SetError(tbPhone, "შეიყვანეთ ზუსტად ცხრა ციფრი");
                btnAdd.Enabled = false;
            }
            else if (PhoneNumberValidation(tbPhone.Text))
            {
                errorPhone.SetError(tbPhone, "დასაშვებია მხოლოდ ციფრები");
                btnAdd.Enabled = false;
            }
            else if (Convert.ToInt32(tbPhone.Text[0]) != 53)
            {
                errorPhone.SetError(tbPhone, "ნომერი უნდა იწყებოდეს 5-ით");
                btnAdd.Enabled = false;
            }
            else
                btnAdd.Enabled = true;

        }

        private bool PhoneNumberValidation(string text)
        {
            return text.Where(x => Convert.ToInt32(x) < 48 || Convert.ToInt32(x) > 57).Any();
        }

        private void dtpDob_Validating(object sender, CancelEventArgs e)
        {
            errorDob.Clear();
            if (dtpDob.Value > DateTime.Today)
            {
                errorDob.SetError(dtpDob, "მიუთითეთ დაბადების თარიღი");
                btnAdd.Enabled = false;
            }
            else
                btnAdd.Enabled = true;
        }
        private void Add()
        {
            PatientRepository repository = new PatientRepository();
            repository.Insert(new SqlParameter()
            {
                ParameterName = "@FullName",
                Value = tbFullName.Text
            }, new SqlParameter()
            {
                ParameterName = "@Dob",
                Value = dtpDob.Value
            }, new SqlParameter()
            {
                ParameterName = "@GenderName",
                Value = rbMale.Checked ? "მამრობითი" : "მდედრობითი"
            }, new SqlParameter()
            {
                ParameterName = "@Phone",
                Value = repository.FormatPhoneNUmber(tbPhone.Text)
            }, new SqlParameter()
            {
                ParameterName = "@Address",
                Value = tbAddress.Text
            });
            DialogResult = DialogResult.OK;
        }
        private void Edit()
        {
            PatientRepository repository = new PatientRepository();
            repository.Update(new SqlParameter()
            {
                ParameterName = "@ID",
                Value = _id
            }, new SqlParameter()
            {
                ParameterName = "@FullName",
                Value = tbFullName.Text
            }, new SqlParameter()
            {
                ParameterName = "@Dob",
                Value = dtpDob.Value
            }, new SqlParameter()
            {
                ParameterName = "@GenderName",
                Value = rbMale.Checked ? "მამრობითი" : "მდედრობითი"
            }, new SqlParameter()
            {
                ParameterName = "@Phone",
                Value = repository.FormatPhoneNUmber(tbPhone.Text)
            }, new SqlParameter()
            {
                ParameterName = "@Address",
                Value = tbAddress.Text
            });
            DialogResult = DialogResult.OK;
        }
    }
}
