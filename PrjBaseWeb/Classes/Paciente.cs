using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrjCalculadoraWeb.Classes
{
    public class Paciente : Pessoa
    {
        private IMC imc;
        public string Registro { get; private set; }

        private static int contId = 0;

        public Paciente(string nome, 
            string cpf, 
            char sexo, 
            DateTime dtNascimento,
            float peso,
            float altura) : base(nome, cpf, sexo, dtNascimento)
        {
            imc = new IMC(peso , altura);
            Registro = (++contId).ToString();
        }

        public void Atualiza(float peso, float altura)
        {
            imc = new IMC(peso, altura);
        }

        public float Altura()
        {
            return imc.Altura;
        }

        public float Peso()
        {
            return imc.Peso;
        }

        public String Diagnostico()
        {
            return imc.Diagnostico();
        }
    }
}