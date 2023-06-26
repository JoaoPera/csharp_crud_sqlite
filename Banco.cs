using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Security.Permissions;
using System.IO;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace crud_sqlite
{
    internal class Banco

    {
        private static string path = "Data Source=" + Path.GetFullPath(Path.Combine(Environment.CurrentDirectory, @"..\..\db\db.db"));
        
        private static SQLiteConnection conexao = new SQLiteConnection(path);

        public static SQLiteConnection conectar()
        {            
            if ((conexao.State != ConnectionState.Open))
            {
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

        public static SQLiteConnection desconectar()
        {
            if ((conexao.State != ConnectionState.Closed))
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
                MessageBox.Show(e.Message);
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






    public class Funcionarios
    {      
        public int id { get; set; }
        public string nome { get; set; }
        public string login { get; set; }
        public string senha { get; set; }

        public Funcionarios(int id, string nome, string login, string senha)
        {
            this.id = id;
            this.nome = nome;
            this.login = login;
            this.senha = senha;
        }

        public static Funcionarios construtor_from_row(DataRow row) {
            
            int c_id = Convert.ToInt32(row["funcionario_id"]);
            string c_nome  = row["funcionario_nome"].ToString();
            string c_login = row["funcionario_login"].ToString();
            string c_senha = row["funcionario_senha"].ToString();
            Funcionarios func = new Funcionarios(c_id, c_nome, c_login, c_senha);
            return func;
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
                throw er;
            }

        }

        public static void insert(string nome, string login, string senha)
        {
            string consulta = $"INSERT INTO FUNCIONARIOS (funcionario_nome, funcionario_login, funcionario_senha) VALUES (\"{nome}\", \"{login}\", \"{senha}\");";
            Banco.query_sem_retorno(consulta);
        }
        public void update(string novo_nome, string novo_login, string nova_senha)
        {
            try
            {
                string consulta = $"UPDATE FUNCIONARIOS SET funcionario_nome = \'{novo_nome}\' , funcionario_login = \'{novo_login}\' , funcionario_senha =  \'{nova_senha}\' WHERE funcionario_id = {this.id}";
                MessageBox.Show(consulta);
                Banco.query_sem_retorno(consulta);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                throw er;
            }
        }

        public void delete()
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

        public DataTable fetch(int pk)
        {
            string consulta = $"SELECT * FROM FUNCIONARIOS WHERE funcionario_id = {pk};";
            return Banco.consultar(consulta);
        }

        public static Funcionarios fetch_this(int pk)
        {
            string consulta = $"SELECT * FROM FUNCIONARIOS WHERE funcionario_id = {pk};";
            Exception erro;
            Funcionarios func;
            try
            {
                DataTable dt = Banco.consultar(consulta);
                if (dt.Rows.Count > 0)
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
            catch (Exception)
            {
                throw;
            }            
            return func;
        }

        public static DataTable fetch_all()
        {
            string consulta = $"SELECT * FROM FUNCIONARIOS;";
            return Banco.consultar(consulta);
        }

    }

    public class Produtos
    {
        public int id { get; set; }
        public string nome { get; set; }
        public float preco{ get; set; }
        public string descricao{ get; set; }
        
        public Produtos(int id, string nome, float preco, string descricao)
        {
            this.id = id;
            this.nome = nome;
            this.preco = preco;
            this.descricao = descricao;
        }

        public static void insert(string _nome, float _preco, string _descricao)
        {
            string consulta = $"INSERT INTO PRODUTOS (produto_nome, produto_preco, produto_descricao) VALUES (\"{_nome}\", {_preco}, \"{_descricao}\");";
            Banco.query_sem_retorno(consulta);
        }

        public static void insert(string _nome, string p, string _descricao)
        {
            float _preco = Convert.ToSingle(p);
            string consulta = $"INSERT INTO PRODUTOS (produto_nome, produto_preco, produto_descricao) VALUES (\"{_nome}\", {_preco}, \"{_descricao}\");";
            Banco.query_sem_retorno(consulta);
        }

        public void update(string _nome, string p, string _descricao)
        {
            float _preco = Convert.ToSingle(p);
            string consulta = $"UPDATE PRODUTOS SET produto_nome = \"{_nome}\", produto_preco = {_preco}, produto_descricao = \"{_descricao}\") WHERE produto_id = {this.id};";
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

        public static DataTable fetch_all()
        {
            string consulta = $"SELECT * FROM PRODUTOS;";
            return Banco.consultar(consulta);
        }
    }

    public class Clientes
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string telefone { get; set; }
        public string endereco { get; set; }

        public int row_count = 0;

        public Clientes(int id, string nome, string telefone, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.endereco = endereco;
        }

        public static void insert(string novo_nome, string novo_telefone, string novo_endereco)
        {
            string consulta = $"INSERT INTO CLIENTES (cliente_nome, cliente_telefone, cliente_endereco) VALUES (\"{novo_nome}\", \"{novo_telefone}\", \"{novo_endereco}\");";
            Banco.query_sem_retorno(consulta);
        }

        public void update(string novo_nome, string novo_telefone, string novo_endereco)
        {
            string consulta = $"UPDATE CLIENTES SET cliente_nome = \"{novo_nome}\", cliente_telefone = \"{novo_telefone}\", cliente_endereco = \"{novo_endereco}\" WHERE cliente_id = {this.id};";
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

        public static DataTable fetch_all(int limit, int offset)
        {
            string consulta = $"SELECT * FROM CLIENTES LIMIT {limit} offset {offset} ;";
            return Banco.consultar(consulta);
        }

        public static int contar_rows()
        {
            string consulta = $"SELECT Count(*) as row_count FROM CLIENTES;";
            DataTable dt = Banco.consultar(consulta);
            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["row_count"]);
            }
            return 0;
        }

        public static int contar_rows_pesquisa(string _nome, string _telefone, string _endereco) {
            string consulta = "SELECT COUNT(*) as row_count FROM CLIENTES";
            List<string> likes_list = new List<string>();
            string like_nome = string.Empty;
            string like_telefone = string.Empty;
            string like_endereco = string.Empty;
            DataTable dt = null;

            if (_nome.Length > 0)
            {
                like_nome = $" cliente_nome like \'%{_nome}%\' ";
                likes_list.Add(like_nome);
            }

            if (_telefone.Length > 0)
            {
                like_telefone = $" cliente_telefone like \'%{_telefone}%\' ";
                likes_list.Add(like_telefone);
            }

            if (_endereco.Length > 0)
            {
                like_endereco = $" cliente_endereco like \'%{_endereco}%\' ";
                likes_list.Add(like_endereco);
            }

            if (likes_list.Count > 0)
            {
                string firstElement = likes_list[0];
                consulta += " WHERE " + likes_list[0];
                likes_list.RemoveAt(0);
                while (likes_list.Count > 0)
                {
                    consulta += " AND " + likes_list[0];
                    likes_list.RemoveAt(0);
                }
            }

            dt = Banco.consultar(consulta);
            return Convert.ToInt32(dt.Rows[0]["row_count"]);
        }


        public static DataTable filtrar(string _nome, string _telefone, string _endereco){
            string consulta = "SELECT * FROM CLIENTES";
            List<string> likes_list = new List<string>();
            string like_nome = string.Empty;
            string like_telefone = string.Empty;
            string like_endereco = string.Empty;

            if (_nome.Length > 0)
            {
                like_nome = $" cliente_nome like \'%{_nome}%\' ";
                likes_list.Add(like_nome);
            }

            if (_telefone.Length > 0)
            {
                like_telefone = $" cliente_telefone like \'%{_telefone}%\' ";
                likes_list.Add(like_telefone);
            }

            if (_endereco.Length > 0)
            {
                like_endereco = $" cliente_endereco like \'%{_endereco}%\' ";
                likes_list.Add(like_endereco);
            }

            if (likes_list.Count > 0)
            {
                string firstElement = likes_list[0];
                consulta += " WHERE " + likes_list[0];
                likes_list.RemoveAt(0);
                while (likes_list.Count > 0)
                {
                    consulta += " AND " + likes_list[0];
                    likes_list.RemoveAt(0);
                }                
            }
            return Banco.consultar(consulta);
        }

    }

    public class Pagamentos
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

        public static void insert(float _valor, int _parcelas, int _tipo_de_pagamento_id, int _compra_id)
        {
            string consulta = $"INSERT INTO PAGAMENTOS (pagamento_valor, pagamento_parcelas, pagamento_tipo_de_pagamento_id, pagamento_compra_id) VALUES ({_valor}, {_parcelas}, {_tipo_de_pagamento_id}, {_compra_id});";
            Banco.query_sem_retorno(consulta);
        }

        public void update(float _valor, int _parcelas, int _tipo_de_pagamento_id)
        {
            string consulta = $"UPDATE PAGAMENTOS SET pagamento_valor = {_valor}, pagamento_parcelas = {_parcelas}, pagamento_tipo_de_pagamento_id = {_tipo_de_pagamento_id}, pagamento_compra_id = {this.compra_id} WHERE pagamento_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public void delete()
        {
            string consulta = $"DELETE FROM PAGAMENTOS WHERE pagamento_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public static DataTable fetch(int pk)
        {
            string consulta = $"SELECT * FROM PAGAMENTOS WHERE pagamento_id = {pk};";
            return Banco.consultar(consulta);
        }

        public static DataTable fetch_all()
        {
            string consulta = $"SELECT * FROM PAGAMENTOS;";
            return Banco.consultar(consulta);
        }
    }

    public class Carrinhos
    {
        private int id { get; set; }
        private int cliente_id { get; set; }

        public Carrinhos(int id, int cliente_id)
        {
            this.id = id;
            this.cliente_id = cliente_id;
        }

        public static void insert(int _cliente_id)
        {
            string consulta = $"INSERT INTO CARRINHOS (carrinho_cliente_id) VALUES ({_cliente_id});";
            Banco.query_sem_retorno(consulta);
        }

        public void update(int _cliente_id)
        {
            string consulta = $"UPDATE CARRINHOS SET carrinho_cliente_id = {_cliente_id} WHERE carrinho_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public void delete()
        {
            string consulta = $"DELETE FROM CARRINHOS WHERE carrinho_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public static DataTable fetch(int pk)
        {
            string consulta = $"SELECT * FROM CARRINHOS WHERE carrinho_id = {pk};";
            return Banco.consultar(consulta);
        }

        public static DataTable fetch_all()
        {
            string consulta = $"SELECT * FROM CARRINHOS;";
            return Banco.consultar(consulta);
        }

    }

    public class Compras
    {
        private int id { get; set; }
        private int cliente_id { get; set; }

        public Compras(int id, int cliente_id)
        {
            this.id = id;
            this.cliente_id = cliente_id;
        }

        public static void insert(int _cliente_id)
        {
            string consulta = $"INSERT INTO COMPRAS (compras_cliente_id) VALUES ({_cliente_id});";
            Banco.query_sem_retorno(consulta);
        }

        public void update(int _cliente_id)
        {
            string consulta = $"UPDATE COMPRAS SET compras_cliente_id = {_cliente_id} WHERE compras_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public void delete()
        {
            string consulta = $"DELETE FROM COMPRAS WHERE compras_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public static DataTable fetch(int pk)
        {
            string consulta = $"SELECT * FROM COMPRAS WHERE compras_id = {pk};";
            return Banco.consultar(consulta);
        }

        public static DataTable fetch_all()
        {
            string consulta = $"SELECT * FROM COMPRAS;";
            return Banco.consultar(consulta);
        }

    }

    public class Pedidos
    {
        private int id { get; set; }
        private int produto_id { get; set; }
        private int carrinho_id { get; set; }
        private int compra_id { get; set; }

        public Pedidos(int id, int produto_id, int carrinho_id, int compra_id)
        {
            this.id = id;
            this.produto_id = produto_id;
            this.carrinho_id = carrinho_id;
            this.compra_id = compra_id;
        }


        // lidar com carrinho_id e/ou compra_id == null. escrever "null" na query SQL
        public static void insert(int _produto_id, int _carrinho_id, int _compra_id)
        {
            string consulta = $"INSERT INTO PEDIDOS (pedido_produto_id, pedido_carrinho_id, pedido_compra_id) VALUES ({_produto_id}, {_carrinho_id}, {_compra_id});";
            Banco.query_sem_retorno(consulta);
        }
        public void update(int _produto_id, int _carrinho_id, int _compra_id)
        {
            string consulta = $"UPDATE PEDIDOS SET pedido_produto_id = {_produto_id}, pedido_carrinho_id = {_carrinho_id}, pedido_compra_id = {_compra_id} WHERE pedido_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public void delete()
        {
            string consulta = $"DELETE FROM PEDIDOS WHERE pedido_id = {this.id};";
            Banco.query_sem_retorno(consulta);
        }

        public static DataTable fetch(int pk)
        {
            string consulta = $"SELECT * FROM PEDIDOS WHERE pedido_id = {pk};";
            return Banco.consultar(consulta);
        }

        public static DataTable fetch_all()
        {
            string consulta = $"SELECT * FROM PEDIDOS;";
            return Banco.consultar(consulta);
        }
    }

}
