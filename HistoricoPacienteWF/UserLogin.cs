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

namespace HistoricoPacienteWF
{
    public partial class UserLogin : UserControl
    {
        public UserLogin()
        {
            InitializeComponent();
            txt_user.Focus();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection.ObterConexao();
            SqlCommand command = new SqlCommand();
            SqlDataReader reader;


            if (txt_user.Text == "" || txt_pw.Text == "")
            {
                MessageBox.Show("Há campos vazios.");
                txt_user.Focus();
            }
            else
            {
               
                try
                {
                    command.Connection = connection;

                    if (cb_user.Checked == true)
                    {
                        command.CommandText = $"select * from tbl_funcionarios where login_funcionario = '{txt_user.Text}' and senha_funcionario = '{txt_pw.Text}'";
                    }
                    else
                    {
                        command.CommandText = $"select * from tbl_pacientes where login_paciente = '{txt_user.Text}' and senha_paciente = '{txt_pw.Text}'";
                    }
             
                    reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        this.Hide();
                        Frm_Home home = Application.OpenForms["Frm_Home"] as Frm_Home;
                        home.ShowButtons();
                    }
                    else
                    {
                        MessageBox.Show("Login ou senha invalidos.");
                        Connection.FecharConexao();
                        return;
                    }
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    Connection.FecharConexao();
                    txt_user.Clear();
                    txt_pw.Clear();
                }

            }
           
        }

        private void cb_user_VisibleChanged(object sender, EventArgs e)
        {
            txt_user.Focus();
            if(cb_user.Visible == true)
            {
                cb_user.Checked = false;
            }
        }
    }
}
