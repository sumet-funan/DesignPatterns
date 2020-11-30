using System;
using System.Collections.Generic;
using System.Text;

namespace Ragnarok.Services
{
    public class Singleton
    {
        private static Singleton instance;

        public static Singleton Instance
            => instance;

        protected Singleton()
        {
            instance = new Singleton();
        }
    }
}
