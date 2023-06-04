using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LabCalculatorEngineering
{
    public partial class MainForm : Form
    {
        #region FIELDS
        
        string expression = "";
        ScaleElements scaleElements = new ScaleElements();

        #endregion

        public MainForm()
        {
            InitializeComponent();
            SetControlProperties();
            SetScaleElementsDefaults();
        }

        #region FormEvents

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (!(scaleElements is null) && this.IsHandleCreated)
            {
                TableRow[] tableRows = GetRescaledFontSizes();
                if (!(tableRows is null))
                {
                    SetNewFontSizes(tableRows);
                }
            }
        }

        #endregion

        #region ControlEvents

        private void button_Click(object sender, EventArgs e)
        {
            handler_keypress(((System.Windows.Forms.Control)sender).Name);
        }

        #endregion

        #region UtilityFunctions

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

        #endregion

        #region FontResize

        private void SetScaleElementsDefaults()
        {
            TableRow[] tableRows = new TableRow[4];

            tableRows[0] = new TableRow();
            tableRows[0].Type = FormElementType.Label;
            tableRows[0].Width = labelExpression.Width;
            tableRows[0].Height = labelExpression.Height;
            tableRows[0].Size = labelExpression.Font.Size;

            tableRows[1] = new TableRow();
            tableRows[1].Type = FormElementType.TextBox;
            tableRows[1].Width = textBoxOperand.Width;
            tableRows[1].Height = textBoxOperand.Height;
            tableRows[1].Size = textBoxOperand.Font.Size;

            tableRows[2] = new TableRow();
            tableRows[2].Type = FormElementType.Button;
            tableRows[2].Width = button1.Width;
            tableRows[2].Height = button1.Height;
            tableRows[2].Size = button1.Font.Size;

            tableRows[3] = new TableRow();
            tableRows[3].Type = FormElementType.ListBox;
            tableRows[3].Width = listBoxOperationHistory.Width;
            tableRows[3].Height = listBoxOperationHistory.Height;
            tableRows[3].Size = listBoxOperationHistory.Font.Size;

            scaleElements.SetDefaults(tableRows);
        }

        private TableRow[] GetRescaledFontSizes()
        {
            TableRow[] tableRows = new TableRow[4];

            tableRows[0] = new TableRow();
            tableRows[0].Type = FormElementType.Label;
            tableRows[0].Width = labelExpression.Width;
            tableRows[0].Height = labelExpression.Height;

            tableRows[1] = new TableRow();
            tableRows[1].Type = FormElementType.TextBox;
            tableRows[1].Width = textBoxOperand.Width;
            tableRows[1].Height = textBoxOperand.Height;

            tableRows[2] = new TableRow();
            tableRows[2].Type = FormElementType.Button;
            tableRows[2].Width = button1.Width;
            tableRows[2].Height = button1.Height;

            tableRows[3] = new TableRow();
            tableRows[3].Type = FormElementType.ListBox;
            tableRows[3].Width = listBoxOperationHistory.Width;
            tableRows[3].Height = listBoxOperationHistory.Height;

            tableRows = scaleElements.RescaleFonts(tableRows);

            return tableRows;
        }

        private void SetNewFontSizes(TableRow[] tableRows)
        {
            foreach (TableRow tableRow in tableRows)
            {
                switch (tableRow.Type)
                {
                    case FormElementType.Label:
                        SetNewFontSize(labelExpression, tableRow.Size);
                        break;
                    case FormElementType.TextBox:
                        SetNewFontSize(textBoxOperand, tableRow.Size);
                        break;
                    case FormElementType.ListBox:
                        SetNewFontSize(listBoxOperationHistory, tableRow.Size);
                        break;
                    case FormElementType.Button:
                        foreach (Control padButton in tableLayoutPanelPad.Controls)
                        {
                            SetNewFontSize(padButton, tableRow.Size);
                        }
                        break;
                }
            }
        }
        
        private void SetNewFontSize(Control control, float newSize)
        {
            control.Font = new Font(control.Font.FontFamily, newSize);
        }

        #endregion
    }
}
