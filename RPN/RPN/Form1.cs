using System;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace RPN
{
    public partial class Form1 : Form
    {
        private PolishNotationCalculator calculator;
        private IStack<double> stackImplementation;

        public Form1()
        {
            InitializeComponent();
            calculator = new PolishNotationCalculator(stackImplementation);
        }

        private void Btn_Eval_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = Txt_Input.Text.Trim();
                double result = calculator.Evaluate(expression);
                Lbl_Output.Text = "Result: " + result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Invalid Expression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
