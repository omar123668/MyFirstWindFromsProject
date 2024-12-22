using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWindFromsProject
{
    public partial class FrmOrderPizza : Form
    {
        public FrmOrderPizza()
        {
            InitializeComponent();
        }
        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateGrust();
            UpdateWhereToEat();
            UpdateToppings();
            
        }
        void UpdateSize()
        {
             UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                LblSize.Text = "Small";
            }
            else if(rbMeduim.Checked)
            {
                LblSize.Text = "Medium";
            }
            else
                LblSize.Text = "Large";
        }
        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if(ChkExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }
            if(chkOnion.Checked)
            {
                sToppings += ", Onion";
            }
            if(ChkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }
            if(ChkOlives.Checked)
            {
                sToppings += ", Olives";
            }
            if(chkTomatoes.Checked)
            {
                sToppings += ", Tomatoes";
            }
            if(ChkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }
            if (sToppings == "")
            {
                lblToppings.Text = "No Toppings.";
            }
            else
            lblToppings.Text = sToppings;
                    
        }
        void UpdateGrust()
        {
            UpdateTotalPrice();
            if (rbThinGrust.Checked)
            {
                LblGrustType.Text = "Thin Grust";
            }
            if(rbThinkGrust.Checked)
                LblGrustType.Text = "Think Grust";

        }
        void UpdateWhereToEat()
        {
            
            if (rbEatIn.Checked)
            {
                LblWhereToEat.Text = "Eat In";
            }
            if(rbTakeOut.Checked)
            {
                LblWhereToEat.Text = "Take Out";
            }
        }
        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }

            else if (rbMeduim.Checked)
            {
                return Convert.ToSingle(rbMeduim.Tag);
            }

            else
                return Convert.ToSingle(rbLarge.Tag);
        }
        float GetSelectedGrust()
        {
            if (rbThinGrust.Checked)
            {
                return Convert.ToSingle(rbThinGrust.Tag);
            }
            if (rbThinkGrust.Checked)
            {
                return Convert.ToSingle(rbThinkGrust.Tag);
            }
            else
                return 0;
        }
        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if(ChkExtraChees.Checked)
            {
                ToppingsTotalPrice+= Convert.ToSingle(ChkExtraChees.Tag);
            }
            if(chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if(ChkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(ChkMushrooms.Tag);
            }
            if(ChkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(ChkOlives.Tag);
            }
            if(chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatoes.Tag);
            }
            if(ChkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(ChkGreenPeppers.Tag);
            }
            return ToppingsTotalPrice;
        }
        float CalculateTotalPrice()
        {
            return GetSelectedGrust() + CalculateToppingsPrice() + GetSelectedSizePrice();
        }
        void UpdateTotalPrice()
        {
            LblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }
        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void ChkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void ChkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void ChkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void ChkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order","Confirm",
                    MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfuly", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
                gbGrustType.Enabled = false;
               
            }

                
        }

        private void rbThinGrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrust();
        }

        private void rbThinkGrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateGrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        void ResetForm()
        {
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;
            gbGrustType.Enabled = true;

            //reset Toppings;
            ChkExtraChees.Checked  = false;
            chkOnion.Checked = false;
            ChkOlives.Checked = false;
            ChkGreenPeppers.Checked = false;
            ChkMushrooms.Checked = false;
            chkTomatoes.Checked = false;

            //where to eat;
            rbEatIn.Checked = true;
            //reset  Size;
            rbMeduim.Checked = true;

            //reset order pizza
            btnOrderPizza.Enabled = true;

            //reset Grust Button
            rbThinGrust.Checked = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void FrmOrderPizza_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }

       
    }
}
