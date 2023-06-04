using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabCalculatorEngineering
{
    internal class ScaleElements
    {
        private TableRow[] TableRows;

        public ScaleElements() { }

        public void SetDefaults(TableRow[] tableRows)
        {
            TableRows = tableRows;
        }

        public TableRow[] RescaleFonts(TableRow[] tableRows)
        {
            foreach (TableRow tableRow in tableRows)
            {
                var originalTableRow = GetRowByType(tableRow.Type);
                if (originalTableRow == null)
                {
                    continue;
                }

                if (originalTableRow.Width > 0 && originalTableRow.Height > 0)
                {
                    float xRatio = tableRow.Width / (float)originalTableRow.Width;
                    float yRatio = tableRow.Height / (float)originalTableRow.Height;

                    float ratio = (xRatio >= yRatio) ? xRatio : yRatio;

                    tableRow.Size = originalTableRow.Size * ratio;
                }
            }

            return tableRows;
        }

        private TableRow GetRowByType(FormElementType type)
        {
            foreach (TableRow tableRow in TableRows)
            {
                if (tableRow.Type == type)
                {
                    return tableRow;
                }
            }

            return null;
        }

    }
}
