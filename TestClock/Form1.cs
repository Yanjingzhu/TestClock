using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestClock
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.label_show.Text = "";
            this.timer_show.Enabled = false;
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            this.timer_show.Enabled = true;
        }

        private void timer_show_Tick(object sender, EventArgs e)
        {
            var dt_time = DateTime.Now.ToString("HH:mm:ss");
            var dt_date = DateTime.Now.ToString("yyyy/MM/dd ddd");
            this.label_show.Text = "##-----------####-----------##\r\n" + dt_time + "\r\n" + dt_date + "\r\n##-----------####-----------##";
        }
    }
}
