namespace DesignPattern.CreationalPattern.Singleton
{
    internal class Database
    {
        private static Database _instance;
        private Database()
        {
            // make the constructor private
        }

        public static Database GetInstance()
        {
            if (_instance == null)
                _instance = new Database();

            return _instance;
        }

    }
}
