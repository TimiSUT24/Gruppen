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
            int val = Convert.ToInt32(Console.ReadLine());
            switch (val)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
        }


}
}