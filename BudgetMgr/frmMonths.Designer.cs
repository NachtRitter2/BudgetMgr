namespace BudgetMgr
{
    partial class frmMonths
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("January");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("February");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("March");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Quarter 1", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("April");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("May");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("June");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Quarter 2", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("July");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("August");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("September");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Quarter 3", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("October");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("November");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("December");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Quarter 4", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Select All", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode8,
            treeNode12,
            treeNode16});
            this.bMthOK = new System.Windows.Forms.Button();
            this.bMthCancel = new System.Windows.Forms.Button();
            this.tvMonths = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // bMthOK
            // 
            this.bMthOK.AutoSize = true;
            this.bMthOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bMthOK.Location = new System.Drawing.Point(154, 347);
            this.bMthOK.Margin = new System.Windows.Forms.Padding(2);
            this.bMthOK.Name = "bMthOK";
            this.bMthOK.Size = new System.Drawing.Size(50, 23);
            this.bMthOK.TabIndex = 3;
            this.bMthOK.Text = "OK";
            this.bMthOK.UseVisualStyleBackColor = true;
            this.bMthOK.Click += new System.EventHandler(this.bMthOK_Click);
            // 
            // bMthCancel
            // 
            this.bMthCancel.AutoSize = true;
            this.bMthCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bMthCancel.Location = new System.Drawing.Point(213, 347);
            this.bMthCancel.Margin = new System.Windows.Forms.Padding(2);
            this.bMthCancel.Name = "bMthCancel";
            this.bMthCancel.Size = new System.Drawing.Size(50, 23);
            this.bMthCancel.TabIndex = 4;
            this.bMthCancel.Text = "Cancel";
            this.bMthCancel.UseVisualStyleBackColor = true;
            this.bMthCancel.Click += new System.EventHandler(this.bMthCancel_Click);
            // 
            // tvMonths
            // 
            this.tvMonths.CheckBoxes = true;
            this.tvMonths.Location = new System.Drawing.Point(12, 12);
            this.tvMonths.Name = "tvMonths";
            treeNode1.Name = "ndJan01";
            treeNode1.Text = "January";
            treeNode2.Name = "ndFeb02";
            treeNode2.Text = "February";
            treeNode3.Name = "ndMar03";
            treeNode3.Text = "March";
            treeNode4.Name = "ndQ1";
            treeNode4.Text = "Quarter 1";
            treeNode5.Name = "ndApr04";
            treeNode5.Text = "April";
            treeNode6.Name = "ndMay05";
            treeNode6.Text = "May";
            treeNode7.Name = "ndJun06";
            treeNode7.Text = "June";
            treeNode8.Name = "ndQ2";
            treeNode8.Text = "Quarter 2";
            treeNode9.Name = "ndJul07";
            treeNode9.Text = "July";
            treeNode10.Name = "ndAug08";
            treeNode10.Text = "August";
            treeNode11.Name = "ndSep09";
            treeNode11.Text = "September";
            treeNode12.Name = "ndQ3";
            treeNode12.Text = "Quarter 3";
            treeNode13.Name = "ndOct10";
            treeNode13.Text = "October";
            treeNode14.Name = "ndNov11";
            treeNode14.Text = "November";
            treeNode15.Name = "ndDec12";
            treeNode15.Text = "December";
            treeNode16.Name = "ndQ4";
            treeNode16.Text = "Quarter 4";
            treeNode17.Name = "ndSelectAll";
            treeNode17.Text = "Select All";
            this.tvMonths.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17});
            this.tvMonths.Size = new System.Drawing.Size(150, 288);
            this.tvMonths.TabIndex = 1;
            this.tvMonths.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvMonths_AfterCheck);
            // 
            // frmMonths
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 381);
            this.Controls.Add(this.tvMonths);
            this.Controls.Add(this.bMthCancel);
            this.Controls.Add(this.bMthOK);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMonths";
            this.Text = "Select Months";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bMthOK;
        private System.Windows.Forms.Button bMthCancel;
        private System.Windows.Forms.TreeView tvMonths;
    }
}