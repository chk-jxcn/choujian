using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Image myimage = null;
            try
            {
                myimage = new Bitmap(@".\background.jpg");
            }
            finally
            {
                BackgroundImage = myimage;
            }
            autogen.SelectedIndex = 3;
            state = CurrentState.WaitForStart;
            award = new Award();
            total.Text = award.candidatenumber.ToString();
            remainlucker.Text = award.allawardscount.ToString();
            updateinfo();
        }

        public enum CurrentState
        {
            WaitForStart,
            Gening,
            NextAward,
            Complete
        }

        public int stoptime()
        {
            switch(autogen.SelectedIndex)
            {
                case 0:
                    return 1;
                case 1:
                    return 3;
                case 2:
                    return 10;
                case 3:
                    return -1;

            }
            return -1;
        }

        public CurrentState state;
        public int remaintime;
        public static Award award;
        private void next_Click(object sender, EventArgs e)
        {
            switch(state)
            {
                case CurrentState.WaitForStart:
                    gostate(CurrentState.Gening);
                    remaintime = stoptime();
                    if(remaintime != -1)
                    {
                        progressBar1.Maximum = remaintime;
                        progressBar1.Value = 1;
                        next.Enabled = false;
                    }
                    else
                    {
                        progressBar1.Maximum = 10;
                        progressBar1.Value = 1;
                    }
                    autogentimer.Start();
                    showname.Start();
                    break;
                case CurrentState.Gening:
                    stopgening();
                    break;
                case CurrentState.NextAward:
                    award.gonext();
                    updateinfo();
                    candidate.Text = "";
                    gostate(CurrentState.WaitForStart);
                    break;
            }

        }

        private void call(string number)
        {

        }

        private void updateinfo()
        {
            awardinfo.Text = award.currentawardstate();
            ThisAward.Text = award.currentawardname();
            lucker.Text = award.alllucer.ToString();
            remainlucker.Text = (award.allawardscount - award.alllucer).ToString();
        }

        private void gostate(CurrentState s)
        {
            switch(s)
            {
                case CurrentState.WaitForStart:
                    next.Text = "開始抽獎";
                    break;
                case CurrentState.Gening:
                    next.Text = "停止抽獎";
                    break;
                case CurrentState.NextAward:
                    next.Text = "下一獎項";
                    break;
                case CurrentState.Complete:
                    next.Text = "已抽完全部獎項";
                    next.Enabled = false;
                    break;
            }
            state = s;
        }

        private void stopgening()
        {
            showname.Stop();
            autogentimer.Stop();
            next.Enabled = true;

            award.pickup((string[])candidate.Tag, !allowmulti.Checked);
            updateinfo();
            var ret = award.nextaward();
            switch(ret)
            {
                case 0:
                    gostate(CurrentState.WaitForStart);
                    break;
                case 1:
                    gostate(CurrentState.NextAward);
                    break;
                case 2:
                    gostate(CurrentState.Complete);
                    break;
            }

            if (autonext.Checked)
                next.PerformClick();

            if (calllucker.Checked)
                call(((string[])candidate.Tag)[1]);
        }

        private void autogentimer_Tick(object sender, EventArgs e)
        {
            if (remaintime != -1)
            {
                remaintime -= 1;
                // update process bar
                if(remaintime > 0)
                    progressBar1.Value = progressBar1.Maximum - remaintime + 1;
                if (remaintime == 0)
                    stopgening();
            }
            else
            {
                if (progressBar1.Value == progressBar1.Maximum)
                    progressBar1.Value = progressBar1.Minimum;
                else
                    progressBar1.Value += 1;
                Application.DoEvents();
            }
        }

        private void showname_Tick(object sender, EventArgs e)
        {
            var can = award.randomcandidate();
            candidate.Text = can[0];
            candidate.Tag = can;
        }

        private void log_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
