
using _10AprilHomeworkCs4.cs.point;

namespace ConsoleApprilTen
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ClassCounter CC = new ClassCounter(0, 100, 1);
            Console.Write("Enter Count : ");
            CC.Count = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine(CC);
            CC.Count++;
            Console.WriteLine(CC.Count);
            Console.WriteLine(CC);
        }
    }
}
