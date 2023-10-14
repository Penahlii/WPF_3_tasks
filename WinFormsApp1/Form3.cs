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
    public partial class Form3 : Form
    {
        System.Windows.Forms.Timer timer;
        Form form1;
        public Form3(Form form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 950;
            timer.Tick += Timer_Tick;
            timer?.Start();
            if (DateTime.UtcNow.Hour >= 8 && DateTime.UtcNow.Hour <= 12)
                this.BackgroundImage = Resources.London_Morning;
            else if (DateTime.UtcNow.Hour >= 12 && DateTime.UtcNow.Hour <= 18)
                this.BackgroundImage = Resources.London_Afternoon;
            else if (DateTime.UtcNow.Hour >= 18)
                this.BackgroundImage = Resources.London_Night_;
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            label_of_timer.Text = DateTime.UtcNow.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            form1.Show();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
