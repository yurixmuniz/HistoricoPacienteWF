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
    public partial class Frm_Home : Form
    {
        public bool drag = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private UserLogin user;
        public Frm_Home()
        {
            InitializeComponent();
            pn_main.Controls.Add(userLogin);

            HideButtons();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {
        }
        public void HideButtons()
        {
            btAlterar.Visible = false;
            btCadastrar.Visible = false;
            btDelete.Visible = false;
            btExibir.Visible = false;
            btSair.Visible = false;
            bt_pesquisar.Visible = false;
            txt_pesquisar.Visible = false;
            checkFuncionario.Visible = false;
            checkPaciente.Visible = false;
        }
        public void ShowButtons()
        {
            btAlterar.Visible = true;
            btCadastrar.Visible = true;
            btDelete.Visible = true;
            btExibir.Visible = true;
            btSair.Visible = true;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            userLogin.Visible = true;
            HideButtons();
            Connection.FecharConexao();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            user = this.userLogin;

            if (user.cb_user.Checked == true)
            {
                this.Hide();
                RegOp option = new RegOp();
                option.Show();
            }
            else
            {
                MessageBox.Show("PACIENTE");
            }
        }

        private void btExibir_Click(object sender, EventArgs e)
        {
            if (dv_home.Visible != true)
            {
                dv_home.Visible = true;
                bt_pesquisar.Visible = true;
                bt_pesquisar.BringToFront();
                txt_pesquisar.Visible = true;
                txt_pesquisar.BringToFront();
                checkFuncionario.Visible = true;
                checkFuncionario.BringToFront();
                checkPaciente.Visible = true;
                checkPaciente.BringToFront();
            }
            else
            {
                dv_home.Visible = false;
                bt_pesquisar.Visible = false;
                bt_pesquisar.SendToBack();
                txt_pesquisar.Visible = false;
                txt_pesquisar.SendToBack();
                checkFuncionario.Visible = false;
                checkFuncionario.SendToBack();
                checkPaciente.Visible = false;
                checkPaciente.SendToBack();
            }
        }
        private void bt_pesquisar_Click(object sender, EventArgs e)
        {
            SqlConnection connection = Connection.ObterConexao();
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            if (checkFuncionario.Checked == true)
            {
                if (txt_pesquisar.Text != "")
                {
                    try
                    {
                        command.CommandText = $"Select nome_funcionario, data_nascimento, funcao from tbl_funcionarios where nome_funcionario like '%{txt_pesquisar.Text}%' or login_funcionario like '%{txt_pesquisar.Text}%'";


                        SqlDataAdapter adapter = new SqlDataAdapter();

                        DataTable table = new DataTable();

                        adapter.SelectCommand = command;
                        adapter.Fill(table);

                        dv_home.DataSource = table;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("\n" + erro);
                        connection.Close();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else if (txt_pesquisar.Text == "")
                {
                    Seleciona();
                }
                else
                {
                    dv_home.DataSource = null;
                    connection.Close();
                }
            }
            else
            {
                if (txt_pesquisar.Text != "")
                {
                    try
                    {
                        command.CommandText = $" SELECT tbl_fichas.id_paciente, nome_paciente, data_nascimento, registro_sus, tipo_sanguineo, tbl_sintomas.sintoma, tbl_exames.exame FROM tbl_pacientes Left JOIN tbl_fichas ON tbl_pacientes.id_paciente = tbl_fichas.id_paciente left JOIN tbl_sintomas ON tbl_sintomas.id_sintoma = tbl_fichas.id_sintoma left JOIN tbl_exames ON tbl_exames.id_exame = tbl_fichas.id_exame where nome_paciente like '%{txt_pesquisar.Text}%' or login_paciente like '%{txt_pesquisar.Text}%'";

                        SqlDataAdapter adapter = new SqlDataAdapter();

                        DataTable table = new DataTable();

                        adapter.SelectCommand = command;
                        adapter.Fill(table);

                        dv_home.DataSource = table;
                    }
                    catch (Exception erro)
                    {
                        MessageBox.Show("\n" + erro);
                        connection.Close();
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else if (txt_pesquisar.Text == "")
                {
                    Seleciona();
                }
                else
                {
                    dv_home.DataSource = null;
                    connection.Close();
                }
            }


        }
        private void Seleciona()
        {
            SqlConnection connection = Connection.ObterConexao();
            SqlCommand command = new SqlCommand();

            command.Connection = connection;

            command.CommandText = "Select * from tbl_funcionarios";

            SqlDataAdapter adapter = new SqlDataAdapter();

            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            dv_home.DataSource = table;
            connection.Close();
        }

        private void dv_home_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dv_home.CurrentRow.Selected = true;
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int cod = dv_home.CurrentRow.Index;
            SqlConnection connection = Connection.ObterConexao();
            SqlCommand objComandoSql = new SqlCommand();

            objComandoSql.Connection = connection;
            if(checkFuncionario.Checked == true)
            {
                try
                {

                    string strSql = $"delete from tbl_funcionarios where id_funcionario = '{cod}'";

                    objComandoSql = new SqlCommand(strSql, connection);
                    //conn.Open();
                    objComandoSql.ExecuteNonQuery();

                    LimparTextBoxes(this.Controls);

                }
                catch (Exception erro)
                {
                    MessageBox.Show("" + erro);
                    Connection.FecharConexao();
                }
                finally
                {
                    Connection.FecharConexao();
                }
            }
            else
            {
                try
                {

                    string strSql = $"delete from tbl_pacientes where id_paciente = '{cod}'";

                    objComandoSql = new SqlCommand(strSql, connection);
                    //conn.Open();
                    objComandoSql.ExecuteNonQuery();

                    LimparTextBoxes(this.Controls);

                }
                catch (Exception erro)
                {
                    MessageBox.Show("" + erro);
                    Connection.FecharConexao();
                }
                finally
                {
                    Connection.FecharConexao();
                }
            }
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

    }
}

