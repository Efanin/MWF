namespace Casino
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }
        int t = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            label1.Text = t.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
