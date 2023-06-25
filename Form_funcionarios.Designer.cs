namespace crud_sqlite
{
    partial class Form_funcionarios
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
            this.tabela_funcionarios = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_gravar = new System.Windows.Forms.Button();
            this.button_excluir = new System.Windows.Forms.Button();
            this.button_editar = new System.Windows.Forms.Button();
            this.button_novo = new System.Windows.Forms.Button();
            this.textBox_senha = new System.Windows.Forms.TextBox();
            this.label_senha = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_atualizar_tabela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_funcionarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabela_funcionarios
            // 
            this.tabela_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_funcionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabela_funcionarios.Location = new System.Drawing.Point(0, 0);
            this.tabela_funcionarios.Name = "tabela_funcionarios";
            this.tabela_funcionarios.RowHeadersWidth = 51;
            this.tabela_funcionarios.RowTemplate.Height = 24;
            this.tabela_funcionarios.Size = new System.Drawing.Size(718, 405);
            this.tabela_funcionarios.TabIndex = 0;
            this.tabela_funcionarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_funcionarios_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_cancelar);
            this.panel1.Controls.Add(this.button_gravar);
            this.panel1.Controls.Add(this.button_excluir);
            this.panel1.Controls.Add(this.button_editar);
            this.panel1.Controls.Add(this.button_novo);
            this.panel1.Controls.Add(this.textBox_senha);
            this.panel1.Controls.Add(this.label_senha);
            this.panel1.Controls.Add(this.textBox_login);
            this.panel1.Controls.Add(this.label_login);
            this.panel1.Controls.Add(this.textBox_nome);
            this.panel1.Controls.Add(this.label_nome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 450);
            this.panel1.TabIndex = 1;
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(186, 192);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(150, 32);
            this.button_cancelar.TabIndex = 10;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_gravar
            // 
            this.button_gravar.Location = new System.Drawing.Point(16, 192);
            this.button_gravar.Name = "button_gravar";
            this.button_gravar.Size = new System.Drawing.Size(150, 32);
            this.button_gravar.TabIndex = 9;
            this.button_gravar.Text = "Gravar";
            this.button_gravar.UseVisualStyleBackColor = true;
            this.button_gravar.Click += new System.EventHandler(this.button_gravar_Click);
            // 
            // button_excluir
            // 
            this.button_excluir.Location = new System.Drawing.Point(240, 252);
            this.button_excluir.Name = "button_excluir";
            this.button_excluir.Size = new System.Drawing.Size(96, 48);
            this.button_excluir.TabIndex = 8;
            this.button_excluir.Text = "Excluir Funcionário";
            this.button_excluir.UseVisualStyleBackColor = true;
            this.button_excluir.Click += new System.EventHandler(this.button_excluir_Click);
            // 
            // button_editar
            // 
            this.button_editar.Location = new System.Drawing.Point(128, 252);
            this.button_editar.Name = "button_editar";
            this.button_editar.Size = new System.Drawing.Size(96, 48);
            this.button_editar.TabIndex = 7;
            this.button_editar.Text = "Editar Funcionário";
            this.button_editar.UseVisualStyleBackColor = true;
            this.button_editar.Click += new System.EventHandler(this.button_editar_Click);
            // 
            // button_novo
            // 
            this.button_novo.Location = new System.Drawing.Point(16, 252);
            this.button_novo.Name = "button_novo";
            this.button_novo.Size = new System.Drawing.Size(96, 48);
            this.button_novo.TabIndex = 6;
            this.button_novo.Text = "Novo Funcionário";
            this.button_novo.UseVisualStyleBackColor = true;
            this.button_novo.Click += new System.EventHandler(this.button_novo_Click);
            // 
            // textBox_senha
            // 
            this.textBox_senha.Location = new System.Drawing.Point(16, 157);
            this.textBox_senha.Name = "textBox_senha";
            this.textBox_senha.Size = new System.Drawing.Size(320, 22);
            this.textBox_senha.TabIndex = 5;
            // 
            // label_senha
            // 
            this.label_senha.AutoSize = true;
            this.label_senha.Location = new System.Drawing.Point(13, 138);
            this.label_senha.Name = "label_senha";
            this.label_senha.Size = new System.Drawing.Size(46, 16);
            this.label_senha.TabIndex = 4;
            this.label_senha.Text = "Senha";
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(16, 95);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(320, 22);
            this.textBox_login.TabIndex = 3;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(13, 76);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(40, 16);
            this.label_login.TabIndex = 2;
            this.label_login.Text = "Login";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(16, 32);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(320, 22);
            this.textBox_nome.TabIndex = 1;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(13, 13);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(44, 16);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(361, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 450);
            this.panel2.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.tabela_funcionarios);
            this.panel4.Location = new System.Drawing.Point(6, 45);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(718, 405);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button_atualizar_tabela);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(724, 39);
            this.panel3.TabIndex = 1;
            // 
            // button_atualizar_tabela
            // 
            this.button_atualizar_tabela.Location = new System.Drawing.Point(4, 4);
            this.button_atualizar_tabela.Name = "button_atualizar_tabela";
            this.button_atualizar_tabela.Size = new System.Drawing.Size(75, 23);
            this.button_atualizar_tabela.TabIndex = 0;
            this.button_atualizar_tabela.Text = "Atualizar Tabela";
            this.button_atualizar_tabela.UseVisualStyleBackColor = true;
            this.button_atualizar_tabela.Click += new System.EventHandler(this.button_atualizar_tabela_Click);
            // 
            // Form_funcionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_funcionarios";
            this.Text = "Form_funcionarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_funcionarios_FormClosing);
            this.Load += new System.EventHandler(this.Form_funcionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_funcionarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabela_funcionarios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_excluir;
        private System.Windows.Forms.Button button_editar;
        private System.Windows.Forms.Button button_novo;
        private System.Windows.Forms.TextBox textBox_senha;
        private System.Windows.Forms.Label label_senha;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button_atualizar_tabela;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_gravar;
    }
}