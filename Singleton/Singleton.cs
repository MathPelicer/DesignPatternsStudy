namespace Singleton
{
    public class Singleton
    {
        private Singleton() { }

        public static Singleton _instance;

        private static readonly object _instanceLock = new object();

        public static Singleton GetInstance(string value)
        {
            if(_instance == null)
            {
                // this lock makes the singleton thread safe
                lock(_instanceLock)
                {
                    // the first thread to get after the lock gets to create the instance
                    if(_instance == null)
                    {
                        _instance = new Singleton();
                        _instance.Value = value;
                    }
                }
            }

            return _instance;
        }

        public string Value { get; set; }
    }
}
