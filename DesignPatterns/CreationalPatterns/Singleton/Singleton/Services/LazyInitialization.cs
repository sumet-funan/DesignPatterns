using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Services
{
    public class LazyInitialization
    {
        private static LazyInitialization instance;

        private LazyInitialization() { }

        public static LazyInitialization GetInstance()
        {
            if (instance == null)
            {
                instance = new LazyInitialization();
            }
            return instance;
        }
    }
}
