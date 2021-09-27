using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultifunctionalSoftware.GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlDataReader _reader;
        private void btn_Login_Click(object sender, EventArgs e)
        {
            SqlConnection _connection = new SqlConnection("Data Source=DESKTOP-I04MOE5;Initial Catalog=MultifunctionalAppDB;Integrated Security=True;Pooling=False");

            try
            {
                _connection.Open();

            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }

            string loginCheck = String.Format("Select * From dbo.Users Where username = {0}, password = {1}", tbx_userName, tbx_password);
            SqlCommand _command = new SqlCommand(loginCheck, _connection);
            _command.ExecuteNonQuery();
            _reader = _command.ExecuteReader();
            MessageBox.Show(_reader.ToString());
        }

        private void lbl_signUp_Click(object sender, EventArgs e)
        {
            Form2 registrationForms = new Form2();
            registrationForms.Show();
            this.Hide();
        }

        private void tbx_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbx_userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }
    }
}
