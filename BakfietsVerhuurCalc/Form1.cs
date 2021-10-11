using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BakfietsVerhuurCalc
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check 
            MessageBox.Show(CBModel.Text.ToString());
            //Check

          //Check if a mod
            if (CBModel.Text == "")
            {
                MessageBox.Show("Er is nog geen model gekozen");
            }
            else
            {
                //Troy Vogue BUXXO
                int modelPrice = 0;
                switch (CBModel.Text)
                {
                    case "Troy":
                        modelPrice = 20;
                        break;
                    case "Vogue":
                        modelPrice = 30;
                        break;
                    case "BUXXO":
                        modelPrice = 40;
                        break;
                }
             
                //Calc price (number of days * price of bike * amount of bikes)
                int bikePrice = (int)(NudDays.Value * modelPrice * NudAmountOfBikes.Value);

                //Rain cover price
                int rainCoverPrice = (int)(5 * NudRainCover.Value);

                //Toddler chair price
                int toddlerChairPrice = (int)(15 * NudToddlerChair.Value);

                // Pillow price
                int pillowPrice = (int)(3 * NudPillow.Value);

                //Array of all the prices 
                int[] prices = { bikePrice, rainCoverPrice, toddlerChairPrice, pillowPrice };
                int price = 0;
                for (int i = prices.Length - 1; i >= 0; i--)
                {
                    price += prices[i];
                }
                MessageBox.Show(price.ToString());
            }
           

        }
    }
}
