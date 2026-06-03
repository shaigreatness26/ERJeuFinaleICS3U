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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool goLeft, goRight, jumping, hasKey;
        int jumpSpeed = 10;
        int force = 8;

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        int playerSpeed = 10;
        int backgroundSpeed = 8;


        private void background_Click(object sender, EventArgs e)
        {

        }
    }
}
