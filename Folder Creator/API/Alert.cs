using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FolderCreatorApplication
{
    public static class Alert
    {
        public static DialogResult Warning(string message = "")
        {
            return MessageBox.Show(message, Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
