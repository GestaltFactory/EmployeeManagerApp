using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagerUI
{
    static class EmployeeValidation
    {
        static public int FirstNameValidation(TextBox box, Label error)
        {
            int check = 0;

            if (box.Text.Length == 0)
            {
                error.Text = "* This field is mandatory!";
                check = 1;
            }
            else if (!box.Text.All(char.IsLetter))
            {
                error.Text = "* Invalid Character! Only letters are accepted.";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int LastNameValidation(TextBox box, Label error)
        {
            int check = 0;

            if (box.Text.Length == 0)
            {
                error.Text = "* This field is mandatory!";
                check = 1;
            }
            else if (!box.Text.All(char.IsLetter))
            {
                error.Text = "* Invalid Character! Only letters are accepted.";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int MiddleNameValidation(TextBox box, Label error)
        {
            int check = 0;

            if (!box.Text.All(char.IsLetter))
            {
                error.Text = "* Invalid Character! Only letters are accepted.";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int CellphoneValidation(MaskedTextBox maskedBox, Label error)
        {
            int check = 0;

            if (!maskedBox.MaskFull)
            {
                error.Text = "* please enter all numbers!";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int EmailValidation(TextBox box, Label error)
        {
            string emailRegex = "^[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}$";
            int check = 0;

            if (box.Text.Length == 0)
            {
                error.Text = "* This field is mandatory!";
            }
            else if (!Regex.IsMatch(box.Text, emailRegex))
            {
                error.Text = "* Invalid Format";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int AgeValidation(TextBox box, Label error)
        {
            int check = 0;
            int num;

            num = int.Parse(box.Text);

            if (num < 18 || num > 65)
            {
                error.Text = "* Age entered is invalid!";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int StreetNumberValidation(TextBox box, Label error)
        {
            int check = 0;
            int num;

            if (box.Text.Length == 0)
            {
                error.Text = "* This field is mandatory!";
                check = 1;
            }
            else if (!box.Text.All(char.IsDigit))
            {
                error.Text = "* Invalid Character! Only digits are accepted.";
                check = 1;
            }
            else if (box.Text.All(char.IsDigit))
            {
                num = int.Parse(box.Text);

                if (num < 4)
                {
                    error.Text = "* Street number entered is invalid!";
                    check = 1;
                }
                else
                {
                    error.Text = "";
                    check = 0;
                }
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int StreetNameValidation(TextBox box, Label error)
        {
            int check = 0;

            if (box.Text.Length == 0)
            {
                error.Text = "* This field is mandatory!";
                check = 1;
            }
            else if (!box.Text.All(char.IsLetter))
            {
                error.Text = "* Invalid Character! Only letters are accepted.";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int AppartmentValidation(TextBox box, Label error)
        {
            int check = 0;
            int num;

            if (box.Text != "")
            {
                if (!box.Text.All(char.IsDigit))
                {
                    error.Text = "* Invalid Character! Only digits are accepted.";
                    check = 1;
                }
                else if (box.Text.All(char.IsDigit))
                {
                    num = int.Parse(box.Text);

                    if (num < 1)
                    {
                        error.Text = "* Appartment number entered is invalid!";
                        check = 1;
                    }
                    else
                    {
                        error.Text = "";
                        check = 0;
                    }
                }
                else
                {
                    error.Text = "";
                    check = 0;
                }
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int ZipCodeValidation(MaskedTextBox maskedBox, Label error)
        {
            int check = 0;

            if (!maskedBox.MaskFull)
            {
                error.Text = "* Enter all characters!";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int JobTitleValidation(TextBox box, Label error)
        {
            int check = 0;

            if (box.Text.Length == 0)
            {
                error.Text = "* This field is mandatory!";
                check = 1;
            }
            else if (!box.Text.All(char.IsLetter))
            {
                error.Text = "* Invalid Character! Only letters are accepted.";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int DepartmentValidation(TextBox box, Label error)
        {
            int check = 0;

            if (box.Text.Length == 0)
            {
                error.Text = "* This field is mandatory!";
                check = 1;
            }
            else if (!box.Text.All(char.IsLetter))
            {
                error.Text = "* Invalid Character! Only letters are accepted.";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int CommissionAmountValidation(TextBox box, Label error)
        {
            string regexNumberDecimal = "^[0-9]+$";
            int check = 0;

            if (box.Text.Length == 0)
            {
                error.Text = "* This field is mandatory!";
                check = 1;
            }
            else if (!Regex.IsMatch(box.Text, regexNumberDecimal))
            {
                error.Text = "*  Invalid Character! Whole number only!";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int BaseSalaryValidation(TextBox box, Label error)
        {
            string regexNumberDecimal = "^[0-9]+$";
            int check = 0;

            if (box.Text.Length == 0)
            {
                error.Text = "* This field is mandatory!";
                check = 1;
            }
            else if (!Regex.IsMatch(box.Text, regexNumberDecimal))
            {
                error.Text = "*  Invalid Character! Whole number only!";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int AdminUsernameValidation(TextBox box, Label error)
        {
            int check = 0;

            if (box.Text.Length == 0)
            {
                error.Text = "* This field is mandatory for all admins!";
                check = 1;
            }
            else if (box.Text.Length < 3)
            {
                error.Text = "* You need at least 3 characters for you username!";
                check = 1;
            }
            else if (box.Text.Any(char.IsWhiteSpace))
            {
                error.Text = "* Invalid Character! Only letters are accepted.";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int AdminPasswordValidation(TextBox box, Label error)
        {
            var passwordRegexNumber = new Regex(@"[0-9]+");
            var passwordRegexLowercase = new Regex(@"[a-z]+");
            var passwordRegexUppercase = new Regex(@"[A-Z]+");
            var passwordRegexSpecialChar = new Regex(@"[!@%$#?&*()_+=|;,';:`+.\[{\]}-]+");

            int check = 0;

            if (box.Text.Length == 0)
            {
                error.Text = "* This field is mandatory!";
                check = 1;
            }
            else if (!passwordRegexNumber.IsMatch(box.Text))
            {
                error.Text = "* Password must contain at least one number!";
                check = 1;
            }
            else if (!passwordRegexLowercase.IsMatch(box.Text))
            {
                error.Text = "* Password must contain at least one lowercase letter!";
                check = 1;
            }
            else if (!passwordRegexUppercase.IsMatch(box.Text))
            {
                error.Text = "* Password must contain at least one uppercase letter!";
                check = 1;
            }
            else if (!passwordRegexSpecialChar.IsMatch(box.Text))
            {
                error.Text = "* Password must contain at least one special character!";
                check = 1;
            }
            else if (box.Text.Length < 8)
            {
                error.Text = "* You need at least 8 characters for you password!";
                check = 1;
            }
            else if (box.Text.Any(char.IsWhiteSpace))
            {
                error.Text = "* Invalid format! Whitespace not accepted.";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int HeadshotPictureBoxValidation(PictureBox box, Label error)
        {
            int check = 0;

            if (box.Image == null)
            {
                error.Text = "* You need to upload an image!";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }
    }
}