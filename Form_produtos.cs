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
    public partial class Form_produtos : Form
    {
        Form_principal form_principal;
        Produtos produto = null;
        const string none = "none";
        const string insert = "insert";
        const string update = "update";
        //const string delete = "delete";
        string operacao = none;
        const int limit = 10;
        int offset = 0;
        int row_count = 0;
        int pagina = 1;

        public Form_produtos(Form_principal fp)
        {
            InitializeComponent();
            this.form_principal = fp;
            form_principal.Visible = false;


            bt_novo.Visible = true;
            bt_editar.Visible = false;
            bt_excluir.Visible = false;
            bt_cancelar.Visible = false;            
            bt_gravar.Visible = false;
            atualizar_tabela();
        }

        private void atualizar_tabela()
        {
            this.pagina = 1;
            this.offset = 0;
            tabela.DataSource = Produtos.fetch_all();
        }

        private void Form_produtos_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_principal.Visible = true;
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            operacao = insert;
            textBox_nome.Focus();
            textBox_nome.Text = string.Empty;
            textBox_preco.Text = string.Empty;
            textBox_descricao.Text = string.Empty;
            textBox_nome.ReadOnly = false;
            textBox_preco.ReadOnly = false;
            textBox_descricao.ReadOnly = false;

            bt_cancelar.Visible = true;
            bt_gravar.Visible = true;
            bt_novo.Visible = false;
            bt_editar.Visible = false;
            bt_excluir.Visible = false;
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
                    int id =        Convert.ToInt32(selectedRow.Cells["produto_id"].Value.ToString());
                    string nome =                   selectedRow.Cells["produto_nome"].Value.ToString();
                    float preco =   Convert.ToSingle(selectedRow.Cells["produto_preco"].Value.ToString());
                    string descricao =              selectedRow.Cells["produto_descricao"].Value.ToString();
                    produto = new Produtos(id, nome, preco, descricao);

                    // Set the value to the TextBox
                    textBox_nome.Text = nome;
                    textBox_preco.Text = preco.ToString();
                    textBox_descricao.Text = descricao;
                    bt_editar.Visible = true;
                    bt_excluir.Visible = true;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void bt_editar_Click(object sender, EventArgs e)
        {
            operacao = update;
            textBox_nome.Focus();
            textBox_nome.Text = string.Empty;
            textBox_preco.Text = string.Empty;
            textBox_descricao.Text = string.Empty;
            textBox_nome.ReadOnly = false;
            textBox_preco.ReadOnly = false;
            textBox_descricao.ReadOnly = false;

            bt_cancelar.Visible = true;
            bt_gravar.Visible = true;
            bt_novo.Visible = false;
            bt_editar.Visible = false;
            bt_excluir.Visible = false;
        }

        private void bt_gravar_Click(object sender, EventArgs e)
        {

            float _preco = 0;
            try
            {
                _preco = Convert.ToSingle(textBox_preco.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Insira um valor numérico para o preço " + err.Message);
                return;
            }
            if (textBox_nome.Text.Length == 0) {
                MessageBox.Show("não é possivel gravar um produto com o campo nome vazio");
                return;            
            }

            if (operacao == insert)
            { 
                Produtos.insert(textBox_nome.Text, textBox_preco.Text, textBox_descricao.Text);
            }

            if (operacao == update)
            {
                produto.update(textBox_nome.Text, textBox_preco.Text, textBox_descricao.Text);
            }
            atualizar_tabela();
            produto = null;

            textBox_nome.ReadOnly = true;
            textBox_preco.ReadOnly = true;
            textBox_descricao.ReadOnly = true;
            textBox_nome.Text = String.Empty;
            textBox_preco.Text = String.Empty;
            textBox_descricao.Text = String.Empty;

            bt_novo.Visible = true;
            bt_editar.Visible = false;
            bt_excluir.Visible = false;

            bt_cancelar.Visible = false;
            bt_gravar.Visible = false;            

            operacao = string.Empty;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            textBox_nome.ReadOnly = true;
            textBox_preco.ReadOnly = true;
            textBox_descricao.ReadOnly = true;
            bt_novo.Visible = true;
            bt_editar.Visible = false;
            bt_excluir.Visible = false;
            bt_cancelar.Visible = false;
            bt_gravar.Visible = false;
            textBox_nome.Text = String.Empty;
            textBox_preco.Text = String.Empty;
            textBox_descricao.Text = String.Empty;
        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {
            string pergunta = $"Deseja excluir o cliente de ID {produto.id}, {produto.nome}? ";
            DialogResult dialogResult = MessageBox.Show(pergunta, "Excluir Funcionario?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                produto.delete();
                produto = null;
                atualizar_tabela();
                textBox_nome.ReadOnly = true;
                textBox_preco.ReadOnly = true;
                textBox_descricao.ReadOnly = true;
                textBox_nome.Text = String.Empty;
                textBox_preco.Text = String.Empty;
                textBox_descricao.Text = String.Empty;
                bt_novo.Visible = true;
                bt_editar.Visible = false;
                bt_excluir.Visible = false;
                bt_cancelar.Visible = false;
                bt_gravar.Visible = false;

            }
        }

        private void bt_atualizar_tabela_Click(object sender, EventArgs e)
        {
            atualizar_tabela();
        }
    }
}
