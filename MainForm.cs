using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LabCalculatorEngineering
{
    public partial class MainForm : Form
    {
        string expression = "";

        public MainForm()
        {
            InitializeComponent();
            SetControlProperties();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            handler_keypress(((System.Windows.Forms.Control)sender).Name);
        }

        private void handler_keypress(string Name)
        {
            MessageBox.Show(Name);
        }

        private void SetControlProperties()
        {
            SetControlProperty(button1, "pi");
            SetControlProperty(button2, "e");
            SetControlProperty(button3, "C");
            SetControlProperty(button4, "<=");
            SetControlProperty(button5, "x^3");
            SetControlProperty(button6, "x^2");
            SetControlProperty(button7, "1/x");
            SetControlProperty(button8, "|x|");
            SetControlProperty(button9, "exp");
            SetControlProperty(button10, "mod");
            SetControlProperty(button11, "x^(1/3)");
            SetControlProperty(button12, "x^(1/2)");
            SetControlProperty(button13, "(");
            SetControlProperty(button14, ")");
            SetControlProperty(button15, "n!");
            SetControlProperty(button16, "/");
            SetControlProperty(button17, "x^(1/y)");
            SetControlProperty(button18, "x^y");
            SetControlProperty(button19, "7");
            SetControlProperty(button20, "8");
            SetControlProperty(button21, "9");
            SetControlProperty(button22, "*");
            SetControlProperty(button23, "2^x");
            SetControlProperty(button24, "10^x");
            SetControlProperty(button25, "4");
            SetControlProperty(button26, "5");
            SetControlProperty(button27, "6");
            SetControlProperty(button28, "-");
            SetControlProperty(button29, "logy(x)");
            SetControlProperty(button30, "log");
            SetControlProperty(button31, "1");
            SetControlProperty(button32, "2");
            SetControlProperty(button33, "3");
            SetControlProperty(button34, "+");
            SetControlProperty(button35, "e^x");
            SetControlProperty(button36, "ln");
            SetControlProperty(button37, "+/-");
            SetControlProperty(button38, "0");
            SetControlProperty(button39, ".");
            SetControlProperty(button40, "=");
        }

        private void SetControlProperty(Control control, string text)
        {
            control.Text = text;
            control.Click += new System.EventHandler(button_Click);
        }

    }
}
