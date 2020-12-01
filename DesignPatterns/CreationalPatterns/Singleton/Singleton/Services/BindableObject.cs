using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Services
{
    public class BindableObject
    {
        private static BindableObject instance;

        public static BindableObject Instance
            => instance;

        protected BindableObject()
        {
            instance = new BindableObject();
        }
    }
}
