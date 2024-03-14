
namespace OláNovamenteMundo
{
    partial class Form1
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
            this.Login = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(110, 77);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(110, 113);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(38, 13);
            this.Senha.TabIndex = 1;
            this.Senha.Text = "Senha";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(162, 74);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "admin";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(162, 110);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.Text = "ds@etefmc";
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(141, 163);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(75, 23);
            this.buttonlogin.TabIndex = 4;
            this.buttonlogin.Text = "LOGIN";
            this.buttonlogin.UseVisualStyleBackColor = true;
            this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(414, 246);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 238);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button buttonlogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

