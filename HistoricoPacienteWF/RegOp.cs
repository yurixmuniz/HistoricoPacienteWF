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
    public partial class RegOp : Form
    {
        public Frm_Home home = Application.OpenForms["Frm_Home"] as Frm_Home;
        public Rectangle RegRec = Screen.PrimaryScreen.WorkingArea;
        public RegOp()
        {
            InitializeComponent();
            HideFields();
        }

        private void bt_funcionario_Click(object sender, EventArgs e)
        {
            bt_paciente.Visible = false;
            ShowFields();
            cbExamesExpandir.Visible = false;
            clbExames.Visible = false;
            lbExames.Visible = false;
            cbSintomasExpandir.Visible = false;
            clbSintomas.Visible = false;
            lbSintomas.Visible = false;
        }
        private void bt_paciente_Click(object sender, EventArgs e)
        {
            bt_funcionario.Visible = false;
            bt_paciente.Location = new Point(41, 12);
            ShowFields();
            lb_funcao.Visible = false;
            txt_funcao.Visible = false;
            cbExamesExpandir.Visible = true;
            clbExames.Visible = true;
            lbExames.Visible = true;
            cbSintomasExpandir.Visible = true;
            clbSintomas.Visible = true;
            lbSintomas.Visible = true;
            lb_registro_sus.Visible = true;
            txt_registro_sus.Visible = true;
            cbTipoSang.Visible = true;
            lbTipoSang.Visible = true;
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {

            SqlConnection connection = Connection.ObterConexao();
            SqlCommand command = new SqlCommand();
            DataTable tableFunc = new DataTable(), tablePac = new DataTable(), tableSin = new DataTable(), tableEx = new DataTable();
            SqlDataAdapter adapterFunc = new SqlDataAdapter(), adapterPac = new SqlDataAdapter(), adapterSin = new SqlDataAdapter(), adapterEx = new SqlDataAdapter();
            string strSql = "";
            command.Connection = connection;


            try
            {

                if (bt_paciente.Visible == false)
                {
                    strSql = $"insert into tbl_funcionarios (nome_funcionario, login_funcionario, senha_funcionario, funcao, data_nascimento) values ('{txt_nome.Text}', '{txt_login.Text}', '{txt_senha.Text}', '{txt_funcao.Text}', '{dt_nascimento.Value.Date}')";
                    command = new SqlCommand(strSql, connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    strSql = $"insert into tbl_pacientes (nome_paciente, login_paciente, senha_paciente, registro_sus, tipo_sanguineo, data_nascimento) values ('{txt_nome.Text}', '{txt_login.Text}', '{txt_senha.Text}', '{txt_registro_sus.Text}', '{cbTipoSang.SelectedItem}', '{dt_nascimento.Value.Date}')";
                    command = new SqlCommand(strSql, connection);
                    command.ExecuteNonQuery();
                    strSql = $"select id_paciente from tbl_pacientes";
                    command = new SqlCommand(strSql, connection);
                    adapterPac.SelectCommand = command;
                    adapterPac.Fill(tablePac);
                    foreach (string exame in clbExames.CheckedItems)
                    {
                        strSql = $"insert into tbl_exames (exame) values ('{exame}')";
                        command = new SqlCommand(strSql, connection);
                        command.ExecuteNonQuery();
                    }

                    foreach (string sintoma in clbSintomas.CheckedItems)
                    {
                        strSql = $"insert into tbl_sintomas (sintoma) values ('{sintoma}')";
                        command = new SqlCommand(strSql, connection);
                        command.ExecuteNonQuery();
                  
                    }
                    strSql = $"select id_exame from tbl_exames";
                    command = new SqlCommand(strSql, connection);
                    adapterEx.SelectCommand = command;
                    adapterEx.Fill(tableEx);
                    strSql = $"insert into tbl_fichas (id_paciente, id_exame) values ('{tablePac.Rows[0].ItemArray[0]}', '{tableEx.Rows[0].ItemArray[0]}')";
                    command = new SqlCommand(strSql, connection);
                    command.ExecuteNonQuery();
                    strSql = $"select id_sintoma from tbl_sintomas";
                    command = new SqlCommand(strSql, connection);
                    adapterSin.SelectCommand = command;
                    adapterSin.Fill(tableSin);
                    strSql = $"insert into tbl_fichas (id_paciente, id_sintoma) values ('{tablePac.Rows[0].ItemArray[0]}', '{tableSin.Rows[0].ItemArray[0]}')";
                    command = new SqlCommand(strSql, connection);
                    command.ExecuteNonQuery();
                }

            }
            catch (Exception err)
            {

                MessageBox.Show(err.ToString());
                Connection.FecharConexao();
            }
            finally
            {
                Connection.FecharConexao();

            }

            this.LimparTextBoxes(this.Controls);

        }
        private void LimparTextBoxes(Control.ControlCollection controles)
        {
            foreach (Control ctrl in controles)
            {
                if (ctrl is TextBox)
                {
                    ((TextBox)(ctrl)).Text = String.Empty;
                }
            }
        }
        public void HideFields()
        {
            lb_nome.Visible = false;
            lb_login.Visible = false;
            lb_senha.Visible = false;
            lb_funcao.Visible = false;
            lb_nascimentoF.Visible = false;
            btSalvar.Visible = false;
            btVoltar.Visible = false;
            txt_nome.Visible = false;
            txt_login.Visible = false;
            txt_senha.Visible = false;
            txt_funcao.Visible = false;
            dt_nascimento.Visible = false;
            cbExamesExpandir.Visible = false;
            clbExames.Visible = false;
            lbExames.Visible = false;
            cbSintomasExpandir.Visible = false;
            clbSintomas.Visible = false;
            lbSintomas.Visible = false;
            lb_registro_sus.Visible = false;
            txt_registro_sus.Visible = false;
            cbTipoSang.Visible = false;
            lbTipoSang.Visible = false;
        }
        public void ShowFields()
        {
            lb_nome.Visible = true;
            lb_login.Visible = true;
            lb_senha.Visible = true;
            lb_funcao.Visible = true;
            lb_nascimentoF.Visible = true;
            btSalvar.Visible = true;
            btVoltar.Visible = true;
            txt_nome.Visible = true;
            txt_login.Visible = true;
            txt_senha.Visible = true;
            txt_funcao.Visible = true;
            dt_nascimento.Visible = true;
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Frm_Home home = Application.OpenForms["Frm_Home"] as Frm_Home;
            home.Show();
            this.Close();
        }

        private void cbSintomasExpandir_CheckedChanged(object sender, EventArgs e)
        {

            Rectangle rectangle = new Rectangle(159, 271, 289, 19);
            if (cbSintomasExpandir.Checked)
            {
                rectangle.Height = 109;
                clbSintomas.Bounds = rectangle;
                cbSintomasExpandir.Text = "Minimizar";
                clbSintomas.BringToFront();
            }
            else
            {
                rectangle.Height = 19;
                clbSintomas.Bounds = rectangle;
                cbSintomasExpandir.Text = "Expandir";
                clbSintomas.SendToBack();
            }

        }
        private void cbExamesExpandir_CheckedChanged(object sender, EventArgs e)
        {

            Rectangle rectangle = new Rectangle(159, 310, 289, 19);
            if (cbExamesExpandir.Checked)
            {
                rectangle.Height = 109;
                clbExames.Bounds = rectangle;
                cbExamesExpandir.Text = "Minimizar";
                clbExames.BringToFront();
            }
            else
            {
                rectangle.Height = 19;
                clbExames.Bounds = rectangle;
                cbExamesExpandir.Text = "Expandir";
                clbExames.SendToBack();
            }
        }

    }
}
