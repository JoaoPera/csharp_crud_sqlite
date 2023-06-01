using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_sqlite
{
    public partial class Form1 : Form
    {

        private Funcionarios func = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void input_login_TextChanged(object sender, EventArgs e)
        {
            if (input_login.Text.Length == 0 || input_senha.Text.Length == 0) { 
                button_logar.Enabled = false;
                label_login_response.Text = "";
            }
            else
            {
                button_logar.Enabled = true;
                label_login_response.Text = "";
            }
        }

        private void input_senha_TextChanged(object sender, EventArgs e)
        {
            if (input_login.Text.Length == 0 || input_senha.Text.Length == 0)
            {
                button_logar.Enabled = false;
                label_login_response.Text = "";
            }
            else
            {
                button_logar.Enabled = true;
                label_login_response.Text = "";
            }
        }

        private void button_logar_Click(object sender, EventArgs e)
        {
            logar();
        }



        private void input_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                input_senha.Focus();
            }
        }

        private void input_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logar();
            }
        }

        private void logar()
        {
            string login = input_login.Text;
            string senha = input_senha.Text;
            try
            {
                func = Funcionarios.logar(login, senha);
                label_login_response.Text = $"Bem vindo, {func.nome}! Entrando...";
                Thread.Sleep(800);
                Form_principal form_Principal = new Form_principal(this);
                //this.Visible = false;
                form_Principal.ShowDialog();

            }
            catch (Exception ex)
            {
                label_login_response.Text = "";
                Thread.Sleep(80);
                label_login_response.Text = ex.Message;
            }

        }

        public void clear_inputs()
        {
            input_login.Clear();
            input_senha.Clear();
            input_login.Focus();
            label_login_response.Text = "";
        }
    }
}
