using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задание__1_Курсовая_ЯВУ
{
    public partial class Zadanie_1 : Form
    {
        public Zadanie_1()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
//Нахатие на клавишу "Ok"
        private void Launch_Click(object sender, EventArgs e)
        {
            String Y = "Ошибка";
            double y = 0;
            double x = double.Parse(X_value.Text);
            double R = double.Parse(R_value.Text);
            if (x <= -4)//Первый отрезок 
            y = -3;
              else
              if (x > -4 && x <= -3)
                 y = (2 * x) + 4;
                 else
                   if (x > -3 && x <= 3)
                   y = Math.Sqrt(Math.Pow(R, 2) - Math.Pow(x, 2));
                     else
                       if (x > 3 && x <= 8)
                       y = ((3 * x / 5) - 3);
                          else
                          if (x > 8)
                            y = 3;
            if (R != 3)
                Answer.Text = Y.ToString();
            else
                Answer.Text = y.ToString();
        }
    }
}
