using ProjetoConsole;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"Arg[{i}] = [{args[i]}]");
        }

        Car car = new Car();

        car.Ligar();
                
        string nome = "Uanderson";
        Console.WriteLine(nome);

        Console.ReadKey();
    }
}