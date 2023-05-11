using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbstracaoCelular.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo;
        public string Imei;
        public string Memoria;

        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligacao...");
        }
        public abstract void InstalarAplicativo(string nome);
    }
}