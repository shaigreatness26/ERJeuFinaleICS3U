using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Edward_JeuFinale.Program;

namespace Edward_JeuFinale
{
    public partial class Menu : Form
    {

        
        

        public Menu()
        {
            
            InitializeComponent();
          
            button2.Click += (sender, e) => {
                // this.Close();
                new Level2().ShowDialog();
            };

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            switch (SaveData.CurrentLevel)
            {
                case 1:
                    new Level1().Show();
                    break;

                case 2:
                    new Level2().Show();
                    break;

                //case 3:
                   // new Level3().Show();
                  //  break;
            }

           // this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FreePlay freePlay = new FreePlay();
            freePlay.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Level3 level3 = new Level3();
            level3.Show();
        }
    }
}
