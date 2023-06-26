namespace crud_sqlite
{
    partial class Form_clientes
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
            this.bt_excluir = new System.Windows.Forms.Button();
            this.bt_editar = new System.Windows.Forms.Button();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.bt_gravar = new System.Windows.Forms.Button();
            this.textBox_endereco = new System.Windows.Forms.TextBox();
            this.textBox_telefone = new System.Windows.Forms.TextBox();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_endereco = new System.Windows.Forms.Label();
            this.label_telefone = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label_paginas = new System.Windows.Forms.Label();
            this.bt_tabela_anterior = new System.Windows.Forms.Button();
            this.bt_tabela_proximo = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bt_pesquisar = new System.Windows.Forms.Button();
            this.textBox_pq_endereco = new System.Windows.Forms.TextBox();
            this.textBox_pq_telefone = new System.Windows.Forms.TextBox();
            this.textBox_pq_nome = new System.Windows.Forms.TextBox();
            this.label_pq_endereco = new System.Windows.Forms.Label();
            this.label_pq_telefone = new System.Windows.Forms.Label();
            this.label_pq_nome = new System.Windows.Forms.Label();
            this.bt_atualizar_tabela = new System.Windows.Forms.Button();
            this.bt_carrinho = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_carrinho);
            this.panel1.Controls.Add(this.bt_excluir);
            this.panel1.Controls.Add(this.bt_editar);
            this.panel1.Controls.Add(this.bt_novo);
            this.panel1.Controls.Add(this.bt_cancelar);
            this.panel1.Controls.Add(this.bt_gravar);
            this.panel1.Controls.Add(this.textBox_endereco);
            this.panel1.Controls.Add(this.textBox_telefone);
            this.panel1.Controls.Add(this.textBox_nome);
            this.panel1.Controls.Add(this.label_endereco);
            this.panel1.Controls.Add(this.label_telefone);
            this.panel1.Controls.Add(this.label_nome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 593);
            this.panel1.TabIndex = 0;
            // 
            // bt_excluir
            // 
            this.bt_excluir.Location = new System.Drawing.Point(184, 272);
            this.bt_excluir.Name = "bt_excluir";
            this.bt_excluir.Size = new System.Drawing.Size(80, 48);
            this.bt_excluir.TabIndex = 12;
            this.bt_excluir.Text = "Excluir Cliente";
            this.bt_excluir.UseVisualStyleBackColor = true;
            this.bt_excluir.Click += new System.EventHandler(this.bt_excluir_Click);
            // 
            // bt_editar
            // 
            this.bt_editar.Location = new System.Drawing.Point(98, 272);
            this.bt_editar.Name = "bt_editar";
            this.bt_editar.Size = new System.Drawing.Size(80, 48);
            this.bt_editar.TabIndex = 11;
            this.bt_editar.Text = "Editar Cliente";
            this.bt_editar.UseVisualStyleBackColor = true;
            this.bt_editar.Click += new System.EventHandler(this.bt_editar_Click);
            // 
            // bt_novo
            // 
            this.bt_novo.Location = new System.Drawing.Point(12, 272);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(80, 48);
            this.bt_novo.TabIndex = 5;
            this.bt_novo.Text = "Novo Cliente";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Location = new System.Drawing.Point(143, 199);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(125, 32);
            this.bt_cancelar.TabIndex = 10;
            this.bt_cancelar.Text = "Cancelar";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // bt_gravar
            // 
            this.bt_gravar.Location = new System.Drawing.Point(12, 199);
            this.bt_gravar.Name = "bt_gravar";
            this.bt_gravar.Size = new System.Drawing.Size(125, 32);
            this.bt_gravar.TabIndex = 9;
            this.bt_gravar.Text = "Gravar";
            this.bt_gravar.UseVisualStyleBackColor = true;
            this.bt_gravar.Click += new System.EventHandler(this.bt_gravar_Click);
            // 
            // textBox_endereco
            // 
            this.textBox_endereco.Location = new System.Drawing.Point(12, 150);
            this.textBox_endereco.Name = "textBox_endereco";
            this.textBox_endereco.Size = new System.Drawing.Size(256, 22);
            this.textBox_endereco.TabIndex = 8;
            // 
            // textBox_telefone
            // 
            this.textBox_telefone.Location = new System.Drawing.Point(15, 85);
            this.textBox_telefone.Name = "textBox_telefone";
            this.textBox_telefone.Size = new System.Drawing.Size(256, 22);
            this.textBox_telefone.TabIndex = 7;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(15, 28);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(256, 22);
            this.textBox_nome.TabIndex = 6;
            // 
            // label_endereco
            // 
            this.label_endereco.AutoSize = true;
            this.label_endereco.Location = new System.Drawing.Point(12, 131);
            this.label_endereco.Name = "label_endereco";
            this.label_endereco.Size = new System.Drawing.Size(66, 16);
            this.label_endereco.TabIndex = 2;
            this.label_endereco.Text = "Endereço";
            // 
            // label_telefone
            // 
            this.label_telefone.AutoSize = true;
            this.label_telefone.Location = new System.Drawing.Point(12, 66);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(61, 16);
            this.label_telefone.TabIndex = 1;
            this.label_telefone.Text = "Telefone";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(12, 9);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(44, 16);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(286, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1046, 593);
            this.panel2.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label_paginas);
            this.panel5.Controls.Add(this.bt_tabela_anterior);
            this.panel5.Controls.Add(this.bt_tabela_proximo);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 550);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1046, 43);
            this.panel5.TabIndex = 2;
            // 
            // label_paginas
            // 
            this.label_paginas.AutoSize = true;
            this.label_paginas.Location = new System.Drawing.Point(213, 13);
            this.label_paginas.Name = "label_paginas";
            this.label_paginas.Size = new System.Drawing.Size(0, 16);
            this.label_paginas.TabIndex = 15;
            // 
            // bt_tabela_anterior
            // 
            this.bt_tabela_anterior.Dock = System.Windows.Forms.DockStyle.Left;
            this.bt_tabela_anterior.Location = new System.Drawing.Point(0, 0);
            this.bt_tabela_anterior.Name = "bt_tabela_anterior";
            this.bt_tabela_anterior.Size = new System.Drawing.Size(200, 43);
            this.bt_tabela_anterior.TabIndex = 14;
            this.bt_tabela_anterior.Text = "Ir para a página anterior";
            this.bt_tabela_anterior.UseVisualStyleBackColor = true;
            this.bt_tabela_anterior.Click += new System.EventHandler(this.bt_tabela_anterior_Click);
            // 
            // bt_tabela_proximo
            // 
            this.bt_tabela_proximo.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_tabela_proximo.Location = new System.Drawing.Point(846, 0);
            this.bt_tabela_proximo.Name = "bt_tabela_proximo";
            this.bt_tabela_proximo.Size = new System.Drawing.Size(200, 43);
            this.bt_tabela_proximo.TabIndex = 13;
            this.bt_tabela_proximo.Text = "Ir para a próxima página";
            this.bt_tabela_proximo.UseVisualStyleBackColor = true;
            this.bt_tabela_proximo.Click += new System.EventHandler(this.bt_tabela_proximo_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.tabela);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1046, 552);
            this.panel4.TabIndex = 1;
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabela.Location = new System.Drawing.Point(0, 0);
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            this.tabela.RowHeadersWidth = 51;
            this.tabela.RowTemplate.Height = 24;
            this.tabela.Size = new System.Drawing.Size(1046, 552);
            this.tabela.TabIndex = 0;
            this.tabela.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_CellDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.bt_pesquisar);
            this.panel3.Controls.Add(this.textBox_pq_endereco);
            this.panel3.Controls.Add(this.textBox_pq_telefone);
            this.panel3.Controls.Add(this.textBox_pq_nome);
            this.panel3.Controls.Add(this.label_pq_endereco);
            this.panel3.Controls.Add(this.label_pq_telefone);
            this.panel3.Controls.Add(this.label_pq_nome);
            this.panel3.Controls.Add(this.bt_atualizar_tabela);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1046, 41);
            this.panel3.TabIndex = 0;
            // 
            // bt_pesquisar
            // 
            this.bt_pesquisar.Dock = System.Windows.Forms.DockStyle.Right;
            this.bt_pesquisar.Location = new System.Drawing.Point(926, 0);
            this.bt_pesquisar.Name = "bt_pesquisar";
            this.bt_pesquisar.Size = new System.Drawing.Size(120, 41);
            this.bt_pesquisar.TabIndex = 4;
            this.bt_pesquisar.Text = "Pesquisar";
            this.bt_pesquisar.UseVisualStyleBackColor = true;
            this.bt_pesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_pq_endereco
            // 
            this.textBox_pq_endereco.Location = new System.Drawing.Point(675, 9);
            this.textBox_pq_endereco.Name = "textBox_pq_endereco";
            this.textBox_pq_endereco.Size = new System.Drawing.Size(236, 22);
            this.textBox_pq_endereco.TabIndex = 3;
            this.textBox_pq_endereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_pq_endereco_KeyDown);
            // 
            // textBox_pq_telefone
            // 
            this.textBox_pq_telefone.Location = new System.Drawing.Point(465, 10);
            this.textBox_pq_telefone.Name = "textBox_pq_telefone";
            this.textBox_pq_telefone.Size = new System.Drawing.Size(132, 22);
            this.textBox_pq_telefone.TabIndex = 2;
            this.textBox_pq_telefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_pq_telefone_KeyDown);
            // 
            // textBox_pq_nome
            // 
            this.textBox_pq_nome.Location = new System.Drawing.Point(176, 10);
            this.textBox_pq_nome.Name = "textBox_pq_nome";
            this.textBox_pq_nome.Size = new System.Drawing.Size(216, 22);
            this.textBox_pq_nome.TabIndex = 1;
            this.textBox_pq_nome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_pq_nome_KeyDown);
            // 
            // label_pq_endereco
            // 
            this.label_pq_endereco.AutoSize = true;
            this.label_pq_endereco.Location = new System.Drawing.Point(603, 9);
            this.label_pq_endereco.Name = "label_pq_endereco";
            this.label_pq_endereco.Size = new System.Drawing.Size(66, 16);
            this.label_pq_endereco.TabIndex = 11;
            this.label_pq_endereco.Text = "Endereço";
            // 
            // label_pq_telefone
            // 
            this.label_pq_telefone.AutoSize = true;
            this.label_pq_telefone.Location = new System.Drawing.Point(398, 9);
            this.label_pq_telefone.Name = "label_pq_telefone";
            this.label_pq_telefone.Size = new System.Drawing.Size(61, 16);
            this.label_pq_telefone.TabIndex = 11;
            this.label_pq_telefone.Text = "Telefone";
            // 
            // label_pq_nome
            // 
            this.label_pq_nome.AutoSize = true;
            this.label_pq_nome.Location = new System.Drawing.Point(126, 9);
            this.label_pq_nome.Name = "label_pq_nome";
            this.label_pq_nome.Size = new System.Drawing.Size(44, 16);
            this.label_pq_nome.TabIndex = 11;
            this.label_pq_nome.Text = "Nome";
            // 
            // bt_atualizar_tabela
            // 
            this.bt_atualizar_tabela.Location = new System.Drawing.Point(0, 1);
            this.bt_atualizar_tabela.Name = "bt_atualizar_tabela";
            this.bt_atualizar_tabela.Size = new System.Drawing.Size(120, 40);
            this.bt_atualizar_tabela.TabIndex = 13;
            this.bt_atualizar_tabela.Text = "Atualizar tabela";
            this.bt_atualizar_tabela.UseVisualStyleBackColor = true;
            this.bt_atualizar_tabela.Click += new System.EventHandler(this.bt_atualizar_tabela_Click);
            // 
            // bt_carrinho
            // 
            this.bt_carrinho.Location = new System.Drawing.Point(12, 326);
            this.bt_carrinho.Name = "bt_carrinho";
            this.bt_carrinho.Size = new System.Drawing.Size(96, 48);
            this.bt_carrinho.TabIndex = 13;
            this.bt_carrinho.Text = "Realizar Pedido";
            this.bt_carrinho.UseVisualStyleBackColor = true;
            // 
            // Form_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 593);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1350, 400);
            this.Name = "Form_clientes";
            this.Text = "Form_clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_clientes_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_excluir;
        private System.Windows.Forms.Button bt_editar;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_cancelar;
        private System.Windows.Forms.Button bt_gravar;
        private System.Windows.Forms.TextBox textBox_endereco;
        private System.Windows.Forms.TextBox textBox_telefone;
        private System.Windows.Forms.TextBox textBox_nome;
        private System.Windows.Forms.Label label_endereco;
        private System.Windows.Forms.Label label_telefone;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button bt_atualizar_tabela;
        private System.Windows.Forms.Button bt_pesquisar;
        private System.Windows.Forms.TextBox textBox_pq_endereco;
        private System.Windows.Forms.TextBox textBox_pq_telefone;
        private System.Windows.Forms.TextBox textBox_pq_nome;
        private System.Windows.Forms.Label label_pq_endereco;
        private System.Windows.Forms.Label label_pq_telefone;
        private System.Windows.Forms.Label label_pq_nome;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button bt_tabela_anterior;
        private System.Windows.Forms.Button bt_tabela_proximo;
        private System.Windows.Forms.Label label_paginas;
        private System.Windows.Forms.Button bt_carrinho;
    }
}