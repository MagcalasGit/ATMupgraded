using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace updatedATM
{
    public partial class paybillssection : Form
    {
        public paybillssection()
        {
            InitializeComponent();
        }

        private void WaterBillBtn_Click(object sender, EventArgs e)
        {
            WaterBillSec gotoWater = new WaterBillSec();
            this.Hide();
            gotoWater.Show();
        }

        private void ElectricBillBtn_Click(object sender, EventArgs e)
        {
            ElectricBillSec gotoElectric = new ElectricBillSec();
            this.Hide();
            gotoElectric.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            MainForm goBack = new MainForm();
            this.Hide();
            goBack.Show();
        }
    }
}
