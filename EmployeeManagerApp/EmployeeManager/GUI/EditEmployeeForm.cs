using EmployeeClassLibrary;
using EmployeeClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagerUI
{
    public partial class EditEmployeeForm : Form
    {
        private List<Employee> GetAllEmployees = GlobalConfig.connections.GetAllEmployees();
        private List<Employee> GetAllArchievedEmployees = GlobalConfig.connections.GetAllArchievedEmployees();
        private bool selectedEmployeeList = false;
        private int count;

        private readonly String[] provinces = { "Alberta", "British Columbia", "Manitoba", "New Brunswick", "New foundland And Labrador",
                               "Northwest Territories", "Nova Scotia", "Nunavut", "Ontario", "Prince Edward Island",
                               "Quebec", "Saskatchewan", "Yukon" };

        public EditEmployeeForm()
        {
            InitializeComponent();
        }

        private object CountryList()
        {
            List<string> cultureList = new List<string>();
            CultureInfo[] cultureInfo = CultureInfo.GetCultures(CultureTypes.SpecificCultures);

            foreach (CultureInfo culture in cultureInfo)
            {
                RegionInfo regionInfo = new RegionInfo(culture.LCID);
                if (!cultureList.Contains(regionInfo.EnglishName))
                {
                    cultureList.Add(regionInfo.EnglishName);
                }
            }

            cultureList.Sort();

            return cultureList;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            var empManagement = new EmployeeManagementForm();
            empManagement.Closed += (s, args) => Close();
            empManagement.Show();
        }

        private void Reset()
        {
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            MiddleNameTextBox.Text = "";
            AgeTextBox.Text = "";
            GenderComboBox.SelectedIndex = 0;
            CellphoneMaskedTextBox.Text = "";
            EmailTextBox.Text = "";
            DobDateTimePicker.Value = DateTime.Now;

            StreetNameTextBox.Text = "";
            StreetNumberTextBox.Text = "";
            AppartmentNumberTextBox.Text = "";
            ZipCodeMaskedTextBox.Text = "";
            CountryComboBox.SelectedIndex = 0;
            ProvinceComboBox.DataSource = null;
            ProvinceComboBox.Enabled = false;

            JobTitleTextBox.Text = "";
            DepartmentTextBox.Text = "";
            HasCommissionComboBox.SelectedIndex = 0;
            CommissionAmountTextBox.Text = "";
            CommissionAmountTextBox.Enabled = false;
            CommissionAmountTextBox.PlaceholderText = "";
            BaseSalaryTextBox.Text = "";
            IsAdminComboBox.SelectedIndex = 0;
            AdminUsernameTextBox.Text = "";
            AdminUsernameTextBox.PlaceholderText = "";
            AdminPasswordTextBox.Text = "";
            AdminPasswordTextBox.PlaceholderText = "";

            FirstNameErrorLabel.Text = "";
            LastNameErrorLabel.Text = "";
            MiddleNameErrorLabel.Text = "";
            AgeErrorLabel.Text = "";
            StreetNumberErrorLabel.Text = "";
            StreetNameErrorLabel.Text = "";
            AppartmentErrorLabel.Text = "";
            JobTitleErrorLabel.Text = "";
            DepartmentErrorLabel.Text = "";
            CommissionAmountErrorLabel.Text = "";
            BaseSalaryErrorLabel.Text = "";
            AdminUsernameErrorLabel.Text = "";
            AdminPasswordErrorLabel.Text = "";
            ZipCodeErrorLabel.Text = "";
            CellphoneErrorLabel.Text = "";
            EmailErrorLabel.Text = "";
            MasterErrorLabel.Text = "";
            EmployeePicturePictureBox.Image = null;

            ApplyChangesButton.Enabled = false;

            FirstNameTextBox.Focus();
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            count = 0;

            count += EmployeeValidation.FirstNameValidation(FirstNameTextBox, FirstNameErrorLabel);
            count += EmployeeValidation.LastNameValidation(LastNameTextBox, LastNameErrorLabel);
            count += EmployeeValidation.MiddleNameValidation(MiddleNameTextBox, MiddleNameErrorLabel);
            count += EmployeeValidation.CellphoneValidation(CellphoneMaskedTextBox, CellphoneErrorLabel);
            count += EmployeeValidation.EmailValidation(EmailTextBox, EmailErrorLabel);
            count += EmployeeValidation.AgeValidation(AgeTextBox, AgeErrorLabel);
            count += EmployeeValidation.StreetNumberValidation(StreetNumberTextBox, StreetNumberErrorLabel);
            count += EmployeeValidation.StreetNameValidation(StreetNameTextBox, StreetNameErrorLabel);
            count += EmployeeValidation.AppartmentValidation(AppartmentNumberTextBox, AppartmentErrorLabel);
            count += EmployeeValidation.ZipCodeValidation(ZipCodeMaskedTextBox, ZipCodeErrorLabel);
            count += EmployeeValidation.JobTitleValidation(JobTitleTextBox, JobTitleErrorLabel);
            count += EmployeeValidation.DepartmentValidation(DepartmentTextBox, DepartmentErrorLabel);

            if (HasCommissionComboBox.SelectedIndex == 1)
            {
                count += EmployeeValidation.CommissionAmountValidation(CommissionAmountTextBox, CommissionAmountErrorLabel);
            }

            count += EmployeeValidation.BaseSalaryValidation(BaseSalaryTextBox, BaseSalaryErrorLabel);
            count += EmployeeValidation.AdminUsernameValidation(AdminUsernameTextBox, AdminUsernameErrorLabel);
            count += EmployeeValidation.AdminPasswordValidation(AdminPasswordTextBox, AdminPasswordErrorLabel);

            if (count != 0)
            {
                isValid = false;
            }
            else
            {
                isValid = true;
            }

            return isValid;
        }

        private void AdjustColumnOrderForEmployeeFile()
        {
            EmployeeDataGridView.Columns["Id"].DisplayIndex = 0;
            EmployeeDataGridView.Columns["FirstName"].DisplayIndex = 1;
            EmployeeDataGridView.Columns["LastName"].DisplayIndex = 2;
            EmployeeDataGridView.Columns["MiddleName"].DisplayIndex = 3;
            EmployeeDataGridView.Columns["Dob"].DisplayIndex = 4;
            EmployeeDataGridView.Columns["Age"].DisplayIndex = 5;
            EmployeeDataGridView.Columns["Gender"].DisplayIndex = 6;
            EmployeeDataGridView.Columns["EmailAddress"].DisplayIndex = 7;
            EmployeeDataGridView.Columns["CellphoneNumber"].DisplayIndex = 8;

            EmployeeDataGridView.Columns["StreetNumber"].DisplayIndex = 9;
            EmployeeDataGridView.Columns["StreetName"].DisplayIndex = 10;
            EmployeeDataGridView.Columns["AppartmentNumber"].DisplayIndex = 11;
            EmployeeDataGridView.Columns["Zipcode"].DisplayIndex = 12;
            EmployeeDataGridView.Columns["Country"].DisplayIndex = 13;
            EmployeeDataGridView.Columns["Province"].DisplayIndex = 14;

            EmployeeDataGridView.Columns["StreetNumber"].Visible = true;
            EmployeeDataGridView.Columns["StreetName"].Visible = true;
            EmployeeDataGridView.Columns["AppartmentNumber"].Visible = true;
            EmployeeDataGridView.Columns["Zipcode"].Visible = true;
            EmployeeDataGridView.Columns["Country"].Visible = true;
            EmployeeDataGridView.Columns["Province"].Visible = true;

            EmployeeDataGridView.Columns["MiddleName"].Visible = true;
            EmployeeDataGridView.Columns["Dob"].Visible = true;
            EmployeeDataGridView.Columns["Age"].Visible = true;
            EmployeeDataGridView.Columns["Gender"].Visible = true;
            EmployeeDataGridView.Columns["EmailAddress"].Visible = true;
            EmployeeDataGridView.Columns["CellphoneNumber"].Visible = true;
            EmployeeDataGridView.Columns["Address"].Visible = false;

            EmployeeDataGridView.Columns["BaseSalary"].Visible = true;
            EmployeeDataGridView.Columns["HasCommission"].Visible = true;
            EmployeeDataGridView.Columns["Commission"].Visible = true;
            EmployeeDataGridView.Columns["JobTitle"].Visible = true;
            EmployeeDataGridView.Columns["Department"].Visible = true;
            EmployeeDataGridView.Columns["Doh"].Visible = true;
            EmployeeDataGridView.Columns["IsAdmin"].Visible = true;
            EmployeeDataGridView.Columns["IsActive"].Visible = true;
            EmployeeDataGridView.Columns["TerminationDate"].Visible = false;
            EmployeeDataGridView.Columns["ReasonForTermination"].Visible = false;
            EmployeeDataGridView.Columns["TerminationDetails"].Visible = false;
            EmployeeDataGridView.Columns["Headshot"].Visible = false;
        }

        private void ResetFormButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                int index = EmployeeDataGridView.CurrentRow.Index;
                GetAllEmployees[index].FirstName = FirstNameTextBox.Text;
                GetAllEmployees[index].LastName = LastNameTextBox.Text;
                GetAllEmployees[index].MiddleName = MiddleNameTextBox.Text;
                GetAllEmployees[index].Age = int.Parse(AgeTextBox.Text);
                GetAllEmployees[index].Gender = (Gender)Enum.Parse(typeof(Gender), GenderComboBox.SelectedItem.ToString());
                GetAllEmployees[index].EmailAddress = EmailTextBox.Text;
                GetAllEmployees[index].CellphoneNumber = CellphoneMaskedTextBox.Text;
                GetAllEmployees[index].Address.StreetNumber = int.Parse(StreetNumberTextBox.Text);
                GetAllEmployees[index].Address.StreetName = StreetNameTextBox.Text;

                if (AppartmentNumberTextBox.Text == "" || AppartmentNumberTextBox.Text == null)
                {
                    GetAllEmployees[index].Address.AppartmentNumber = null;
                }
                else
                {
                    GetAllEmployees[index].Address.AppartmentNumber = int.Parse(AppartmentNumberTextBox.Text);
                }

                GetAllEmployees[index].Address.Zipcode = ZipCodeMaskedTextBox.Text;
                GetAllEmployees[index].Address.Country = CountryComboBox.SelectedItem.ToString();

                if (!ProvinceComboBox.Enabled)
                {
                    GetAllEmployees[index].Address.Province = "";
                }
                else
                {
                    GetAllEmployees[index].Address.Province = ProvinceComboBox.SelectedItem.ToString();
                }

                GetAllEmployees[index].Dob = DateTime.Parse(DobDateTimePicker.Text);
                GetAllEmployees[index].BaseSalary = decimal.Parse(BaseSalaryTextBox.Text);

                if (HasCommissionComboBox.SelectedIndex == 0)
                {
                    GetAllEmployees[index].HasCommission = false;
                    GetAllEmployees[index].Commission = 0;
                }
                else
                {
                    GetAllEmployees[index].HasCommission = true;
                    GetAllEmployees[index].Commission = decimal.Parse(CommissionAmountTextBox.Text);
                }

                GetAllEmployees[index].JobTitle = JobTitleTextBox.Text;
                GetAllEmployees[index].Department = DepartmentTextBox.Text;
                GetAllEmployees[index].Doh = DateTime.Now;

                if (IsAdminComboBox.SelectedIndex == 0)
                {
                    GetAllEmployees[index].IsAdmin = false;
                }
                else
                {
                    GetAllEmployees[index].IsAdmin = true;
                }

                GetAllEmployees[index].AdminUsername = AdminUsernameTextBox.Text;
                GetAllEmployees[index].AdminPassword = AdminPasswordTextBox.Text;
                GetAllEmployees[index].IsActive = true;

                int i = AddOneToPictureName(index);
                if (i == 9)
                {
                    i = 1;
                }

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
                EmployeePicturePictureBox.Image.Save($"../../../assets/EmployeePictures/{LastNameTextBox.Text}_{FirstNameTextBox.Text}-{i}.jpg");
                GetAllEmployees[index].Headshot = $"../../../assets/EmployeePictures/{LastNameTextBox.Text}_{FirstNameTextBox.Text}-{i}.jpg";

                GlobalConfig.connections.EditEmployee(GetAllEmployees[index], index, GetAllEmployees[index].Id);

                EmployeeDataGridView.DataSource = null;
                EmployeeDataGridView.Rows.Clear();

                GetAllEmployees = GlobalConfig.connections.GetAllEmployees();
                EmployeeDataGridView.DataSource = GetAllEmployees;
                AdjustColumnOrderForEmployeeFile();

                Reset();
                EmployeeDataGridView.ClearSelection();
            }
            else
            {
                MasterErrorLabel.Text = "* Please Fix all <" + count + "> errors to proceed!";
            }
        }

        private int AddOneToPictureName(int index)
        {
            string line = GetAllEmployees[index].Headshot;
            string[] addOne = line.Split('-');
            line = addOne.ElementAt(1).Substring(0, 1);
            int i;
            i = int.Parse(line) + 1;

            return i;
        }

        private void EmployeeDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TerminationStatusComboBox.SelectedIndex = 0;
            if (selectedEmployeeList)
            {
                ApplyChangesButton.Enabled = true;

                FirstNameTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].FirstName;
                LastNameTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].LastName;
                MiddleNameTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].MiddleName;
                AgeTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Age.ToString();
                GenderComboBox.SelectedItem = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Gender;
                EmailTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].EmailAddress;
                CellphoneMaskedTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].CellphoneNumber;
                StreetNumberTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Address.StreetNumber.ToString();
                StreetNameTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Address.StreetName;

                if (GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Address.AppartmentNumber == null)
                {
                    AppartmentNumberTextBox.Text = "";
                }
                else
                {
                    AppartmentNumberTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Address.AppartmentNumber.ToString();
                }

                ZipCodeMaskedTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Address.Zipcode;
                CountryComboBox.SelectedItem = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Address.Country;

                if (GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Address.Province == "")
                {
                    ProvinceComboBox.SelectedItem = "";
                }
                else
                {
                    ProvinceComboBox.SelectedItem = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Address.Province;
                }              

                DobDateTimePicker.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Dob.ToString();
                BaseSalaryTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].BaseSalary.ToString();

                if (!GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].HasCommission)
                {
                    HasCommissionComboBox.SelectedIndex = 0;
                }
                else
                {
                    HasCommissionComboBox.SelectedIndex = 1;
                }              

                JobTitleTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].JobTitle;
                DepartmentTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Department;

                if (!GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].IsAdmin)
                {
                    IsAdminComboBox.SelectedIndex = 0;
                }
                else
                {
                    IsAdminComboBox.SelectedIndex = 1;
                }
                
                AdminUsernameTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].AdminUsername;
                AdminPasswordTextBox.Text = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].AdminPassword;

                string head = GetAllEmployees[EmployeeDataGridView.CurrentCell.RowIndex].Headshot;
                EmployeePicturePictureBox.Load(head); 
            }
        }

        private void TerminateEmpButton_Click(object sender, EventArgs e)
        {
            int index = EmployeeDataGridView.CurrentRow.Index;
            string reason = TerminationReasonComboBox.SelectedIndex.ToString();
            string details = TerminationDetailTextBox.Text;

            GlobalConfig.connections.CopyActiveEmployeeToArchievedEmployeeFile(GetAllEmployees[index], GetAllEmployees[index].Id, reason, details);
            GlobalConfig.connections.DeleteEmployee(GetAllEmployees[index], index);

            EmployeeDataGridView.DataSource = null;
            EmployeeDataGridView.Rows.Clear();

            GetAllEmployees = GlobalConfig.connections.GetAllEmployees();
            EmployeeDataGridView.DataSource = GetAllEmployees;
            AdjustColumnOrderForEmployeeFile();

            Reset();
            EmployeeDataGridView.ClearSelection();
        }

        private void ActiveEmpListButton_Click(object sender, EventArgs e)
        {
            EditControlsState(true);
            PlaceholderEnabler();

            selectedEmployeeList = true;
            TerminationStatusComboBox.Enabled = true;
            GetAllEmployees = GlobalConfig.connections.GetAllEmployees();
            EmployeeDataGridView.DataSource = GetAllEmployees;
            AdjustColumnOrderForEmployeeFile();
        }

        private void InactiveEmpListButton_Click(object sender, EventArgs e)
        {
            Reset();
            EditControlsState(false);
            PlaceholderDisabler();

            TerminationStatusComboBox.SelectedIndex = 0;
            TerminationStatusComboBox.Enabled = false;
            TerminationGroupState(false, "");
            selectedEmployeeList = false;
            ApplyChangesButton.Enabled = false;

            GetAllArchievedEmployees = GlobalConfig.connections.GetAllArchievedEmployees();
            EmployeeDataGridView.DataSource = GetAllArchievedEmployees;
            AdjustColumnOrderForEmployeeFile();
            EmployeeDataGridView.Columns["TerminationDate"].Visible = true;
            EmployeeDataGridView.Columns["ReasonForTermination"].Visible = true;
            EmployeeDataGridView.Columns["TerminationDetails"].Visible = true;
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {            
            ApplyChangesButton.Enabled = false;
            TerminationStatusComboBox.Enabled = false;
            TerminationGroupState(false, "");

            LoginLabel.Text = LoginInfo.CurrentUserName;
            CountryComboBox.DataSource = CountryList();
            TerminationStatusComboBox.DataSource = Enum.GetValues(typeof(Selection)).Cast<Selection>();
            TerminationReasonComboBox.DataSource = Enum.GetValues(typeof(TerminationReason)).Cast<TerminationReason>();
            GenderComboBox.DataSource = Enum.GetValues(typeof(Gender)).Cast<Gender>();
            HasCommissionComboBox.DataSource = Enum.GetValues(typeof(Selection)).Cast<Selection>();
            IsAdminComboBox.DataSource = Enum.GetValues(typeof(Selection)).Cast<Selection>();
            Reset();
        }

        private void TerminationStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TerminationStatusComboBox.SelectedIndex == 1)
            {
                TerminationGroupState(true, "Termination details...");
                Reset();
                EditControlsState(false);
                PlaceholderDisabler();
            }
            else
            {
                TerminationGroupState(false, "");
                EditControlsState(true);
                PlaceholderEnabler();
            }
        }

        private void PlaceholderEnabler()
        {
            FirstNameTextBox.PlaceholderText = "Your name...";
            LastNameTextBox.PlaceholderText = "Your name...";
            MiddleNameTextBox.PlaceholderText = "Your name...";
            StreetNumberTextBox.PlaceholderText = "Your street #...";
            StreetNameTextBox.PlaceholderText = "Your street name...";
            AppartmentNumberTextBox.PlaceholderText = "Your app #...";
            JobTitleTextBox.PlaceholderText = "Job title...";
            DepartmentTextBox.PlaceholderText = "Department...";
            EmailTextBox.PlaceholderText = "Your email...";
            BaseSalaryTextBox.PlaceholderText = "Your salary...";
            AgeTextBox.PlaceholderText = "Your age...";
        }

        private void PlaceholderDisabler()
        {
            FirstNameTextBox.PlaceholderText = "";
            LastNameTextBox.PlaceholderText = "";
            MiddleNameTextBox.PlaceholderText = "";
            StreetNumberTextBox.PlaceholderText = "";
            StreetNameTextBox.PlaceholderText = "";
            AppartmentNumberTextBox.PlaceholderText = "";
            JobTitleTextBox.PlaceholderText = "";
            DepartmentTextBox.PlaceholderText = "";
            EmailTextBox.PlaceholderText = "";
            BaseSalaryTextBox.PlaceholderText = "";
            AgeTextBox.PlaceholderText = "";
        }

        private void EditControlsState(bool state)
        {
            PersonGroupBox.Enabled = state;
            AddressGroupBox.Enabled = state;
            JobInfoGroupBox.Enabled = state;
            ApplyChangesButton.Enabled = state;
            ResetFormButton.Enabled = state;
            ChangePictureButton.Enabled = state;
        }

        private void TerminationGroupState(bool state, string txtValue)
        {
            TerminationReasonComboBox.Enabled = state;
            TerminateEmpButton.Enabled = state;
            TerminationDetailTextBox.Enabled = state;          
            TerminationDetailTextBox.PlaceholderText = txtValue;
        }

        private void CountryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CountryComboBox.Text == "Canada")
            {
                ProvinceComboBox.Enabled = true;
                ProvinceComboBox.DataSource = provinces.ToArray();
            }
            else
            {
                ProvinceComboBox.Enabled = false;
                ProvinceComboBox.DataSource = null;
            }
        }

        private void HasCommissionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (HasCommissionComboBox.Text == "Yes")
            {
                CommissionAmountTextBox.Enabled = true;
                CommissionAmountTextBox.PlaceholderText = "Enter commission amount...";
            }
            else
            {
                CommissionAmountTextBox.Enabled = false;
                CommissionAmountTextBox.PlaceholderText = "";
            }
        }

        private void OrderByIdButton_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeList)
            {
                GetAllEmployees = GlobalConfig.connections.GetAllEmployees().OrderBy(o => o.Id).ToList();
                EmployeeDataGridView.DataSource = GetAllEmployees;
            }
            else
            {
                GetAllArchievedEmployees = GlobalConfig.connections.GetAllArchievedEmployees().OrderBy(o => o.Id).ToList();
                EmployeeDataGridView.DataSource = GetAllArchievedEmployees;
            }
        }

        private void OrderByLastNameButton_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeList)
            {
                GetAllEmployees = GlobalConfig.connections.GetAllEmployees().OrderBy(o => o.LastName).ToList();
                EmployeeDataGridView.DataSource = GetAllEmployees;
            }
            else
            {
                GetAllArchievedEmployees = GlobalConfig.connections.GetAllArchievedEmployees().OrderBy(o => o.LastName).ToList();
                EmployeeDataGridView.DataSource = GetAllArchievedEmployees;
            }
        }

        private void OrderByEmailButton_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeList)
            {
                GetAllEmployees = GlobalConfig.connections.GetAllEmployees().OrderBy(o => o.EmailAddress).ToList();
                EmployeeDataGridView.DataSource = GetAllEmployees;
            }
            else
            {
                GetAllArchievedEmployees = GlobalConfig.connections.GetAllArchievedEmployees().OrderBy(o => o.EmailAddress).ToList();
                EmployeeDataGridView.DataSource = GetAllArchievedEmployees;
            }
        }

        private void OrderByDepartmentButton_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeList)
            {
                GetAllEmployees = GlobalConfig.connections.GetAllEmployees().OrderBy(o => o.Department).ToList();
                EmployeeDataGridView.DataSource = GetAllEmployees;
            }
            else
            {
                GetAllArchievedEmployees = GlobalConfig.connections.GetAllArchievedEmployees().OrderBy(o => o.Department).ToList();
                EmployeeDataGridView.DataSource = GetAllArchievedEmployees;
            }
        }

        private void OrderBySalaryButton_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeList)
            {
                GetAllEmployees = GlobalConfig.connections.GetAllEmployees().OrderBy(o => o.BaseSalary).ToList();
                EmployeeDataGridView.DataSource = GetAllEmployees;
            }
            else
            {
                GetAllArchievedEmployees = GlobalConfig.connections.GetAllArchievedEmployees().OrderBy(o => o.BaseSalary).ToList();
                EmployeeDataGridView.DataSource = GetAllArchievedEmployees;
            }
        }

        private void OrderByCountryButton_Click(object sender, EventArgs e)
        {
            if (selectedEmployeeList)
            {
                GetAllEmployees = GlobalConfig.connections.GetAllEmployees().OrderBy(o => o.Country).ToList();
                EmployeeDataGridView.DataSource = GetAllEmployees;
            }
            else
            {
                GetAllArchievedEmployees = GlobalConfig.connections.GetAllArchievedEmployees().OrderBy(o => o.Country).ToList();
                EmployeeDataGridView.DataSource = GetAllArchievedEmployees;
            }
        }

        private void ChangePictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
            
            if (open.ShowDialog() == DialogResult.OK)
            {
                EmployeePicturePictureBox.Image = new Bitmap(open.FileName);
            }
        }
    }
}