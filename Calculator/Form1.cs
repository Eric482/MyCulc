using System.ComponentModel.DataAnnotations;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int i = 0;
        double num1;
        string Oper;
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void buttonNum(object sender, EventArgs e)
        {
            i++;
            if (i<10)
            {
                string n = (sender as Button).Text;
                if (textBox1.Text == "0")
                {
                    textBox1.Clear();
                    textBox1.Text = textBox1.Text + n;
                }
                else
                {
                    textBox1.Text = textBox1.Text + n;
                }
                
            }
        } 
        private void buttonZnak(object sender, EventArgs e)
        {
            if(textBox1.Text != "0" || textBox1.Text != "")
            textBox1.Text = Convert.ToString(-Convert.ToDouble(textBox1.Text));
        }

        private void buttonOption(object sender, EventArgs e)
        { 
            
            if (Oper != null && textBox1.Text != "")
            {   
                Result result = new Result();
                num1 = result.ResultOfOper(Oper, num1, textBox1.Text);
                textBox1.Text = Convert.ToString(num1);
            }
            Oper = (sender as Button).Text;
            if (textBox1.Text != "")
            {
                num1 = Convert.ToDouble(textBox1.Text);
            }
            
            textBox1.Text = null;
            i = 0;
            
        }

        private void buttonC(object sender, EventArgs e)
        {
            i = 0;
            textBox1.Text = null;
            num1 = 0;
        }
        
        private void buttonResult(object sender, EventArgs e)
        {   
            Result result = new Result();
            if (result.ResultOfOper(Oper, num1, textBox1.Text) < 999999999 && result.ResultOfOper(Oper, num1, textBox1.Text) > -999999999)
            { 
                if (textBox1.Text != "")
                {
                    if (Oper != null)
                    {
                        textBox1.Text = result.ResultForTextBox(result.ResultOfOper(Oper, num1, textBox1.Text));
                        i = 0;
                        Oper = null;
                    }
                }
                else
                {
                    i = 0;
                    Oper = null;
                   textBox1.Text = Convert.ToString(result.ResultForTextBox(num1));
                }
            }
            else
            {
                i = 0;
                textBox1.Text = null;
                MessageBox.Show("Превышен лимит символов!");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}