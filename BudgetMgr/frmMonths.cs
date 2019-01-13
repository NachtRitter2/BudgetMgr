using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetMgr
{
    public partial class frmMonths : Form
    {

        public frmMonths()
        {
            InitializeComponent();

            Point appCtr = PointToClient(new Point(((int)Globals.ThisAddIn.Application.Width / 2),
                (int)Globals.ThisAddIn.Application.Top));

            this.Top = appCtr.X - (this.Width / 2);



            tvMonths.ExpandAll();


        }


        private void bMthOK_Click(object sender, EventArgs e)
        {
            frmMonths.ActiveForm.Close();
        }

        private void bMthCancel_Click(object sender, EventArgs e)
        {
            frmMonths.ActiveForm.Close();
        }

        private void setMonth(int Mth)
        {
            ThisAddIn.Months[Mth - 1] = true;
        }

        private void clearMonth(int Mth)
        {
            ThisAddIn. Months[Mth - 1] = false;
        }

        private void tvMonths_AfterCheck(object sender, TreeViewEventArgs e)
        {

            tvMonths.BeginUpdate();

            foreach (TreeNode aNode in e.Node.Nodes)
            {
                aNode.Checked = e.Node.Checked;

            }

            tvMonths.EndUpdate();

        }
    }
}
