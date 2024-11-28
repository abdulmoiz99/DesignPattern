namespace DesignPattern.CreationalPattern.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s1 = Database.GetInstance();
            var s2 = Database.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Singleton works!!!");
            }
            else
            {
                Console.WriteLine("Singleton failed!!");
            }

            var s3 = SingletonWithLazy.Instance;
            var s4 = SingletonWithLazy.Instance;

            if (s3 == s4)
            {
                Console.WriteLine("Singleton works!!!");
            }
            else
            {
                Console.WriteLine("Singleton failed!!");
            }
        }
    }
}
