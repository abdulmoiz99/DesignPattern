using System.Net.WebSockets;

namespace DesignPattern.CreationalPattern.AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mac = GUIFactory.CreateFactory("MAC");

            Console.WriteLine(mac.CreateButton().Press());
            Console.WriteLine(mac.CreateTextBox().ShowText());


            var windows = GUIFactory.CreateFactory("Windows");

            Console.WriteLine(windows.CreateButton().Press());
            Console.WriteLine(windows.CreateTextBox().ShowText());
        }
    }
}
