namespace DesignPattern.CreationalPattern.Singleton
{
    internal class SingletonWithLazy
    {
        private static readonly Lazy<SingletonWithLazy> _instance = new(() => new SingletonWithLazy());
        private SingletonWithLazy() { }
        public static SingletonWithLazy Instance => _instance.Value;
    }
}
