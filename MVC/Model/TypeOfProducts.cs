using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVC;

namespace MVC.Model
{
    class TypeOfProducts
    {
        public TypeOfProducts()
        {
            comboBoxTypePr.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTypePr.Items.Add("Drink");
            comboBoxTypePr.Items.Add("Food");
            comboBoxTypePr.SelectedIndex = 0;
        }


    }
}
