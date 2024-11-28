namespace DesignPattern.CreationalPattern.AbstractFactory
{
    internal interface IFactory
    {
        IButton CreateButton();
        ITextBox CreateTextBox();
    }
}
