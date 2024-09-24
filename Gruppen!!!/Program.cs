namespace Gruppen___
{
    internal class Program
{


    

 
        static int substraction(int a, int b)
        {
            return a - b; 
        }
        static int Multiply(int a, int b)
        {
            return a * b; 
        }
        static int Addition(int a, int b)
        {
            
            return a + b;
        }

        static int Division(int a, int b)
        {
            return a / b; 
        }

            
 

    


    
    static void Main(string[] args)
    {
            Console.WriteLine("Tjo, vad vill du göra?");
            Console.WriteLine("1: Addera\n" +
                              "2: Subtrahera\n" +
                              "3: Multiplicera\n" +
                              "4: Dividera");
            int val = int.Parse(Console.ReadLine());


            Console.WriteLine("Skriv tal");

            int a = int.Parse(Console.ReadLine());

            
            
            int b = int.Parse(Console.ReadLine());

            int result = 0; 
            switch (val)
            {
                case 1:
                    result = Addition(a, b);
                    Console.WriteLine($"{a} + {b} = {result}");
                    break;
                case 2:
                     result = substraction(a, b);
                    Console.WriteLine($"{a} - {b} = {result}");
                    break;
                case 3:
                   result = Multiply(a, b);
                    Console.WriteLine($"{a} * {b} = {result}");
                    break;
                case 4:
                   result = Division(a, b);
                    Console.WriteLine($"{a} / {b} = {result}");
                    break;
            }
        }


}
}