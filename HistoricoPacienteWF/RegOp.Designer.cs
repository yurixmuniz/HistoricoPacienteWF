
namespace HistoricoPacienteWF
{
    partial class RegOp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_funcionario = new System.Windows.Forms.Button();
            this.bt_paciente = new System.Windows.Forms.Button();
            this.pn_options = new System.Windows.Forms.Panel();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_login = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.lb_nascimentoF = new System.Windows.Forms.Label();
            this.lb_funcao = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_senha = new System.Windows.Forms.TextBox();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.txt_funcao = new System.Windows.Forms.TextBox();
            this.dt_nascimento = new System.Windows.Forms.DateTimePicker();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.txt_registro_sus = new System.Windows.Forms.TextBox();
            this.lb_registro_sus = new System.Windows.Forms.Label();
            this.cbExamesExpandir = new System.Windows.Forms.CheckBox();
            this.cbSintomasExpandir = new System.Windows.Forms.CheckBox();
            this.clbExames = new System.Windows.Forms.CheckedListBox();
            this.clbSintomas = new System.Windows.Forms.CheckedListBox();
            this.lbExames = new System.Windows.Forms.Label();
            this.lbSintomas = new System.Windows.Forms.Label();
            this.cbTipoSang = new System.Windows.Forms.ComboBox();
            this.lbTipoSang = new System.Windows.Forms.Label();
            this.funcControl1 = new HistoricoPacienteWF.FuncControl();
            this.pn_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_funcionario
            // 
            this.bt_funcionario.AutoSize = true;
            this.bt_funcionario.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_funcionario.Location = new System.Drawing.Point(20, 12);
            this.bt_funcionario.Name = "bt_funcionario";
            this.bt_funcionario.Size = new System.Drawing.Size(170, 39);
            this.bt_funcionario.TabIndex = 0;
            this.bt_funcionario.Text = "Funcionario";
            this.bt_funcionario.UseVisualStyleBackColor = true;
            this.bt_funcionario.Click += new System.EventHandler(this.bt_funcionario_Click);
            // 
            // bt_paciente
            // 
            this.bt_paciente.AutoSize = true;
            this.bt_paciente.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_paciente.Location = new System.Drawing.Point(41, 66);
            this.bt_paciente.Name = "bt_paciente";
            this.bt_paciente.Size = new System.Drawing.Size(131, 39);
            this.bt_paciente.TabIndex = 0;
            this.bt_paciente.Text = "Paciente";
            this.bt_paciente.UseVisualStyleBackColor = true;
            this.bt_paciente.Click += new System.EventHandler(this.bt_paciente_Click);
            // 
            // pn_options
            // 
            this.pn_options.Controls.Add(this.bt_funcionario);
            this.pn_options.Controls.Add(this.bt_paciente);
            this.pn_options.Location = new System.Drawing.Point(244, 12);
            this.pn_options.Name = "pn_options";
            this.pn_options.Size = new System.Drawing.Size(212, 117);
            this.pn_options.TabIndex = 3;
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(94, 167);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(81, 27);
            this.lb_nome.TabIndex = 5;
            this.lb_nome.Text = "Nome";
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.Location = new System.Drawing.Point(97, 207);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(78, 27);
            this.lb_login.TabIndex = 5;
            this.lb_login.Text = "Login";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(87, 247);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(88, 27);
            this.lb_senha.TabIndex = 5;
            this.lb_senha.Text = "Senha";
            // 
            // lb_nascimentoF
            // 
            this.lb_nascimentoF.AutoSize = true;
            this.lb_nascimentoF.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nascimentoF.Location = new System.Drawing.Point(20, 327);
            this.lb_nascimentoF.Name = "lb_nascimentoF";
            this.lb_nascimentoF.Size = new System.Drawing.Size(155, 27);
            this.lb_nascimentoF.TabIndex = 5;
            this.lb_nascimentoF.Text = "Nascimento";
            // 
            // lb_funcao
            // 
            this.lb_funcao.AutoSize = true;
            this.lb_funcao.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_funcao.Location = new System.Drawing.Point(73, 287);
            this.lb_funcao.Name = "lb_funcao";
            this.lb_funcao.Size = new System.Drawing.Size(102, 27);
            this.lb_funcao.TabIndex = 5;
            this.lb_funcao.Text = "Função";
            // 
            // txt_nome
            // 
            this.txt_nome.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(201, 160);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(287, 34);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_senha
            // 
            this.txt_senha.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_senha.Location = new System.Drawing.Point(201, 242);
            this.txt_senha.Name = "txt_senha";
            this.txt_senha.Size = new System.Drawing.Size(287, 34);
            this.txt_senha.TabIndex = 6;
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_login.Location = new System.Drawing.Point(201, 201);
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(287, 34);
            this.txt_login.TabIndex = 6;
            // 
            // txt_funcao
            // 
            this.txt_funcao.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_funcao.Location = new System.Drawing.Point(201, 282);
            this.txt_funcao.Name = "txt_funcao";
            this.txt_funcao.Size = new System.Drawing.Size(287, 34);
            this.txt_funcao.TabIndex = 6;
            // 
            // dt_nascimento
            // 
            this.dt_nascimento.CalendarFont = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_nascimento.Location = new System.Drawing.Point(201, 334);
            this.dt_nascimento.Name = "dt_nascimento";
            this.dt_nascimento.Size = new System.Drawing.Size(186, 20);
            this.dt_nascimento.TabIndex = 7;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Silver;
            this.btVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btVoltar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btVoltar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btVoltar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btVoltar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("MS PGothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btVoltar.Location = new System.Drawing.Point(386, 503);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(102, 38);
            this.btVoltar.TabIndex = 17;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Silver;
            this.btSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btSalvar.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btSalvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.btSalvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("MS PGothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalvar.Location = new System.Drawing.Point(201, 503);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(102, 38);
            this.btSalvar.TabIndex = 17;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txt_registro_sus
            // 
            this.txt_registro_sus.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_registro_sus.Location = new System.Drawing.Point(201, 282);
            this.txt_registro_sus.Name = "txt_registro_sus";
            this.txt_registro_sus.Size = new System.Drawing.Size(287, 34);
            this.txt_registro_sus.TabIndex = 6;
            // 
            // lb_registro_sus
            // 
            this.lb_registro_sus.AutoSize = true;
            this.lb_registro_sus.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_registro_sus.Location = new System.Drawing.Point(111, 289);
            this.lb_registro_sus.Name = "lb_registro_sus";
            this.lb_registro_sus.Size = new System.Drawing.Size(64, 27);
            this.lb_registro_sus.TabIndex = 5;
            this.lb_registro_sus.Text = "SUS";
            // 
            // cbExamesExpandir
            // 
            this.cbExamesExpandir.AutoSize = true;
            this.cbExamesExpandir.Location = new System.Drawing.Point(494, 447);
            this.cbExamesExpandir.Name = "cbExamesExpandir";
            this.cbExamesExpandir.Size = new System.Drawing.Size(67, 17);
            this.cbExamesExpandir.TabIndex = 121;
            this.cbExamesExpandir.Text = "Expandir";
            this.cbExamesExpandir.UseVisualStyleBackColor = true;
            this.cbExamesExpandir.CheckedChanged += new System.EventHandler(this.cbExamesExpandir_CheckedChanged);
            // 
            // cbSintomasExpandir
            // 
            this.cbSintomasExpandir.AutoSize = true;
            this.cbSintomasExpandir.Location = new System.Drawing.Point(494, 410);
            this.cbSintomasExpandir.Name = "cbSintomasExpandir";
            this.cbSintomasExpandir.Size = new System.Drawing.Size(67, 17);
            this.cbSintomasExpandir.TabIndex = 122;
            this.cbSintomasExpandir.Text = "Expandir";
            this.cbSintomasExpandir.UseVisualStyleBackColor = true;
            this.cbSintomasExpandir.CheckedChanged += new System.EventHandler(this.cbSintomasExpandir_CheckedChanged);
            // 
            // clbExames
            // 
            this.clbExames.FormattingEnabled = true;
            this.clbExames.Items.AddRange(new object[] {
            "",
            "Radiografia",
            "Tumografia",
            "Glicose no Sangue",
            "Urina",
            "Fézes",
            "Ultrasonografia"});
            this.clbExames.Location = new System.Drawing.Point(199, 447);
            this.clbExames.Name = "clbExames";
            this.clbExames.Size = new System.Drawing.Size(289, 19);
            this.clbExames.TabIndex = 118;
            // 
            // clbSintomas
            // 
            this.clbSintomas.FormattingEnabled = true;
            this.clbSintomas.Items.AddRange(new object[] {
            "",
            "Febre",
            "Dores de Cabeça",
            "Enjôo",
            "Diarréia",
            "Coriza",
            "Dores na Garganta",
            "Tosse Seca"});
            this.clbSintomas.Location = new System.Drawing.Point(199, 408);
            this.clbSintomas.Name = "clbSintomas";
            this.clbSintomas.Size = new System.Drawing.Size(289, 19);
            this.clbSintomas.TabIndex = 119;
            // 
            // lbExames
            // 
            this.lbExames.AutoSize = true;
            this.lbExames.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExames.Location = new System.Drawing.Point(71, 439);
            this.lbExames.Name = "lbExames";
            this.lbExames.Size = new System.Drawing.Size(104, 27);
            this.lbExames.TabIndex = 114;
            this.lbExames.Text = "Exames";
            // 
            // lbSintomas
            // 
            this.lbSintomas.AutoSize = true;
            this.lbSintomas.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSintomas.Location = new System.Drawing.Point(51, 400);
            this.lbSintomas.Name = "lbSintomas";
            this.lbSintomas.Size = new System.Drawing.Size(124, 27);
            this.lbSintomas.TabIndex = 116;
            this.lbSintomas.Text = "Sintomas";
            // 
            // cbTipoSang
            // 
            this.cbTipoSang.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cbTipoSang.Font = new System.Drawing.Font("MS PGothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoSang.FormattingEnabled = true;
            this.cbTipoSang.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbTipoSang.Location = new System.Drawing.Point(199, 363);
            this.cbTipoSang.Margin = new System.Windows.Forms.Padding(8);
            this.cbTipoSang.Name = "cbTipoSang";
            this.cbTipoSang.Size = new System.Drawing.Size(290, 28);
            this.cbTipoSang.TabIndex = 123;
            // 
            // lbTipoSang
            // 
            this.lbTipoSang.AutoSize = true;
            this.lbTipoSang.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoSang.Location = new System.Drawing.Point(36, 364);
            this.lbTipoSang.Name = "lbTipoSang";
            this.lbTipoSang.Size = new System.Drawing.Size(139, 27);
            this.lbTipoSang.TabIndex = 124;
            this.lbTipoSang.Text = "Tipo Sang.";
            // 
            // funcControl1
            // 
            this.funcControl1.Location = new System.Drawing.Point(12, 69);
            this.funcControl1.Name = "funcControl1";
            this.funcControl1.Size = new System.Drawing.Size(677, 483);
            this.funcControl1.TabIndex = 2;
            // 
            // RegOp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 562);
            this.Controls.Add(this.cbTipoSang);
            this.Controls.Add(this.lbTipoSang);
            this.Controls.Add(this.cbExamesExpandir);
            this.Controls.Add(this.cbSintomasExpandir);
            this.Controls.Add(this.clbExames);
            this.Controls.Add(this.clbSintomas);
            this.Controls.Add(this.lbExames);
            this.Controls.Add(this.lbSintomas);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.dt_nascimento);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.txt_registro_sus);
            this.Controls.Add(this.txt_funcao);
            this.Controls.Add(this.txt_senha);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.lb_registro_sus);
            this.Controls.Add(this.lb_funcao);
            this.Controls.Add(this.lb_nascimentoF);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.lb_nome);
            this.Controls.Add(this.pn_options);
            this.Controls.Add(this.funcControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "RegOp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegOp";
            this.pn_options.ResumeLayout(false);
            this.pn_options.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_funcionario;
        private System.Windows.Forms.Button bt_paciente;
        private FuncControl funcControl1;
        private System.Windows.Forms.Panel pn_options;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label lb_nascimentoF;
        private System.Windows.Forms.Label lb_funcao;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_senha;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.TextBox txt_funcao;
        private System.Windows.Forms.DateTimePicker dt_nascimento;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox txt_registro_sus;
        private System.Windows.Forms.Label lb_registro_sus;
        private System.Windows.Forms.CheckBox cbExamesExpandir;
        private System.Windows.Forms.CheckBox cbSintomasExpandir;
        private System.Windows.Forms.CheckedListBox clbExames;
        private System.Windows.Forms.CheckedListBox clbSintomas;
        private System.Windows.Forms.Label lbExames;
        private System.Windows.Forms.Label lbSintomas;
        private System.Windows.Forms.ComboBox cbTipoSang;
        private System.Windows.Forms.Label lbTipoSang;
    }
}