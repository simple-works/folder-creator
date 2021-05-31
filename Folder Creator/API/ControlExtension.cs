using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FolderCreatorApplication
{
    public static class ControlExtension
    {
        public static void FocusAndSelectAll(this Control control)
        {
            control.Focus();
            if (control is TextBox)
            {
                (control as TextBox).SelectAll();
            }
            else if (control is NumericUpDown)
            {
                NumericUpDown numericUpDown = control as NumericUpDown;
                numericUpDown.Select(0, numericUpDown.Value.ToString().Length);
            }
            else
            {
                control.Select();
            }
        }
    }
}
