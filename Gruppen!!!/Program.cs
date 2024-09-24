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
            Console.WriteLine("\n1. Addera \n2. Subtrahera \n3. Multiplicera \n4. Dividera");
            int a = int.Parse(Console.ReadLine());
            string val = Console.ReadLine();
            int b = int.Parse(Console.ReadLine()); 
            switch (val)
            {
                case "+":
                    break;
                case "-":
                    break;
                case "*":
                    break;
                case "/":
                    break;
            }
        }


}
}