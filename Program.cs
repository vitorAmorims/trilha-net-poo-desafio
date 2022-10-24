using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        var nokia = new Nokia("999999999", "Nokia1", "as233asad54545", "32GB");
        var iphone = new Iphone("999999910", "X", "as233asad54545", "64GB");

        nokia.Ligar();
        iphone.Ligar();

        nokia.InstalarAplicativo("ballzone");
        iphone.InstalarAplicativo("ballzone");

        nokia.Desligar();
        iphone.Desligar();

        System.Console.ReadKey();



    }
}
