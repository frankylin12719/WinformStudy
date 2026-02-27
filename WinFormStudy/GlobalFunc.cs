using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormStudy
{
    internal class GlobalFunc
    {
        private static GlobalFunc? _Instance = null;

        public static GlobalFunc Instance { 
            get 
            {
                if (_Instance == null)
                    _Instance = new GlobalFunc();
                //_Instance ??= new GlobalFunc(); 同上
                return _Instance;
            } 
        }

        public string Name = "what is this?";

        public Login LoginPage = null;

        public string PasswordG = null;
    }
}
