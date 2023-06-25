using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_sqlite
{
    public partial class Form_clientes : Form
    {
        Form_principal form_principal;
        Clientes cliente = null;
        const string none = "none";
        const string insert = "insert";
        const string update = "update";
        //const string delete = "delete";
        string operacao = none;
        const int limit = 10;
        int offset = 0;
        int row_count = 0;
        int pagina = 1;

        public Form_clientes(Form_principal fp)
        {
            InitializeComponent();
            this.form_principal = fp;
            form_principal.Visible = false;
            atualizar_tabela();

            bt_novo.Visible = true;
            bt_editar.Visible = false;
            bt_excluir.Visible = false;
            bt_cancelar.Visible = false;
            bt_gravar.Visible = false;
            textBox_nome.ReadOnly = true;
            textBox_telefone.ReadOnly = true;
            textBox_endereco.ReadOnly = true;
            textBox_pq_nome.Focus();
        }

        private void atualizar_tabela()
        {
            this.pagina = 1;
            this.offset = 0;
            tabela.DataSource = Clientes.fetch_all(limit, offset);
            contar_rows();
        }

        private void contar_rows()
        {
            this.row_count = Clientes.contar_rows();
            atualizar_paginacao();
        }

        private void contar_rows_pesquisa()
        {
            string pq_nome = textBox_pq_nome.Text;
            string pq_telefone = textBox_pq_telefone.Text;
            string pq_endereco = textBox_pq_endereco.Text;
            this.row_count = Clientes.contar_rows_pesquisa(pq_nome, pq_telefone, pq_endereco);
            atualizar_paginacao();
        }

        private void atualizar_paginacao()
        {
            int total_de_paginas = row_count / limit + 1;
            label_paginas.Text = $"Exibindo a página {pagina} de {total_de_paginas}. Total de {row_count} registros";
            bt_tabela_proximo.Enabled = (row_count > limit && row_count > pagina * limit);
            bt_tabela_proximo.Text = (row_count > limit && row_count > pagina * limit) ? $"Ir para a próxima página -> {this.pagina + 1}" : "Esta é a última página";
            bt_tabela_anterior.Enabled = (row_count > limit && pagina * limit > limit);
            bt_tabela_anterior.Text = (row_count > limit && pagina * limit > limit) ? $"Ir para a página anterior <- {this.pagina - 1}" : "Esta é a primeira página";
        }


        private void Form_clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_principal.Visible = true;
        }

        private void bt_atualizar_tabela_Click(object sender, EventArgs e)
        {
            atualizar_tabela();
        }


        private void tabela_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the double-clicked event occurred on a valid row (not header or empty space)
                if (e.RowIndex >= 0 && e.RowIndex < tabela.Rows.Count - 1)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = tabela.Rows[e.RowIndex];

                    // Get the value of the desired column from the selected row
                    int id  = Convert.ToInt32(selectedRow.Cells["cliente_id"].Value.ToString());
                    string nome             = selectedRow.Cells["cliente_nome"].Value.ToString();
                    string telefone         = selectedRow.Cells["cliente_telefone"].Value.ToString();
                    string endereco         = selectedRow.Cells["cliente_endereco"].Value.ToString();
                    cliente = new Clientes(id, nome, telefone, endereco);

                    // Set the value to the TextBox
                    textBox_nome.Text = nome;
                    textBox_telefone.Text = telefone;
                    textBox_endereco.Text = endereco;
                    bt_editar.Visible = true;
                    bt_excluir.Visible = true;
                }
            }
            catch ( Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {

            string pergunta = $"Deseja excluir o cliente de ID {cliente.id}, {cliente.nome}? ";
            DialogResult dialogResult = MessageBox.Show(pergunta, "Excluir Funcionario?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                cliente.delete();
                cliente = null;
                atualizar_tabela();
                textBox_nome.ReadOnly = true;
                textBox_telefone.ReadOnly = true;
                textBox_endereco.ReadOnly = true;
                textBox_nome.Text = String.Empty;
                textBox_telefone.Text = String.Empty;
                textBox_endereco.Text = String.Empty;
                bt_novo.Visible = true;
                bt_editar.Visible = false;
                bt_excluir.Visible = false;
                bt_cancelar.Visible = false;
                bt_gravar.Visible = false;

            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            operacao = update;
            textBox_nome.ReadOnly = false;
            textBox_telefone.ReadOnly = false;
            textBox_endereco.ReadOnly = false;
            bt_novo.Visible = false;
            bt_editar.Visible = false;
            bt_excluir.Visible = false;
            bt_cancelar.Visible =  true ;
            bt_gravar.Visible = true;
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            operacao = insert;
            textBox_nome.ReadOnly = false;
            textBox_telefone.ReadOnly = false;
            textBox_endereco.ReadOnly = false;
            bt_novo.Visible = false;
            bt_editar.Visible = false;
            bt_excluir.Visible = false;
            bt_cancelar.Visible = true;
            bt_gravar.Visible = true;

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            textBox_nome.ReadOnly = true;
            textBox_telefone.ReadOnly = true;
            textBox_endereco.ReadOnly = true;
            bt_novo.Visible = true;
            bt_editar.Visible = false;
            bt_excluir.Visible = false;
            bt_cancelar.Visible = false;
            bt_gravar.Visible = false;
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {

            if (operacao == insert)
            {   
                Clientes.insert(textBox_nome.Text, textBox_telefone.Text, textBox_endereco.Text);
                atualizar_tabela();
                cliente = null;
            }

            if (operacao == update)
            {
                cliente.update(textBox_nome.Text, textBox_telefone.Text, textBox_endereco.Text);
                atualizar_tabela();
                cliente = null;
            }
            
            textBox_nome.ReadOnly = true;
            textBox_telefone.ReadOnly = true;
            textBox_endereco.ReadOnly = true;
            textBox_nome.Text = String.Empty;
            textBox_telefone.Text = String.Empty;
            textBox_endereco.Text = String.Empty;

            bt_novo.Visible = true;
            bt_editar.Visible = false;
            bt_excluir.Visible = false;

            bt_cancelar.Visible = false;
            bt_gravar.Visible = false;

            operacao = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pq_nome = textBox_pq_nome.Text;
            string pq_telefone = textBox_pq_telefone.Text;
            string pq_endereco = textBox_pq_endereco.Text;
            if (pq_nome.Length > 0 || pq_telefone.Length > 0 || pq_endereco.Length > 0) {
                tabela.DataSource = Clientes.filtrar(pq_nome, pq_telefone, pq_endereco);
                contar_rows_pesquisa();
            }
            else
            {
                atualizar_tabela();
            }
        }

        private void textBox_pq_nome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_pq_telefone.Focus();
            }
        }

        private void textBox_pq_telefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_pq_endereco.Focus();
            }
        }

        private void textBox_pq_endereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_pesquisar.Focus();
            }
        }

        private void bt_tabela_proximo_Click(object sender, EventArgs e)
        {            
            this.pagina++;                
            this.offset = (this.pagina - 1) * limit;
            tabela.DataSource = Clientes.fetch_all(limit, offset);           
            contar_rows();
        }

        private void bt_tabela_anterior_Click(object sender, EventArgs e)
        {
            this.pagina--;
            this.offset = (this.pagina - 1) * limit;
            tabela.DataSource = Clientes.fetch_all(limit, offset);            
            contar_rows();
        }
    }
}
