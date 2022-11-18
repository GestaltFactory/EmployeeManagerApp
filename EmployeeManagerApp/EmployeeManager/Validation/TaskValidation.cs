using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagerUI
{
    static class TaskValidation
    {
        static public int TaskNameValidation(TextBox box, Label error)
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

        static public int TaskDescriptionValidation(TextBox box, Label error)
        {
            int check = 0;

            if (box.Text.Length == 0)
            {
                error.Text = "* This field is mandatory!";
                check = 1;
            }
            else
            {
                error.Text = "";
                check = 0;
            }

            return check;
        }

        static public int TaskDeadlineValidation(DateTimePicker dtp, Label error)
        {
            int check = 0;

            if (dtp.Value < DateTime.Now)
            {
                error.Text = "A deadline cannot be in the past";
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