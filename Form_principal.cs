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
    public partial class Form_principal : Form
    {

        public Funcionarios funcionario_da_sessao = null;
        Form1 form_login = null;



        //public Funcionarios get_funcionario_da_sessao() {
        //    return this.funcionario_da_sessao;        
        //}



        public Form_principal(Form1 form_login)
        {
            InitializeComponent();
            this.form_login = form_login;
            this.funcionario_da_sessao = form_login.func;
            form_login.Visible = false;
        }

        private void Form_principal_Load(object sender, EventArgs e)
        {

        }

        private void Form_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_login.clear_inputs();
            form_login.Visible = true;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void encerrarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_login.clear_inputs();
            form_login.Visible = true;
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_funcionarios_Click(object sender, EventArgs e)
        {
            Form_funcionarios form_funcionarios= new Form_funcionarios(this);
            form_funcionarios.ShowDialog();
        }

        private void button_clientes_Click(object sender, EventArgs e)
        {
            Form_clientes form_funcionarios = new Form_clientes(this);
            form_funcionarios.ShowDialog();
        }
    }
}
