namespace DesignPattern.CreationalPattern.AbstractFactory
{
    internal class WindowsTextBox : ITextBox
    {
        public string ShowText()
        {
            return "WindowsTextBox";
        }
    }
}
