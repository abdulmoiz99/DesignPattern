namespace DesignPattern.CreationalPattern.AbstractFactory
{
    internal class WindowsButton : IButton
    {
        public string Press()
        {
            return "WindowsTextBox";
        }
    }
}
