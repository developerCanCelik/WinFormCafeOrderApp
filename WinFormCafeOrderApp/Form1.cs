using BusinessLayer;
using EntityLayer.Entities;

namespace WinFormCafeOrderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void ADD(int v,Label l)
        {
            v++;
            l.Text = v.ToString();
        }
        public void DELETE(int v,Label l)
        {
            v--;
            l.Text = v.ToString();
        }
        public void Reset()
        {
            lbl_americano.Text = 0.ToString();
            lbl_latte.Text = 0.ToString();
            lbl_espresso.Text = 0.ToString();
            lbl_mocha.Text = 0.ToString();
        }

        private void americano_add_Click(object sender, EventArgs e)
        {
            int americano = Convert.ToInt32(lbl_americano.Text);
            ADD(americano, lbl_americano);
        }

        private void americano_delete_Click(object sender, EventArgs e)
        {
            int americano = Convert.ToInt32(lbl_americano.Text);
            if (americano != 0)
                DELETE(americano, lbl_americano);
        }

        private void latte_add_Click(object sender, EventArgs e)
        {
            int latte = Convert.ToInt32(lbl_latte.Text);
            ADD(latte, lbl_latte);
        }

        private void latte_delete_Click(object sender, EventArgs e)
        {
            int latte = Convert.ToInt32(lbl_latte.Text);
            if (latte != 0)
                DELETE(latte, lbl_latte);
        }

        private void espresso_add_Click(object sender, EventArgs e)
        {
            int espresso = Convert.ToInt32(lbl_espresso.Text);
            ADD(espresso, lbl_espresso);
        }

        private void espresso_delete_Click(object sender, EventArgs e)
        {
            int espresso = Convert.ToInt32(lbl_espresso.Text);
            if (espresso != 0)
                DELETE(espresso, lbl_espresso);
        }

        private void mocha_add_Click(object sender, EventArgs e)
        {
            int mocha = Convert.ToInt32(lbl_mocha.Text);
            ADD(mocha, lbl_mocha);
        }

        private void mocha_delete_Click(object sender, EventArgs e)
        {
            int mocha = Convert.ToInt32(lbl_mocha.Text);
            if (mocha != 0)
                DELETE(mocha, lbl_mocha);
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void order_ok_Click(object sender, EventArgs e)
        {
            int americano = Convert.ToInt32(lbl_americano.Text);
            int americanoTutar = Convert.ToInt32(lbl_americano_tutar.Text.Substring(0,2));
            int latte = Convert.ToInt32(lbl_latte.Text);
            int latteTutar = Convert.ToInt32(lbl_latte_tutar.Text.Substring(0, 2));
            int espresso = Convert.ToInt32(lbl_espresso.Text);
            int espressoTutar = Convert.ToInt32(lbl_espresso_tutar.Text.Substring(0, 2));
            int mocha = Convert.ToInt32(lbl_mocha.Text);
            int mochaTutar = Convert.ToInt32(lbl_mocha_tutar.Text.Substring(0, 2));

            int coffeeAmount = americano + latte + espresso + mocha;
            if (coffeeAmount > 0)
            {
                int orderFee = (americano * americanoTutar) + (latte * latteTutar) + (espresso * espressoTutar) + (mocha * mochaTutar);
                DialogResult result1 = MessageBox.Show("Kahve Sayýsý:" + coffeeAmount + "\nÜcret:" + orderFee, "Sipariþ Tamamla", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    OrderManager om = new OrderManager();
                    Order o = new Order();
                    o.OrderFee = orderFee;
                    o.CoffeeAmount = coffeeAmount;
                    om.BLAdd(o);

                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Kahve Seçimi Yapýnýz!");
            }

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}