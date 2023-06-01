namespace crud_sqlite
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.input_login = new System.Windows.Forms.TextBox();
            this.input_senha = new System.Windows.Forms.TextBox();
            this.button_logar = new System.Windows.Forms.Button();
            this.label_login_response = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha : ";
            // 
            // input_login
            // 
            this.input_login.Location = new System.Drawing.Point(92, 28);
            this.input_login.Name = "input_login";
            this.input_login.Size = new System.Drawing.Size(263, 22);
            this.input_login.TabIndex = 2;
            this.input_login.TextChanged += new System.EventHandler(this.input_login_TextChanged);
            this.input_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_login_KeyDown);
            // 
            // input_senha
            // 
            this.input_senha.Location = new System.Drawing.Point(92, 69);
            this.input_senha.Name = "input_senha";
            this.input_senha.Size = new System.Drawing.Size(263, 22);
            this.input_senha.TabIndex = 3;
            this.input_senha.TextChanged += new System.EventHandler(this.input_senha_TextChanged);
            this.input_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input_senha_KeyDown);
            // 
            // button_logar
            // 
            this.button_logar.Enabled = false;
            this.button_logar.Location = new System.Drawing.Point(92, 115);
            this.button_logar.Name = "button_logar";
            this.button_logar.Size = new System.Drawing.Size(215, 37);
            this.button_logar.TabIndex = 4;
            this.button_logar.Text = "Logar";
            this.button_logar.UseVisualStyleBackColor = true;
            this.button_logar.Click += new System.EventHandler(this.button_logar_Click);
            // 
            // label_login_response
            // 
            this.label_login_response.AutoSize = true;
            this.label_login_response.Location = new System.Drawing.Point(92, 159);
            this.label_login_response.Name = "label_login_response";
            this.label_login_response.Size = new System.Drawing.Size(0, 16);
            this.label_login_response.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 245);
            this.Controls.Add(this.label_login_response);
            this.Controls.Add(this.button_logar);
            this.Controls.Add(this.input_senha);
            this.Controls.Add(this.input_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Faça login para iniciar a sessão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input_login;
        private System.Windows.Forms.TextBox input_senha;
        private System.Windows.Forms.Button button_logar;
        private System.Windows.Forms.Label label_login_response;
    }
}

