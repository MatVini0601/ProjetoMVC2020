using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using ProjetoMVCD33.DAL;

namespace ProjetoMVCD33.BLL
{
    public class BLLMVC
    {
        private DALMVC Banco = new DALMVC();

        public Boolean consultar(string cpf, string nome_completo, string nomeMae)
        {
            DataTable dt = Banco.Consulta(string.Format($@"select * from tbl_clienteD33 where cpf_cliente = '{cpf}' and nome_cliente = '{nome_completo}' and nome_mae = '{nomeMae}'"));
            return (dt.Rows.Count > 0 ? true : false);
        }
    }
}