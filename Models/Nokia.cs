using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoCelular.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, string memoria) : base(numero, modelo, imei, memoria)
        {   }
        
        public override void InstalarAplicativo(string nome)
        {
            Console.WriteLine("Instalando aplicativo...");
            Console.WriteLine($"Aplicativo {nome} instalado com sucesso no Nokia");
        }
    }
}