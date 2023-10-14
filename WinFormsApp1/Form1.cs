namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Baku_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new(this);
            form2.ShowDialog();
        }

        private void London_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new(this);
            form3.ShowDialog();
        }
    }
}