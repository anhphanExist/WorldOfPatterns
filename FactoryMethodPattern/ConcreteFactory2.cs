namespace FactoryMethodPattern
{
    class ConcreteFactory2 : Factory
    {
        public override IProduct FactoryMethod()
        {
            return new ConcreteProduct2();
        }
    }
}