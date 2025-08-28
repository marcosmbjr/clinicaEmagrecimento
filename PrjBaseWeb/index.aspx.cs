using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PrjCalculadoraWeb.Classes;

namespace PrjBaseWeb
{

   
    public partial class index : System.Web.UI.Page
    {
        private static List<Paciente> pacientes = new List<Paciente>();

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario u = (Usuario)Session["usuario"];

            if (u == null)
            {
                Response.Redirect("FrmLogin.aspx", true);
                return;
            }

            if (!IsPostBack)
            {
                btExcluir.Enabled = pacientes.Count > 0;
            }
        }

        protected void btLimpar_Click(object sender, EventArgs e)
        {
            txAltura.Text =
                txCpf.Text =
                TxNome.Text =
                txDataNascimento.Text =
                txPeso.Text =
                txResultado.Text = String.Empty;

            rbFem.Checked =
            rbMasc.Checked =
            rbNra.Checked = false;

            txCpf.ReadOnly = false;
            txDataNascimento.ReadOnly = false;
            TxNome.ReadOnly = false;

            // Aqui está o ajuste:
            rbFem.Enabled =
            rbMasc.Enabled =
            rbNra.Enabled = true;

            Session["paciente"] = null;

            // Atualiza botão excluir com base na lista
            btExcluir.Enabled = pacientes.Count > 0;
        }

        protected void Calcula(object sender, EventArgs e)
        {
            txResultado.Text = String.Empty;
            if (string.IsNullOrWhiteSpace(TxNome.Text))
            {
                txResultado.Text = "Nome não pode estar vazio";
                return;
            }

            if (txCpf.Text.Length != 14)
            {
                txResultado.Text = "O cpf precisa estar no formato válido";
                return;
            }
            if (!DateTime.TryParse(txDataNascimento.Text, out DateTime date))
            {
                txResultado.Text = "Data digitada é invalida!";
                return;
            }
            int idade = DateTime.Now.Year - date.Year;
            if (idade < 15 || idade > 100)
            {
                txResultado.Text = "Idade deve ser entre 15 e 100 anos!";
                return;
            }

            if (!float.TryParse(txPeso.Text, out float peso))
            {
                txResultado.Text = "O valor precisa ser numérico";
                return;
            }


            if (float.Parse(txPeso.Text) < 30 || float.Parse(txPeso.Text) > 350)
            {
                txResultado.Text = "O peso precisa estar entre 30kg e 350kg";
                return;
            }

            if (!float.TryParse(txAltura.Text, out float altura))
            {
                txResultado.Text = "Altura tem que ser numero e não pode estar vazia";
                return ;
            }
            
            
            if (float.Parse(txAltura.Text) < 1.1f || float.Parse(txAltura.Text) > 2.2f)
            {
                txResultado.Text = "A Altura tem que ser entre 1,10 metros e 2,20 metros";
                return;
            }

            if (Session["paciente"] != null)
            {
                Paciente paciente = (Paciente)Session["paciente"];
                paciente.Atualiza(peso, altura);
                //txResultado.Text = "Paciente atualizado";
                Mostrar(paciente);
                return;
            }


            if (!rbFem.Checked && !rbMasc.Checked && !rbNra.Checked)
            {
                txResultado.Text = "Tem que selecionar o Sexo";
                return;

            }
            char sexo = ' ' ;
            if (rbFem.Checked) sexo = 'f';
            if (rbMasc.Checked) sexo = 'm';
            if (rbNra.Checked) sexo = '*';

            try
            {
                Paciente p = new Paciente(
                    TxNome.Text, txCpf.Text, sexo, date, float.Parse(txPeso.Text), float.Parse(txAltura.Text));
                txResultado.Text = p.Diagnostico();

                foreach(Paciente paciente in pacientes)
                {
                    if (txCpf.Text.Equals(paciente.Cpf))
                    {
                        txResultado.Text = "Paciente já cadastrado";
                        return;
                    }
                }
                pacientes.Add(p);
                btExcluir.Enabled = true;
            }
          




            catch (Exception ex)
            {
                txResultado.Text = "Ocorreu um erro: " + ex.Message;
            }
        }

        private  void Mostrar(Paciente p)
        {
            txAltura.Text = p.Altura().ToString();
            txCpf.Text = p.Cpf;
            TxNome.Text = p.Nome.ToString();
            txDataNascimento.Text = p.DtNascimento.ToString("dd/MM/yyyy");
            txPeso.Text = p.Peso().ToString();

            txResultado.Text = p.Diagnostico();

            rbFem.Checked = p.Sexo == 'f';
            rbMasc.Checked = p.Sexo == 'm';
            rbNra.Checked = p.Sexo == '*';
        }

        protected void btOkBusca_Click(object sender, EventArgs e)
        {
            foreach(Paciente p in pacientes)
            {
                if (p.Registro.Equals(txBusca.Text))
                {
                    txCpf.ReadOnly = true; 
                    txDataNascimento.ReadOnly = true;
                    TxNome.ReadOnly = true;
                    rbFem.Enabled =
                    rbMasc.Enabled =
                    rbNra.Enabled = false;

                    Session["paciente"] = p;

                    Mostrar(p);
                    return;

                }
            }
            txResultado.Text = "Paciente não cadastrado";
        }

        protected void txBusca_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btExcluir_Click(object sender, EventArgs e)
        {
            if (Session["paciente"] != null)
            {
                Paciente paciente = (Paciente)Session["paciente"];

                // Remove da lista
                pacientes.RemoveAll(p => p.Cpf == paciente.Cpf);

                // Limpa os campos
                btLimpar_Click(sender, e);

                // Remove da session
                Session["paciente"] = null;

                txResultado.Text = "Paciente excluído com sucesso!";
            }

            // Desativa botão se não tiver mais pacientes
            btExcluir.Enabled = pacientes.Count > 0;
        }
    
    }
}