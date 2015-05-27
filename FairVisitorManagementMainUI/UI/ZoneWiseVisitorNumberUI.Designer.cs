namespace FairVisitorManagementMainUI.UI
{
    partial class ZoneWiseVisitorNumberUI
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
            this.zoneWiseVisitorListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.totalVisitorTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // zoneWiseVisitorListView
            // 
            this.zoneWiseVisitorListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.zoneWiseVisitorListView.FullRowSelect = true;
            this.zoneWiseVisitorListView.GridLines = true;
            this.zoneWiseVisitorListView.Location = new System.Drawing.Point(12, 60);
            this.zoneWiseVisitorListView.Name = "zoneWiseVisitorListView";
            this.zoneWiseVisitorListView.Size = new System.Drawing.Size(360, 232);
            this.zoneWiseVisitorListView.TabIndex = 0;
            this.zoneWiseVisitorListView.UseCompatibleStateImageBehavior = false;
            this.zoneWiseVisitorListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zone";
            this.columnHeader1.Width = 138;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Number Of Visitor";
            this.columnHeader2.Width = 217;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Visitor";
            // 
            // totalVisitorTextbox
            // 
            this.totalVisitorTextbox.Location = new System.Drawing.Point(272, 316);
            this.totalVisitorTextbox.Name = "totalVisitorTextbox";
            this.totalVisitorTextbox.Size = new System.Drawing.Size(100, 20);
            this.totalVisitorTextbox.TabIndex = 2;
            this.totalVisitorTextbox.TabStop = false;
            // 
            // ZoneWiseVisitorNumberUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 374);
            this.Controls.Add(this.totalVisitorTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zoneWiseVisitorListView);
            this.Name = "ZoneWiseVisitorNumberUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZoneWiseVisitorNumberUI";
            this.Load += new System.EventHandler(this.ZoneWiseVisitorNumberUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView zoneWiseVisitorListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox totalVisitorTextbox;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}