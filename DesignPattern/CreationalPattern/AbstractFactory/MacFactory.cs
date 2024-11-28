namespace DesignPattern.CreationalPattern.AbstractFactory
{
    internal class MacFactory : IFactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextBox CreateTextBox()
        {
            return new MacTextBox();
        }
    }
}
