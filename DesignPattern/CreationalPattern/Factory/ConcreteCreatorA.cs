namespace DesignPattern.CreationalPattern.Factory
{
    internal class ConcreteCreatorA : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreateProductA();
        }
    }
}
