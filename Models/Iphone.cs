using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoCelular.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {       }

        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine("Instalando aplicativo...");
            Console.WriteLine("Aplicativo instalado com sucesso no Iphone");
        }
    }
}