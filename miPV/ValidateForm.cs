using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPV
{
    static class ValidateForm
    {
        public static bool empty(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox & control.Text == String.Empty | control is ComboBox & control.Text == String.Empty)
                {
                    Mensaje.getMessage(messageResponse.fieldsRequired.ToString());
                    return true;
                }
            }
            return false;
        }
    }
}
