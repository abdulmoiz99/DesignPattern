namespace DesignPattern.CreationalPattern.AbstractFactory
{
    internal class WindowsFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }
        public ITextBox CreateTextBox()
        {
            return new WindowsTextBox();
        }
    }
}
