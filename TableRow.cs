using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCalculatorEngineering
{
    public enum FormElementType
    {
        Label, Button, TextBox, ListBox
    };

    internal class TableRow
    {
        public FormElementType Type { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public float Size { get; set; }
    }
}
