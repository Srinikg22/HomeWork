using System;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //ScoreBoard sb1 = new ScoreBoard();
            ScoreBoard sb1 = ScoreBoard.GetSB();
            sb1.RunsScored = 148;
            Console.WriteLine(sb1.RunsScored);
            ScoreBoard sb2 = ScoreBoard.GetSB();
            Console.WriteLine(sb2.RunsScored);
            sb1 = null;
            sb2 = null;

            MySingletonPattern mySingleton = MySingletonPattern.Instance;

            MySingletonPattern mySingleton_1 = MySingletonPattern.Instance;

            Console.WriteLine(mySingleton.a);

            Console.Read();
        }
    }
}
