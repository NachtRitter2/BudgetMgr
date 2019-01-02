using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace BudgetMgr
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void bMonths_Click(object sender, RibbonControlEventArgs e)
        {
            frmMonths objFrmMonths = new frmMonths();

            objFrmMonths.Show();
        }
    }
}
