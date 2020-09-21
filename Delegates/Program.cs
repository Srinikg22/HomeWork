using System;

namespace Delegates
{
    class Program
    {
        delegate int Del(int x);
        private void SwitchToqlAuth()
        {
            int serverInfo = 555;

            // Lambda Expression
            Func<int, int> getSqlConnection = (serverInfo) =>
            {
                return serverInfo;
            };

            int a = getSqlConnection(serverInfo);

            Console.WriteLine(serverInfo);
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            Del del = delegate (int x)
            {
                Console.WriteLine(x);
                return 0;
            };
            p.SwitchToqlAuth();
            del(5);
        }
    }
}
