using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC;
namespace MVC.Model
{
    class Password
    {
        private int pass = 1;
        public bool Check(int a)
        {
            if (a == pass)
                return true;
            else
                return false;
        }
    }
}
