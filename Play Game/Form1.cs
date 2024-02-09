using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Play_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readylabel_Click(object sender, EventArgs e)
        {

        }

        private void startbutton_Click(object sender, EventArgs e)
        {

            //
            readylabel.Text = "3";

            Refresh();
            Thread.Sleep(1000);

            readylabel.Text = "2";

            Refresh();
            Thread.Sleep(1000);

            readylabel.Text = "1";

            Refresh();
            Thread.Sleep(1000);

            readylabel.Text = "Go!";
            this.BackColor = Color.Green;

            startbutton.Visible = false;

            

                    }
    }
}
