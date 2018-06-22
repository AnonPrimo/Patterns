using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            labelPassword.Visible = false;
            textBoxPassword.Visible = false;
            button1.Visible = false;

            comboBoxUser.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxUser.Items.Add("Client");
            comboBoxUser.Items.Add("Guest");
            comboBoxUser.Items.Add("Admin");
            comboBoxUser.SelectedIndex = 0;

            Model.TypeOfProducts tp = new Model.TypeOfProducts();

            comboBoxProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxProduct.Items.Add("Drink");
            comboBoxProduct.Items.Add("Food");
            comboBoxProduct.SelectedIndex = 0;
        }

        private void textBoxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                return;

            //if(Char.IsControl(e.KeyChar))
            //{
            //    if(e.KeyChar == (char)Keys.Enter)
            //}
            e.Handled = true;
        }

        private void comboBoxUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBoxUser.SelectedIndex == 2)
            {
                labelPassword.Visible = true;
                textBoxPassword.Visible = true;
                button1.Visible = true;
                int a = int.Parse(textBoxPassword.Text);
                if (Model.Password.Check(a))
                    Model.Change();
            }
        }
    }
}
