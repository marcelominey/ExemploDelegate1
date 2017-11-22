using System;

namespace ExemploDelegate1
{
    class Program
    {
        delegate void Delegar(string msg);
        
        static void Main(string[] args)
        {
            Delegar novamsg = new Delegar(Data);//Delegar: comportamento de classe
            //JavaScript: é a chamada de call back

            novamsg("Olá, eu sou um delegate");

            Delegar novanovamsg = new Delegar(DataCompleta);
            novanovamsg("Marcelo");

            //Data("Olá");
            //Console.WriteLine(DataCompleta("Edilson"));
        }

        static void Data(string texto){
            Console.WriteLine(texto+" Hoje é "+
            DateTime.Now.ToShortDateString());
        }
        static void DataCompleta(string nome){
            Console.WriteLine("Olá " + nome + " Hoje é " + DateTime.Now.ToLongDateString());
        }
    }
}
