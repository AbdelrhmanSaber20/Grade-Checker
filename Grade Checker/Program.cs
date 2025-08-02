namespace Grade_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Enter Your Grade : ");
         int Grade = Convert.ToInt32(Console.ReadLine());
         if (Grade < 60) { Console.WriteLine("Your Grade Is = F"); }
         else if (Grade >= 60 && Grade <= 69) { Console.WriteLine("Your Grade Is = D");}
         else if (Grade >= 70 && Grade <= 79) { Console.WriteLine("Your Grade Is = C");}
         else if (Grade >= 80 && Grade <= 89) { Console.WriteLine("Your Grade Is = B");}
         else if (Grade >= 90 && Grade <= 100) { Console.WriteLine("Your Grade Is = A");}
        }
    }
}
