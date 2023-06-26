namespace crud_sqlite
{
    partial class Form_produtos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_atualizar_tabela = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_preco = new System.Windows.Forms.TextBox();
            this.textBox_descricao = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox_descricao);
            this.panel1.Controls.Add(this.textBox_preco);
            this.panel1.Controls.Add(this.textBox_nome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bt_atualizar_tabela);
            this.panel1.Controls.Add(this.bt_cancelar);
            this.panel1.Controls.Add(this.bt_gravar);
            this.panel1.Controls.Add(this.bt_excluir);
            this.panel1.Controls.Add(this.bt_editar);
            this.panel1.Controls.Add(this.bt_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 450);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabela);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 450);
            this.panel2.TabIndex = 1;
            // 
            // tabela
            // 
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabela.Location = new System.Drawing.Point(0, 0);
            this.tabela.Name = "tabela";
            this.tabela.RowHeadersWidth = 51;
            this.tabela.RowTemplate.Height = 24;
            this.tabela.Size = new System.Drawing.Size(500, 450);
            this.tabela.TabIndex = 0;
            this.tabela.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_CellDoubleClick);
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(12, 329);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(80, 32);
            this.bt_novo.TabIndex = 0;
            this.bt_novo.Text = "bt_novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(112, 329);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(80, 32);
            this.bt_editar.TabIndex = 1;
            this.bt_editar.Text = "bt_editar";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_gravar
            // 
            this.bt_gravar.Location = new System.Drawing.Point(12, 293);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(135, 32);
            this.bt_gravar.TabIndex = 3;
            this.bt_gravar.Text = "bt_gravar";
            this.bt_gravar.UseVisualStyleBackColor = true;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(214, 329);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(80, 32);
            this.bt_excluir.TabIndex = 2;
            this.bt_excluir.Text = "bt_excluir";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_atualizar_tabela
            // 
            this.bt_atualizar_tabela.Location = new System.Drawing.Point(182, 0);
            this.bt_atualizar_tabela.Name = "bt_atualizar_tabela";
            this.bt_atualizar_tabela.Size = new System.Drawing.Size(118, 29);
            this.bt_atualizar_tabela.TabIndex = 5;
            this.bt_atualizar_tabela.Text = "bt_atualizar_tabela";
            this.bt_atualizar_tabela.UseVisualStyleBackColor = true;
            this.bt_atualizar_tabela.Click += new System.EventHandler(this.bt_atualizar_tabela_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(159, 293);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(135, 32);
            this.bt_cancelar.TabIndex = 4;
            this.bt_cancelar.Text = "bt_cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(12, 49);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(282, 22);
            this.textBox_nome.TabIndex = 9;
            // 
            // textBox_preco
            // 
            this.textBox_preco.Location = new System.Drawing.Point(12, 105);
            this.textBox_preco.Name = "textBox_preco";
            this.textBox_preco.Size = new System.Drawing.Size(282, 22);
            this.textBox_preco.TabIndex = 10;
            // 
            // textBox_descricao
            // 
            this.textBox_descricao.Location = new System.Drawing.Point(12, 161);
            this.textBox_descricao.Multiline = true;
            this.textBox_descricao.Name = "textBox_descricao";
            this.textBox_descricao.Size = new System.Drawing.Size(282, 126);
            this.textBox_descricao.TabIndex = 11;
            // 
            // Form_produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_produtos";
            this.Text = "Form_produtos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_produtos_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.TextBox textBox_descricao;
        private System.Windows.Forms.TextBox textBox_preco;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_atualizar_tabela;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_novo;
    }
}