using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Security.Permissions;

namespace crud_sqlite
{
    internal class Banco
    {
        private static string path = @"Data Source=C:\Users\Pereira\Desktop\C#\crudSQLite\crud_sqlite\db\db.db";
        public static SQLiteConnection conexao = new SQLiteConnection(path);

        public static SQLiteConnection conectar()
        {            
            if ((conexao.State != ConnectionState.Open))
            {
                if (conexao.State != ConnectionState.Closed)
                {
                    try
                    {
                        conexao.Close();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
                try
                {
                    conexao.Open();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return conexao;
        }

        public static DataTable consultar(string consulta)
        {            
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = conectar().CreateCommand())
                {
                    cmd.CommandText = consulta;
                    da = new SQLiteDataAdapter(cmd.CommandText, conectar());
                    da.Fill(dt);
                }               
            }
            catch (Exception e)
            {
                throw e;
            }
            return dt;
        }

        public static int query_sem_retorno(string consulta)
        {
            try
            {
                SQLiteCommand cmd = conectar().CreateCommand();
                cmd.CommandText = consulta;
                return cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

        }

    }











    internal class Funcionarios
    {      
        private int id { get; set; }
        public string nome { get; set; }
        private string login { get; set; }
        private string senha { get; set; }

        public Funcionarios(int id, string nome, string login, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.login = login;
            this.senha = senha;
        }

        public static Funcionarios logar(string input_login, string input_senha)
        {   
            Exception erro = null;
            if (input_login.Length == 0 || input_senha.Length == 0) {
                erro = new Exception("O login e/ou a senha estão vazios");
                throw erro;
            }
            DataTable dt = null;
            Funcionarios func = null;

            try {                
                string consulta = $"SELECT * FROM FUNCIONARIOS WHERE \"funcionario_login\" == \"{input_login}\" AND \"funcionario_senha\" == \"{input_senha}\"";
                dt = Banco.consultar(consulta);
                if ( dt.Rows.Count > 0)
                {
                    int c_id = Convert.ToInt32(dt.Rows[0]["funcionario_id"]);
                    string c_nome = dt.Rows[0]["funcionario_nome"].ToString();
                    string c_login = dt.Rows[0]["funcionario_login"].ToString();
                    string c_senha = dt.Rows[0]["funcionario_senha"].ToString();
                    func = new Funcionarios(c_id, c_nome, c_login, c_senha);
                }
                else
                {
                    erro = new Exception("O login ou a senha estão errados!");
                    throw erro;
                }
            }
            catch(Exception e) {
                throw e;
            }
            return func;
        }

        public void alterar_senha(string nova_senha)
        {
            try
            {
                string consulta = $"UPDATE FUNCIONARIOS SET funcionario_senha = \"{nova_senha}\" WHERE funcionario_id = {this.id}";
                Banco.query_sem_retorno(consulta);
            }
            catch (Exception er)
            {
                throw;
            }

        }
        public void update(string nova_nome, string novo_login)
        {
            try
            {
                string consulta = $"UPDATE FUNCIONARIOS SET funcionario_nome = \"{nova_nome}\" AND \"funcionario_login\" = {novo_login} WHERE funcionario_id = {this.id}";
                Banco.query_sem_retorno(consulta);
            }
            catch (Exception er)
            {
                throw er;
            }
        }

        public void delete(string nova_nome, string novo_login)
        {
            try
            {
                string consulta = $"DELETE FROM FUNCIONARIOS WHERE funcionario_id = {this.id}";
                Banco.query_sem_retorno(consulta);
            }
            catch (Exception er)
            {
                throw er;
            }
        }
    }

    internal class Produtos
    {
        private int id { get; set; }
        private string nome { get; set; }
        private float preco{ get; set; }
        private string descricao{ get; set; }
        
        public Produtos(int id, string nome, float preco, string descricao)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.descricao = descricao;
        }

        public void insert()
        {
            string consulta = $"INSERT INTO PRODUTOS (produto_nome, produto_preco, produto_descricao) VALUES (\"{this.nome}\", {this.preco}, \"{this.descricao}\");";
            Banco.query_sem_retorno(consulta);
        }

        public void update()
        {
            string consulta = $"UPDATE PRODUTOS SET produto_nome = \"{this.nome}\", produto_preco = {this.preco}, produto_descricao = \"{this.descricao}\") WHERE produto_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public void delete()
        {
            string consulta = $"DELETE FROM PRODUTOS WHERE produto_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public DataTable fetch(int pk)
        {
            string consulta = $"SELECT * FROM PRODUTOS WHERE produto_id = {pk};";
            return Banco.consultar(consulta);
        }

        public DataTable fetch_all(int pk)
        {
            string consulta = $"SELECT * FROM PRODUTOS;";
            return Banco.consultar(consulta);
        }
    }

    internal class Clientes
    {
        private int id { get; set; }
        private string nome { get; set; }
        private string telefone { get; set; }
        private string endereco { get; set; }

        public Clientes(int id, string nome, string telefone, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
        }

        public void insert()
        {
            string consulta = $"INSERT INTO CLIENTES (cliente_nome, cliente_telefone, cliente_endereco) VALUES (\"{this.nome}\", \"{this.telefone}\", \"{this.endereco}\");";
            Banco.query_sem_retorno(consulta);
        }

        public void update()
        {
            string consulta = $"UPDATE CLIENTES SET cliente_nome = \"{this.nome}\", cliente_telefone = \"{this.telefone}\", cliente_endereco = \"{this.endereco}\") WHERE cliente_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public void delete()
        {
            string consulta = $"DELETE FROM CLIENTES WHERE cliente_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public DataTable fetch(int pk)
        {
            string consulta = $"SELECT * FROM CLIENTES WHERE cliente_id = {pk};";
            return Banco.consultar(consulta);
        }

        public DataTable fetch_all(int pk)
        {
            string consulta = $"SELECT * FROM CLIENTES;";
            return Banco.consultar(consulta);
        }
    }

    internal class Pagamentos
    {
        private int id { get; set; }
        private float valor { get; set; }
        private int parcelas { get; set; }
        private int tipo_de_pagamento_id { get; set; }
        private int compra_id { get; set; }

        public Pagamentos(int id, float valor, int parcelas, int tipo_de_pagamento_id, int compra_id)
        {
            this.id = id;
            this.valor = valor;
            this.parcelas = parcelas;
            this.tipo_de_pagamento_id = tipo_de_pagamento_id;
            this.compra_id = compra_id;
        }

        public void insert()
        {
            string consulta = $"INSERT INTO PAGAMENTOS (pagamento_valor, pagamento_parcelas, pagamento_tipo_de_pagamento_id, pagamento_compra_id) VALUES ({this.valor}, {this.parcelas}, {this.tipo_de_pagamento_id}, {this.compra_id});";
            Banco.query_sem_retorno(consulta);
        }

        public void update()
        {
            string consulta = $"UPDATE PAGAMENTOS SET pagamento_valor = {this.valor}, pagamento_parcelas = {this.parcelas}, pagamento_tipo_de_pagamento_id = {this.tipo_de_pagamento_id}, pagamento_compra_id = {this.compra_id} WHERE pagamento_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public void delete()
        {
            string consulta = $"DELETE FROM PAGAMENTOS WHERE pagamento_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public DataTable fetch(int pk)
        {
            string consulta = $"SELECT * FROM PAGAMENTOS WHERE pagamento_id = {pk};";
            return Banco.consultar(consulta);
        }

        public DataTable fetch_all(int pk)
        {
            string consulta = $"SELECT * FROM PAGAMENTOS;";
            return Banco.consultar(consulta);
        }
    }

    internal class Carrinhos
    {
        private int id { get; set; }
        private int cliente_id { get; set; }

        public Carrinhos(int id, int cliente_id)
        {
            this.id = id;
            this.cliente_id = cliente_id;
        }

        public void insert()
        {
            string consulta = $"INSERT INTO CARRINHOS (carrinho_cliente_id) VALUES ({this.cliente_id});";
            Banco.query_sem_retorno(consulta);
        }

        public void update()
        {
            string consulta = $"UPDATE CARRINHOS SET carrinho_cliente_id = {this.cliente_id} WHERE carrinho_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public void delete()
        {
            string consulta = $"DELETE FROM CARRINHOS WHERE carrinho_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public DataTable fetch(int pk)
        {
            string consulta = $"SELECT * FROM CARRINHOS WHERE carrinho_id = {pk};";
            return Banco.consultar(consulta);
        }

        public DataTable fetch_all(int pk)
        {
            string consulta = $"SELECT * FROM CARRINHOS;";
            return Banco.consultar(consulta);
        }

    }

    internal class Compras
    {
        private int id { get; set; }
        private int cliente_id { get; set; }

        public Compras(int id, int cliente_id)
        {
            this.id = id;
            this.cliente_id = cliente_id;
        }

        public void insert()
        {
            string consulta = $"INSERT INTO COMPRAS (compras_cliente_id) VALUES ({this.cliente_id});";
            Banco.query_sem_retorno(consulta);
        }

        public void update()
        {
            string consulta = $"UPDATE COMPRAS SET compras_cliente_id = {this.cliente_id} WHERE compras_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public void delete()
        {
            string consulta = $"DELETE FROM COMPRAS WHERE compras_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public DataTable fetch(int pk)
        {
            string consulta = $"SELECT * FROM COMPRAS WHERE compras_id = {pk};";
            return Banco.consultar(consulta);
        }

        public DataTable fetch_all(int pk)
        {
            string consulta = $"SELECT * FROM COMPRAS;";
            return Banco.consultar(consulta);
        }

    }

    internal class Pedidos
    {
        private int id { get; set; }
        private int cliente_id { get; set; }

        public Pedidos(int id, int produto_id, int carrinho_id, int compra_id)
        {
            this.id = id;
            this.produto_id = produto_id;
            this.carrinho_id = carrinho_id;
            this.compra_id = compra_id;
        }


        // lidar com carrinho_id e/ou compra_id == null. escrever "null" na query SQL
        public void insert()
        {
            string consulta = $"INSERT INTO PEDIDOS (pedido_produto_id, pedido_carrinho_id, pedido_compra_id) VALUES ({this.produto_id}, {this.carrinho_id}, {this.compra_id});";
            Banco.query_sem_retorno(consulta);
        }
        public void update()
        {
            string consulta = $"UPDATE PEDIDOS SET pedido_produto_id = {this.produto_id}, pedido_carrinho_id = {this.carrinho_id}, pedido_compra_id = {this.compra_id};";
            Banco.query_sem_retorno(consulta);
        }

        public void delete()
        {
            string consulta = $"DELETE FROM PEDIDOS WHERE pedido_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public DataTable fetch(int pk)
        {
            string consulta = $"SELECT * FROM PEDIDOS WHERE pedido_id = {pk};";
            return Banco.consultar(consulta);
        }

        public DataTable fetch_all(int pk)
        {
            string consulta = $"SELECT * FROM PEDIDOS;";
            return Banco.consultar(consulta);
        }
    }

}
