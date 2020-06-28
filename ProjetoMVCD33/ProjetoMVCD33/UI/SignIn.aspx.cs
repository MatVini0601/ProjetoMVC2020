using System;
using ProjetoMVCD33.BLL;
using ProjetoMVCD33.DTO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoMVCD33
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            


        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                DTOMVC usuario = new DTOMVC();
                usuario.Cpf_cliente = txtCpfD33.Text;
                usuario.Nome_cliente = txtNomeD33.Text;
                usuario.Nome_mae = txtNomeMaeD33.Text;

                BLLMVC bllusuario = new BLLMVC();
                if (bllusuario.consultar(usuario.Cpf_cliente, usuario.Nome_cliente, usuario.Nome_mae))
                {
                    erro.Visible = true;
                    erro.Text = "Beneficiário Localizado no Banco de dados. Processo em Análise";
                }
                else
                {
                    erro.Visible = true;
                    erro.Text = "Beneficiário Não Localizado no Banco de dados. Benefício Negado";
                }
            }
            catch(Exception err)
            {
                erro.Visible = true;
                erro.Text = err.Message;
            }
        }
    }
}