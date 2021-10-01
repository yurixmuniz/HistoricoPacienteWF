
namespace HistoricoPacienteWF
{
    partial class Frm_Home
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Home));
            this.pn_main = new System.Windows.Forms.Panel();
            this.checkPaciente = new System.Windows.Forms.CheckBox();
            this.checkFuncionario = new System.Windows.Forms.CheckBox();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.txt_pesquisar = new System.Windows.Forms.TextBox();
            this.dv_home = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnHome = new System.Windows.Forms.Panel();
            this.lbHomeTitle = new System.Windows.Forms.Label();
            this.pn_top = new System.Windows.Forms.Panel();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btExibir = new System.Windows.Forms.Button();
            this.btAlterar = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.pn_bot = new System.Windows.Forms.Panel();
            this.userLogin = new HistoricoPacienteWF.UserLogin();
            this.pn_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_home)).BeginInit();
            this.pn_top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_main
            // 
            this.pn_main.Controls.Add(this.checkPaciente);
            this.pn_main.Controls.Add(this.checkFuncionario);
            this.pn_main.Controls.Add(this.bt_pesquisar);
            this.pn_main.Controls.Add(this.txt_pesquisar);
            this.pn_main.Controls.Add(this.userLogin);
            this.pn_main.Controls.Add(this.dv_home);
            this.pn_main.Location = new System.Drawing.Point(0, 148);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(698, 263);
            this.pn_main.TabIndex = 11;
            // 
            // checkPaciente
            // 
            this.checkPaciente.AutoSize = true;
            this.checkPaciente.BackColor = System.Drawing.Color.Transparent;
            this.checkPaciente.Location = new System.Drawing.Point(99, 34);
            this.checkPaciente.Name = "checkPaciente";
            this.checkPaciente.Size = new System.Drawing.Size(68, 17);
            this.checkPaciente.TabIndex = 23;
            this.checkPaciente.Text = "Paciente";
            this.checkPaciente.UseVisualStyleBackColor = false;
            // 
            // checkFuncionario
            // 
            this.checkFuncionario.AutoSize = true;
            this.checkFuncionario.BackColor = System.Drawing.Color.Transparent;
            this.checkFuncionario.Location = new System.Drawing.Point(12, 34);
            this.checkFuncionario.Name = "checkFuncionario";
            this.checkFuncionario.Size = new System.Drawing.Size(81, 17);
            this.checkFuncionario.TabIndex = 23;
            this.checkFuncionario.Text = "Funcionario";
            this.checkFuncionario.UseVisualStyleBackColor = false;
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesquisar.Location = new System.Drawing.Point(226, 6);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(75, 23);
            this.bt_pesquisar.TabIndex = 22;
            this.bt_pesquisar.Text = "buscar";
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.bt_pesquisar_Click);
            // 
            // txt_pesquisar
            // 
            this.txt_pesquisar.Location = new System.Drawing.Point(3, 8);
            this.txt_pesquisar.Name = "txt_pesquisar";
            this.txt_pesquisar.Size = new System.Drawing.Size(217, 20);
            this.txt_pesquisar.TabIndex = 21;
            // 
            // dv_home
            // 
            this.dv_home.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv_home.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dv_home.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dv_home.DefaultCellStyle = dataGridViewCellStyle5;
            this.dv_home.Location = new System.Drawing.Point(0, 57);
            this.dv_home.Name = "dv_home";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv_home.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dv_home.Size = new System.Drawing.Size(698, 206);
            this.dv_home.TabIndex = 20;
            this.dv_home.Visible = false;
            this.dv_home.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dv_home_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(13, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(125, 118);
            this.panel3.TabIndex = 3;
            // 
            // pnHome
            // 
            this.pnHome.BackColor = System.Drawing.Color.Transparent;
            this.pnHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnHome.BackgroundImage")));
            this.pnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnHome.Location = new System.Drawing.Point(561, 26);
            this.pnHome.Name = "pnHome";
            this.pnHome.Size = new System.Drawing.Size(125, 118);
            this.pnHome.TabIndex = 3;
            // 
            // lbHomeTitle
            // 
            this.lbHomeTitle.AutoSize = true;
            this.lbHomeTitle.BackColor = System.Drawing.Color.Transparent;
            this.lbHomeTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbHomeTitle.Font = new System.Drawing.Font("MS PGothic", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHomeTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbHomeTitle.Location = new System.Drawing.Point(182, 90);
            this.lbHomeTitle.Name = "lbHomeTitle";
            this.lbHomeTitle.Size = new System.Drawing.Size(339, 54);
            this.lbHomeTitle.TabIndex = 4;
            this.lbHomeTitle.Text = "Cast Hospital";
            // 
            // pn_top
            // 
            this.pn_top.BackColor = System.Drawing.Color.LightGray;
            this.pn_top.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_top.Controls.Add(this.btn_minimize);
            this.pn_top.Controls.Add(this.btn_close);
            this.pn_top.Controls.Add(this.panel3);
            this.pn_top.Controls.Add(this.pnHome);
            this.pn_top.Controls.Add(this.lbHomeTitle);
            this.pn_top.Location = new System.Drawing.Point(0, 0);
            this.pn_top.Name = "pn_top";
            this.pn_top.Size = new System.Drawing.Size(698, 150);
            this.pn_top.TabIndex = 18;
            this.pn_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.pn_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.pn_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Khaki;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_minimize.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
            this.btn_minimize.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gold;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gold;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_minimize.Location = new System.Drawing.Point(645, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(21, 20);
            this.btn_minimize.TabIndex = 6;
            this.btn_minimize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.LightCoral;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.Salmon;
            this.btn_close.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Tomato;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Tomato;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_close.Location = new System.Drawing.Point(672, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(21, 20);
            this.btn_close.TabIndex = 6;
            this.btn_close.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btExibir
            // 
            this.btExibir.BackColor = System.Drawing.Color.Silver;
            this.btExibir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExibir.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btExibir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btExibir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btExibir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btExibir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExibir.Font = new System.Drawing.Font("MS PGothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExibir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btExibir.Location = new System.Drawing.Point(148, 418);
            this.btExibir.Name = "btExibir";
            this.btExibir.Size = new System.Drawing.Size(130, 38);
            this.btExibir.TabIndex = 15;
            this.btExibir.Text = "Exibir";
            this.btExibir.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btExibir.UseVisualStyleBackColor = false;
            this.btExibir.Click += new System.EventHandler(this.btExibir_Click);
            // 
            // btAlterar
            // 
            this.btAlterar.BackColor = System.Drawing.Color.Silver;
            this.btAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btAlterar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btAlterar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btAlterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btAlterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlterar.Font = new System.Drawing.Font("MS PGothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAlterar.Location = new System.Drawing.Point(284, 418);
            this.btAlterar.Name = "btAlterar";
            this.btAlterar.Size = new System.Drawing.Size(130, 38);
            this.btAlterar.TabIndex = 14;
            this.btAlterar.Text = "Alterar";
            this.btAlterar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAlterar.UseVisualStyleBackColor = false;
            // 
            // btDelete
            // 
            this.btDelete.BackColor = System.Drawing.Color.Silver;
            this.btDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btDelete.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDelete.Font = new System.Drawing.Font("MS PGothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btDelete.Location = new System.Drawing.Point(420, 418);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(130, 38);
            this.btDelete.TabIndex = 13;
            this.btDelete.Text = "Deletar";
            this.btDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btDelete.UseVisualStyleBackColor = false;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Silver;
            this.btSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSair.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("MS PGothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSair.Location = new System.Drawing.Point(556, 418);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(130, 38);
            this.btSair.TabIndex = 12;
            this.btSair.Text = "Sair";
            this.btSair.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.BackColor = System.Drawing.Color.Silver;
            this.btCadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btCadastrar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastrar.Font = new System.Drawing.Font("MS PGothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCadastrar.Location = new System.Drawing.Point(12, 418);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(130, 38);
            this.btCadastrar.TabIndex = 16;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btCadastrar.UseVisualStyleBackColor = false;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // pn_bot
            // 
            this.pn_bot.BackColor = System.Drawing.Color.LightGray;
            this.pn_bot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_bot.Location = new System.Drawing.Point(0, 408);
            this.pn_bot.Name = "pn_bot";
            this.pn_bot.Size = new System.Drawing.Size(698, 61);
            this.pn_bot.TabIndex = 17;
            // 
            // userLogin
            // 
            this.userLogin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.userLogin.Location = new System.Drawing.Point(129, 8);
            this.userLogin.Name = "userLogin";
            this.userLogin.Size = new System.Drawing.Size(434, 221);
            this.userLogin.TabIndex = 0;
            // 
            // Frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(698, 469);
            this.Controls.Add(this.pn_top);
            this.Controls.Add(this.btExibir);
            this.Controls.Add(this.btAlterar);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.pn_bot);
            this.Controls.Add(this.pn_main);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.pn_main.ResumeLayout(false);
            this.pn_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dv_home)).EndInit();
            this.pn_top.ResumeLayout(false);
            this.pn_top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pnHome;
        private System.Windows.Forms.Label lbHomeTitle;
        private System.Windows.Forms.Panel pn_top;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btExibir;
        private System.Windows.Forms.Button btAlterar;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Panel pn_bot;
        private UserLogin userLogin;
        private System.Windows.Forms.DataGridView dv_home;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.TextBox txt_pesquisar;
        private System.Windows.Forms.CheckBox checkPaciente;
        private System.Windows.Forms.CheckBox checkFuncionario;
    }
}

