using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
            
            //Add items to head image combo box
            headImageCB.Items.Add("Default");

            //Add items to body image combo box
            bodyImageCB.Items.Add("Default");


            //Add items to reward image combo box
            rewardImageCB.Items.Add("Apple");
            rewardImageCB.Items.Add("Banana");
			rewardImageCB.Items.Add("Cherry");
        }

        private void applyBTN_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Changes applied");
            if(rewardImageCB.Text == "Apple")
            {
                Rewards.rewardImage = Resource1.appleReward;
            }
            else if(rewardImageCB.Text == "Banana")
            {
                Rewards.rewardImage = Resource1.bananaReward;
            }
            else if(rewardImageCB.Text == "Cherry")
            {

            }

            if(headImageCB.Text == "Default")
            {
                Snake.headImage = Resource1.defaultHead;
            }

            if(bodyImageCB.Text == "Default")
            {
                Snake.bodyImage = Resource1.defaultBody;
            }
            

        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
