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

namespace BallProject__10._07___WinForm____UIThread
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BallImg.Visible = false;
        }
        int dx = -1;
        int dy = -1;

        private void AddBallBtn_Click(object sender, EventArgs e)
        {
            Action a = () => { BallImg.Location = new Point(BallImg.Location.X + dx, BallImg.Location.Y + dy); };
            BallImg.Visible = true;
            Task.Run(() =>
            {
                while (true)
                {
                    if (BallImg.Location.X + dx <= 0)
                        dx = 1;
                    if (BallImg.Location.X + dx >= ClientSize.Width - BallImg.Width)
                        dx = -1;
                    if (BallImg.Location.Y + dy <= 0 + CreateBallBtn.Height)
                        dy = 1;
                    if (BallImg.Location.Y + dy >= ClientSize.Height - BallImg.Height)
                        dy = -1;
                    BallImg.BeginInvoke(a);
                    Thread.Sleep(10);
                }
            });
        }

        private void RemoveBallsImg_Click(object sender, EventArgs e)
        {
            BallImg.Visible = false;
        }
    }
}
