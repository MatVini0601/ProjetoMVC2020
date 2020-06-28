using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjetoMVCD33.DAL
{
    public class DALMVC
    {
        private MySqlConnection Conexao;
        private string string_conexao = "persist security info = false;" +
                                        "server = localhost;" +
                                        "database = ProjetoMVCD33;" +
                                        "user = root; pwd = Mar250970";
        public void conectar()
        {
            try
            {
                Conexao = new MySqlConnection(string_conexao);
                Conexao.Open();
            }
            catch(MySqlException err)
            {
                throw new Exception("Erro ao conectar o banco de dados:" + err.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        public void Comandos(string sql)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, Conexao);
                Conexao.Open();
            }
            catch(MySqlException err)
            {
                throw new Exception("Erro ao executar comando MySql:" + err.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
        public DataTable Consulta(string sql)
        {
            try
            {
                conectar();
                DataTable dt = new DataTable();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql,Conexao);
                dados.Fill(dt);
                Conexao.Open();
                return dt;
            }
            catch(MySqlException err)
            {
                throw new Exception("Não foi possível selecionar os registros no banco de dados. Erro" + err.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}