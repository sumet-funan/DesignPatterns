using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Services
{
    public class EarlyInitialization
    {
        private static EarlyInitialization instance = new EarlyInitialization();

        public static EarlyInitialization GetInstance()
        {
            return instance;
        }

        private EarlyInitialization() { }
    }
}
