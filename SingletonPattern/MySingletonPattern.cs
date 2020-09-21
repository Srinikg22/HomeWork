using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SingletonPattern
{
    public sealed class MySingletonPattern
    {
        private static volatile MySingletonPattern _myInstance;

        private MySingletonPattern()
        {

        }

        public static MySingletonPattern Instance
        {
            get
            {
                if (_myInstance != null) return _myInstance;

                if (_myInstance == null)
                {
                    _myInstance = new MySingletonPattern();
                }
                return _myInstance;
            }
        }

        public int a = 10;
    }
}
