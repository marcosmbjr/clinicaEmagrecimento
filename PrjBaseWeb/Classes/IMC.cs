using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrjCalculadoraWeb.Classes
{
    public class IMC
    {
        public float Peso { get; private set; }
        public float Altura { get; private set; }

        public IMC(float peso, float altura)
        {
            Peso = peso;
            Altura = altura;
        }
        public String Diagnostico()
        {
            try
            {
                float imc = Calculo();
                if (imc < 16) return "Baixo peso Grau III";
                if (imc < 17) return "Baixo peso Grau II";
                if (imc < 18.5) return "Baixo peso Grau I";
                if (imc < 25) return "Peso Ideal";
                if (imc < 30) return "SobrePeso";
                if (imc < 35) return "Obesidade Grau I";
                if (imc < 40) return "Obesidade Grau II";
                return "Obesidade Grau III (Mórbida)";
            }
            catch (Exception)
            {
                throw;
            }
        }
        private float Calculo()
        {
            try
            {
                return Peso/ (Altura*Altura);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}