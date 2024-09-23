namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" - FEITO!
    public class Iphone : Smartphone
    { 

     // Construtor da classe derivada, passando os parâmetros para a classe base
        public Iphone(string numero, string modelo, string imei, int memoria) 
            : base(numero, modelo, imei, memoria)
        {
        }
    
        // TODO: Sobrescrever o método "InstalarAplicativo" - FEITO!

         public override void InstalarAplicativo(string nomeApp)
         {
            Console.WriteLine("Instalando aplicativo " + nomeApp + " no Iphone");
         }

    }
}