using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultifunctionalSoftware.GUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            //lbl_dateofbirthHint.Visible = false;
        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {
            string command = String.Format("insert into dbo.Users values('{0}','{1}','{2}','{3}','{4}')",tbx_userName,tbx_firstname,tbx_lastname,tbx_dateofBirth,tbx_password);
        }

        private void tbx_dateofBirth_Click(object sender, EventArgs e)
        {
            lbl_dateofbirthHint.Visible = true;
        }
    }
}
