
namespace HistoricoPacienteWF
{
    partial class UserLogin
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pw = new System.Windows.Forms.TextBox();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_pw = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.cb_user = new System.Windows.Forms.CheckBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.Location = new System.Drawing.Point(114, 57);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(209, 32);
            this.txt_user.TabIndex = 0;
            // 
            // txt_pw
            // 
            this.txt_pw.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pw.Location = new System.Drawing.Point(114, 120);
            this.txt_pw.Name = "txt_pw";
            this.txt_pw.Size = new System.Drawing.Size(209, 32);
            this.txt_pw.TabIndex = 1;
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.Location = new System.Drawing.Point(4, 62);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(104, 27);
            this.lb_usuario.TabIndex = 1;
            this.lb_usuario.Text = "Usuário";
            // 
            // lb_pw
            // 
            this.lb_pw.AutoSize = true;
            this.lb_pw.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pw.Location = new System.Drawing.Point(20, 125);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(88, 27);
            this.lb_pw.TabIndex = 1;
            this.lb_pw.Text = "Senha";
            // 
            // bt_login
            // 
            this.bt_login.BackColor = System.Drawing.Color.Silver;
            this.bt_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.bt_login.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.bt_login.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
            this.bt_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.bt_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_login.Font = new System.Drawing.Font("MS PGothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_login.Location = new System.Drawing.Point(153, 176);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(130, 38);
            this.bt_login.TabIndex = 13;
            this.bt_login.Text = "Entrar";
            this.bt_login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_login.UseVisualStyleBackColor = false;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // cb_user
            // 
            this.cb_user.BackColor = System.Drawing.Color.Transparent;
            this.cb_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_user.Location = new System.Drawing.Point(289, 36);
            this.cb_user.Name = "cb_user";
            this.cb_user.Size = new System.Drawing.Size(10, 10);
            this.cb_user.TabIndex = 14;
            this.cb_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb_user.UseVisualStyleBackColor = false;
            this.cb_user.VisibleChanged += new System.EventHandler(this.cb_user_VisibleChanged);
            // 
            // lb_user
            // 
            this.lb_user.AutoSize = true;
            this.lb_user.Font = new System.Drawing.Font("MS PGothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user.Location = new System.Drawing.Point(158, 33);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(125, 13);
            this.lb_user.TabIndex = 15;
            this.lb_user.Text = "é um funcionario?";
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_user);
            this.Controls.Add(this.cb_user);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.lb_pw);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.txt_pw);
            this.Controls.Add(this.txt_user);
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "UserLogin";
            this.Size = new System.Drawing.Size(393, 220);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.TextBox txt_pw;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_pw;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Label lb_user;
        public System.Windows.Forms.CheckBox cb_user;
    }
}
