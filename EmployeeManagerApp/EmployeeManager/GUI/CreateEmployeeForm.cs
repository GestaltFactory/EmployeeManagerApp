using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeClassLibrary;
using EmployeeClassLibrary.Models;

namespace EmployeeManagerUI
{
    public partial class CreateEmployeeForm : Form
    {
        private readonly String[] provinces = { "Alberta", "British Columbia", "Manitoba", "New Brunswick", "New foundland And Labrador",
                               "Northwest Territories", "Nova Scotia", "Nunavut", "Ontario", "Prince Edward Island",
                               "Quebec", "Saskatchewan", "Yukon" };

        private int count;

        public CreateEmployeeForm()
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

        private void CreateEmployeeForm_Load(object sender, EventArgs e)
        {
            LoginLabel.Text = LoginInfo.CurrentUserName;
            CountryComboBox.DataSource = CountryList();
            GenderComboBox.DataSource = Enum.GetValues(typeof(Gender)).Cast<Gender>();
            HasCommissionComboBox.DataSource = Enum.GetValues(typeof(Selection)).Cast<Selection>();
            IsAdminComboBox.DataSource = Enum.GetValues(typeof(Selection)).Cast<Selection>();
            Reset();
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

        private void ResetFormButton_Click(object sender, EventArgs e)
        {
            Reset();
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
            AdminPasswordTextBox.Text = "";

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
            HeadshotErrorLabel.Text = "";
            MasterErrorLabel.Text = "";
            EmployeePicturePictureBox.Image = null;

            FirstNameTextBox.Focus();
        }

        private void CreateEmployeeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Employee emp = new Employee();
                emp.FirstName = FirstNameTextBox.Text;
                emp.LastName = LastNameTextBox.Text;
                emp.MiddleName = MiddleNameTextBox.Text;
                emp.Age = int.Parse(AgeTextBox.Text);
                emp.Gender = (Gender)Enum.Parse(typeof(Gender), GenderComboBox.SelectedItem.ToString());
                emp.EmailAddress = EmailTextBox.Text;
                emp.CellphoneNumber = CellphoneMaskedTextBox.Text;
                emp.Address.StreetNumber = int.Parse(StreetNumberTextBox.Text);
                emp.Address.StreetName = StreetNameTextBox.Text;

                if (AppartmentNumberTextBox.Text == "")
                {
                    emp.Address.AppartmentNumber = null;
                }
                else
                {
                    emp.Address.AppartmentNumber = int.Parse(AppartmentNumberTextBox.Text);
                }

                emp.Address.Zipcode = ZipCodeMaskedTextBox.Text;
                emp.Address.Country = CountryComboBox.SelectedItem.ToString();

                if (!ProvinceComboBox.Enabled)
                {
                    emp.Address.Province = "";
                }
                else
                {
                    emp.Address.Province = ProvinceComboBox.SelectedItem.ToString();
                }

                emp.Dob = DateTime.Parse(DobDateTimePicker.Text);
                emp.BaseSalary = decimal.Parse(BaseSalaryTextBox.Text);

                if (HasCommissionComboBox.SelectedIndex == 0)
                {
                    emp.HasCommission = false;
                    emp.Commission = 0;
                }
                else
                {
                    emp.HasCommission = true;
                    emp.Commission = decimal.Parse(CommissionAmountTextBox.Text);
                }

                emp.JobTitle = JobTitleTextBox.Text;
                emp.Department = DepartmentTextBox.Text;
                emp.Doh = DateTime.Now;

                if (IsAdminComboBox.SelectedIndex == 0)
                {
                    emp.IsAdmin = false;
                }
                else
                {
                    emp.IsAdmin = true;
                }

                emp.AdminUsername = AdminUsernameTextBox.Text;
                emp.AdminPassword = AdminPasswordTextBox.Text;

                emp.IsActive = true;
                emp.TerminationDate = DateTime.Now;

                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;)|*.jpg; *.jpeg; *.gif; *.bmp;";
                EmployeePicturePictureBox.Image.Save($"../../../assets/EmployeePictures/{LastNameTextBox.Text}_{FirstNameTextBox.Text}-1.jpg");
                emp.Headshot = $"../../../assets/EmployeePictures/{LastNameTextBox.Text}_{FirstNameTextBox.Text}-1.jpg";

                emp = GlobalConfig.connections.CreateEmployee(emp);

                Reset();
            }
            else
            {
                MasterErrorLabel.Text = "* Please Fix all <" + count + "> errors to proceed!";
            }
        }

        private void DobDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            AgeTextBox.Text = CalculateAge().ToString();
        }

        private int CalculateAge()
        {
            int age = DateTime.Now.Year - DobDateTimePicker.Value.Year;
            if (DateTime.Now.Year < DobDateTimePicker.Value.Month || (DateTime.Now.Month == DobDateTimePicker.Value.Month && DateTime.Now.Day < DobDateTimePicker.Value.Day))
            {
                age--;
            }

            return age;
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
            count += EmployeeValidation.HeadshotPictureBoxValidation(EmployeePicturePictureBox, HeadshotErrorLabel);

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

        private void BackButton_Click(object sender, EventArgs e)
        {
            Hide();
            var empManagement = new EmployeeManagementForm();
            empManagement.Closed += (s, args) => Close();
            empManagement.Show();
        }

        private void SelectPictureButton_Click(object sender, EventArgs e)
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