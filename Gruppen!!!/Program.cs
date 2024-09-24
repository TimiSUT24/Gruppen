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
            Console.WriteLine("Du kan Addera,Subtrahera,multiplicera,dividera");

            int a = int.Parse(Console.ReadLine());

            string val = Console.ReadLine();
            
            int b = int.Parse(Console.ReadLine());

            int result = 0; 
            switch (val)
            {
                case "+":
                    result = Addition(a, b);
                    Console.Write(result);
                    break;
                case "-":
                     result = substraction(a, b);
                    Console.WriteLine(result);
                    break;
                case "*":
                   result = Multiply(a, b);
                    Console.WriteLine(result);
                    break;
                case "/":
                   result = Division(a, b);
                    Console.WriteLine(result);
                    break;
            }
        }


}
}