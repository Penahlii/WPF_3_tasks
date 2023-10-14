using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        System.Windows.Forms.Timer timer;

        Form extra_form;
        public Form2(Form form)
        {
            this.extra_form = form;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 950;
            timer.Tick += Timer_Tick;
            timer?.Start();
            if (DateTime.Now.Hour >= 8 && DateTime.Now.Hour <= 12)
                this.BackgroundImage = Resources.Baku_Morning;
            else if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 18)
                this.BackgroundImage = Resources.Baku_Afternoon;
            else if (DateTime.Now.Hour >= 18)
                this.BackgroundImage = Resources.Baku_Night;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            label_of_timer.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            extra_form.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}