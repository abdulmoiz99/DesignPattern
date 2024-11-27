namespace DesignPattern.CreationalPattern.Factory
{
    internal class ConcreteCreatorB : Creator
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreateProductB();
        }
    }
}
