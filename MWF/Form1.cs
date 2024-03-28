namespace MWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string num1;
        string num2;
        string symbol;
        bool switch_num = false;
        private void button_Num_Click(object sender, EventArgs e)
        {
            if (switch_num)
                num1 += sender.ToText();
            else
                num2 += sender.ToText();
            textBox1.Text = num1 + symbol + num2;
        }

        private void button_Operator_Click(object sender, EventArgs e)
        {
            switch_num = true;
            symbol = $" {sender.ToText()} ";
            textBox1.Text = num1 + symbol + num2;
        }
        private void button_Equil_Click(object sender, EventArgs e)
        {
            string cursym = symbol.Trim();
            if (switch_num == true)
                switch (cursym)
                {
                    case "+":
                        textBox3.Text = (double.Parse(num2) + double.Parse(num1)).ToString();
                        break;
                    case "-":
                        textBox3.Text = (double.Parse(num2) - double.Parse(num1)).ToString();
                        break;
                    case "*":
                        textBox3.Text = (double.Parse(num2) * double.Parse(num1)).ToString();
                        break;
                    case "/":
                        textBox3.Text = (double.Parse(num2) / double.Parse(num1)).ToString();
                        break;
                }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            symbol = "";
            switch_num = false;
            textBox3.Text = "";
            textBox1.Text = "";
        }
    }
}
//System.Windows.Forms.Button, Text: 2