using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPV
{
    public static class Clear
    {
        public static void clearForm(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox | control is ComboBox)
                {
                    control.Text = "";
                }
            }
        }
    }
}
