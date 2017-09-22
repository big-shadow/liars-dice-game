using LiarsDice;
using LiarsDice.UIInterface;
using System;

namespace LiarsDiceGUI
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            LiarsDiceGame g = new LiarsDiceGame(new ConsoleUI());
            g.Play();
        }
    }

    public class ConsoleUI : UI
    {
        public string GetInput()
        {
            return Console.ReadLine();
        }

        public void Send(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}