using Laboratoria1StevenOmarAlfaroVillanueva.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratoria1StevenOmarAlfaroVillanueva.Negocios
{
    public class ClsPersona
    {
        public string CalcularIMC(Persona est)
        {
            double pollo = est.Peso / Math.Pow(est.Altura, 2);

            if (pollo < 24)
            {

                return "Peso ideal";

            }
            else
            {
                return "Tiene sobre peso";
            }
        }
        public string esMayorDeEdad(Persona tse)
        {
            if (tse.Edad >= 18)
            {
                return "Es Mayor de Edad";
            }
            else 
            {
                return "Es Menor de Edad";
            }
        }

    }
}
