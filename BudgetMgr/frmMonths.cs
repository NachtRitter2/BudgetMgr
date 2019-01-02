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
        private List<Boolean> Months;

        public frmMonths()
        {
            InitializeComponent();
       
            Point appCtr = PointToClient(new Point(((int)Globals.ThisAddIn.Application.Width / 2),
                (int)Globals.ThisAddIn.Application.Top));
            
            this.Top = appCtr.X - (this.Width / 2);

            Months = new List<bool> {
                false, false, false, false,
                false, false, false, false,
                false, false, false, false
            };

        }

        private void cbMthSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMthSelectAll.Checked)
            {
                cbMthJanuary.Checked = true;
                cbMthFebruary.Checked = true;
                cbMthMarch.Checked = true;
                cbMthApril.Checked = true;
                cbMthMay.Checked = true;
                cbMthJune.Checked = true;
                cbMthJuly.Checked = true;
                cbMthAugust.Checked = true;
                cbMthSeptember.Checked = true;
                cbMthOctober.Checked = true;
                cbMthNovember.Checked = true;
                cbMthDecember.Checked = true;
            } else
            {
                cbMthJanuary.Checked = false;
                cbMthFebruary.Checked = false;
                cbMthMarch.Checked = false;
                cbMthApril.Checked = false;
                cbMthMay.Checked = false;
                cbMthJune.Checked = false;
                cbMthJuly.Checked = false;
                cbMthAugust.Checked = false;
                cbMthSeptember.Checked = false;
                cbMthOctober.Checked = false;
                cbMthNovember.Checked = false;
                cbMthDecember.Checked = false;

            }
        }

        private void cbMthJanuary_CheckedChanged(object sender, EventArgs e)
        {

            bool mthChecked = cbMthJanuary.Checked;
            int mthNum = 1;

            if (mthChecked)
            {
                setMonth(mthNum);
            }
            else
            {
                clearMonth(mthNum);
            }
         }

        private void cbMthFebruary_CheckedChanged(object sender, EventArgs e)
        {
            bool mthChecked = cbMthFebruary.Checked;
            int mthNum = 2;

            if (mthChecked)
            {
                setMonth(mthNum);
            }
            else
            {
                clearMonth(mthNum);
            }
        }

        private void cbMthMarch_CheckedChanged(object sender, EventArgs e)
        {
            bool mthChecked = cbMthMarch.Checked;
            int mthNum = 3;

            if (mthChecked)
            {
                setMonth(mthNum);
            }
            else
            {
                clearMonth(mthNum);
            }
        }

        private void cbMthApril_CheckedChanged(object sender, EventArgs e)
        {
            bool mthChecked = cbMthApril.Checked;
            int mthNum = 4;

            if (mthChecked)
            {
                setMonth(mthNum);
            }
            else
            {
                clearMonth(mthNum);
            }
        }

        private void cbMthMay_CheckedChanged(object sender, EventArgs e)
        {
            bool mthChecked = cbMthMay.Checked;
            int mthNum = 5;

            if (mthChecked)
            {
                setMonth(mthNum);
            }
            else
            {
                clearMonth(mthNum);
            }
        }

        private void cbMthJune_CheckedChanged(object sender, EventArgs e)
        {
            bool mthChecked = cbMthJune.Checked;
            int mthNum = 6;

            if (mthChecked)
            {
                setMonth(mthNum);
            }
            else
            {
                clearMonth(mthNum);
            }
        }

        private void cbMthJuly_CheckedChanged(object sender, EventArgs e)
        {
            bool mthChecked = cbMthJuly.Checked;
            int mthNum = 7;

            if (mthChecked)
            {
                setMonth(mthNum);
            }
            else
            {
                clearMonth(mthNum);
            }
        }

        private void cbMthAugust_CheckedChanged(object sender, EventArgs e)
        {
            bool mthChecked = cbMthAugust.Checked;
            int mthNum = 8;

            if (mthChecked)
            {
                setMonth(mthNum);
            }
            else
            {
                clearMonth(mthNum);
            }
        }

        private void cbMthSeptember_CheckedChanged(object sender, EventArgs e)
        {
            bool mthChecked = cbMthSeptember.Checked;
            int mthNum = 9;

            if (mthChecked)
            {
                setMonth(mthNum);
            }
            else
            {
                clearMonth(mthNum);
            }
        }

        private void cbMthOctober_CheckedChanged(object sender, EventArgs e)
        {
            bool mthChecked = cbMthOctober.Checked;
            int mthNum = 10;

            if (mthChecked)
            {
                setMonth(mthNum);
            }
            else
            {
                clearMonth(mthNum);
            }
        }

        private void cbMthNovember_CheckedChanged(object sender, EventArgs e)
        {
            bool mthChecked = cbMthNovember.Checked;
            int mthNum = 11;

            if (mthChecked)
            {
                setMonth(mthNum);
            }
            else
            {
                clearMonth(mthNum);
            }
        }

        private void cbMthDecember_CheckedChanged(object sender, EventArgs e)
        {
            bool mthChecked = cbMthDecember.Checked;
            int mthNum = 12;

            if (mthChecked)
            {
                setMonth(mthNum);
            }
            else
            {
                clearMonth(mthNum);
            }
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
            Months[Mth - 1] = true;
        }

        private void clearMonth(int Mth)
        {
            Months[Mth - 1] = false;
        }

    }
}
