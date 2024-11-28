namespace DesignPattern.CreationalPattern.AbstractFactory
{
    internal class GUIFactory
    {
        public static IFactory CreateFactory(string OS)
        {
            if (OS == "MAC")
                return new MacFactory();
            else return new WindowsFactory();
        }
    }
}
