
namespace projeto_poo_incrementado.Models
{
    public class Iphone : Smartphone
    {
        //Construtor
        public Iphone (string numero, string modelo, string IMEI2, int memoria) : 
                        base(numero, modelo, IMEI2, memoria)
        {
            
        }


        // OK TODO: Sobrescrever o método "InstalarAplicativo"
        // FEITO!!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando app {nomeApp} no Iphone... \n"); //interpolacao

        }
    }
}