using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edward_JeuFinale
{
    public partial class Menu : Form
    {


       
        public Menu()
        {
            
            InitializeComponent();
            button1.Click += (sender, e) => {
               // this.Close();
                new Level1().ShowDialog();
            };
            button2.Click += (sender, e) => {
                // this.Close();
                new Level2().ShowDialog();
            };

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
