using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC;
namespace MVC.Model
{
    class Change
    {
        private int num = 0;
        public int Num(int a)
        {
            get { num = a; }
            set { return num; }
        }
    }
}
