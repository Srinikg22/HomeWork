using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SingletonPattern
{
    class ScoreBoard
    {
        // Singleton Pattern Explanation https://www.youtube.com/watch?v=sbML3xFHRbI
        // Connection with DI.
        // Static classes are not grauntee to be thread safe, You can get more than one instance in the app domain
        // when using static, DB Context is fairly expensive 
        private static readonly ScoreBoard sb =
           new ScoreBoard();

        private ScoreBoard()
        { Console.WriteLine("SB created"); }

        public double RunRate { get; set; }
        public int RunsScored { get; set; }
        public double OversCompleted { get; set; }
        public double Requiredrunrate { get; set; }
        //factory method
        public static ScoreBoard GetSB()
        {
            return sb;
        }
        public double GetOversRemaining()
        {
            //sb = new ScoreBoard();
            return 50 - OversCompleted;
        }

        // It Describes the Purpose of readonly, uncomment it and see the error.
        //public void CreateAnotherInstance()
        //{
        //    sb = new ScoreBoard();
        //}
    }
}
