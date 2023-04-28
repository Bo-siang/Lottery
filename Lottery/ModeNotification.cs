using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class ModeNotification : Form
    {
        public ModeNotification(string msg, Color bgColor)
        {
            InitializeComponent();
            lblMessage.Text = msg;
            BackColor = bgColor;
        }

        private void ModeNotification_Load(object sender, EventArgs e)
        {
            Top = 20;
            Left = 30;
            timerClose.Start();
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
