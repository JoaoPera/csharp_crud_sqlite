using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace crud_sqlite
{
    public partial class Form_funcionarios : Form
    {
        Funcionarios funcionario_da_sessao = null;
        Funcionarios func = null;
        const string none   = "none";
        const string insert = "insert";
        const string update = "update";
        //const string delete = "delete";
        string operacao = none;
        int id;
        string nome;
        string login;
        string senha;
        Form_principal form_principal = null;

        public Form_funcionarios(Form_principal fp)
        {
            InitializeComponent();
            this.form_principal     = fp;
            funcionario_da_sessao   = fp.funcionario_da_sessao;
            button_gravar.Visible   = false;
            button_cancelar.Visible = false;
            form_principal.Visible  = false;
            button_editar.Visible   = false;
            button_excluir.Visible  = false;
            textBox_nome.ReadOnly   = true;
            textBox_login.ReadOnly  = true;
            textBox_senha.ReadOnly  = true;
        }

        private void Form_funcionarios_Load(object sender, EventArgs e)
        {
            tabela_funcionarios.DataSource = Funcionarios.fetch_all();
        }

        private void button_atualizar_tabela_Click(object sender, EventArgs e)
        {
            tabela_funcionarios.DataSource = Funcionarios.fetch_all();
        }

        private void Form_funcionarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            form_principal.Visible = true;
        }

        private void tabela_funcionarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Check if the double-clicked event occurred on a valid row (not header or empty space)
            if (e.RowIndex >= 0 && e.RowIndex < tabela_funcionarios.Rows.Count - 1)
            {
                // Get the selected row
                DataGridViewRow selectedRow = tabela_funcionarios.Rows[e.RowIndex];

                // Get the value of the desired column from the selected row
                id = Convert.ToInt32( selectedRow.Cells["funcionario_id"].Value.ToString() );
                nome  = selectedRow.Cells["funcionario_nome"].Value.ToString();
                login = selectedRow.Cells["funcionario_login"].Value.ToString();
                senha = selectedRow.Cells["funcionario_senha"].Value.ToString();
                func = new Funcionarios(id, nome, login, senha);

                // Set the value to the TextBox
                textBox_nome.Text  = nome;
                textBox_login.Text = login;
                textBox_senha.Text = senha;
                button_editar.Visible  = true;
                button_excluir.Visible = (id != funcionario_da_sessao.id);
            }
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            operacao = update;
            textBox_nome.ReadOnly = false;
            textBox_login.ReadOnly = false;
            textBox_senha.ReadOnly = false;
            button_novo.Visible = false;
            button_editar.Visible = false;
            button_excluir.Visible = false;
            button_gravar.Visible = true;
            button_cancelar.Visible = true;

        }

        private void button_novo_Click(object sender, EventArgs e)
        {
            operacao = insert;
            textBox_nome.Text  = String.Empty;
            textBox_login.Text = String.Empty; 
            textBox_senha.Text = String.Empty;
            textBox_nome.ReadOnly   = false;
            textBox_login.ReadOnly  = false;
            textBox_senha.ReadOnly  = false;
            button_novo.Visible     = false;
            button_editar.Visible   = false;
            button_excluir.Visible  = false;
            button_gravar.Visible   = true;
            button_cancelar.Visible = true;
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            textBox_nome.ReadOnly   = true;
            textBox_login.ReadOnly  = true;
            textBox_senha.ReadOnly  = true;
            textBox_nome.Text  = String.Empty;
            textBox_login.Text = String.Empty;
            textBox_senha.Text = String.Empty;

            button_novo.Visible     = true;
            button_editar.Visible   = false;
            button_excluir.Visible  = false;

            button_cancelar.Visible = false;
            button_gravar.Visible   = false;

            operacao = string.Empty;
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            string pergunta = $"Deseja excluir o funcionado de ID {id}, {nome}? ";
            DialogResult dialogResult = MessageBox.Show(pergunta, "Excluir Funcionario?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                func.delete();
                func = null;

                tabela_funcionarios.DataSource = Funcionarios.fetch_all();

                textBox_nome.ReadOnly = true;
                textBox_login.ReadOnly = true;
                textBox_senha.ReadOnly = true;

                button_novo.Visible = false;
                button_editar.Visible = false;
                button_excluir.Visible = false;

                button_cancelar.Visible = false;
                button_gravar.Visible = false;

                button_novo.Visible = true;
            }
        }

        private void button_gravar_Click(object sender, EventArgs e)
        {
            if(operacao == insert)
            {
                Funcionarios.insert(textBox_nome.Text, textBox_login.Text, textBox_senha.Text);
                tabela_funcionarios.DataSource = Funcionarios.fetch_all();
                func = null;
            }

            if (operacao == update)
            {
                func.update(textBox_nome.Text, textBox_login.Text, textBox_senha.Text);
                tabela_funcionarios.DataSource = Funcionarios.fetch_all();
                func = null;
            }








            textBox_nome.ReadOnly = true;
            textBox_login.ReadOnly = true;
            textBox_senha.ReadOnly = true;
            textBox_nome.Text = String.Empty;
            textBox_login.Text = String.Empty;
            textBox_senha.Text = String.Empty;

            button_novo.Visible = true;
            button_editar.Visible = false;
            button_excluir.Visible = false;

            button_cancelar.Visible = false;
            button_gravar.Visible = false;

            operacao = string.Empty;














        }
    }
}
