using PrjCalculadoraWeb.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrjCalculadoraWeb
{
    public partial class FrmLogin : System.Web.UI.Page
    {
        private static List<Usuario> usuarios;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (usuarios == null)
            {
                usuarios = new List<Usuario>();
                usuarios.Add(
                    new Usuario("Maria", "123.456.789/01", 'f', new DateTime(2000, 10, 10), "maria", "12345")
                    );

                usuarios.Add(
                    new Usuario("Joao", "173.453.789/01", 'm', new DateTime(2000, 10, 10), "joao", "12345")
                    );

                usuarios.Add(
                    new Usuario("Pedro", "123.476.989/01",'m', new DateTime(2000, 10, 10), "pedro", "12345")
                    );

                usuarios.Add(
                    new Usuario("Jorge", "153.986.729/01", 'm', new DateTime(2000, 10, 10), "jorge", "12345")
                    );

                usuarios.Add(
                    new Usuario("Fabio", "158.469.789/01",'m', new DateTime(2000, 10, 10), "fabio", "12345")
                    );

              


            }
        }

        protected void btOk_Click(object sender, EventArgs e)
        {
            foreach(Usuario u in usuarios)
            {
                if (u.Verifica(TxLogin.Text, TxSenha.Text))
                {
                    Response.Redirect("index.aspx", true);

                    return;
                }
            }

            lbMensagem.Text = "Usuário não reconhecido";
        }
    }
}