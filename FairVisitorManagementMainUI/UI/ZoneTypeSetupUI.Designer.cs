namespace FairVisitorManagementMainUI.UI
{
    partial class ZoneTypeSetupUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.zoneTypeSaveButton = new System.Windows.Forms.Button();
            this.ZoneTypeNameTextBox = new System.Windows.Forms.TextBox();
            this.typeName = new System.Windows.Forms.Label();
            this.zoneTypeListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.zoneTypeSaveButton);
            this.groupBox1.Controls.Add(this.ZoneTypeNameTextBox);
            this.groupBox1.Controls.Add(this.typeName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(290, 104);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Zone Type ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // zoneTypeSaveButton
            // 
            this.zoneTypeSaveButton.Location = new System.Drawing.Point(160, 75);
            this.zoneTypeSaveButton.Name = "zoneTypeSaveButton";
            this.zoneTypeSaveButton.Size = new System.Drawing.Size(98, 23);
            this.zoneTypeSaveButton.TabIndex = 2;
            this.zoneTypeSaveButton.Text = "Save";
            this.zoneTypeSaveButton.UseVisualStyleBackColor = true;
            this.zoneTypeSaveButton.Click += new System.EventHandler(this.zoneTypeSaveButton_Click);
            // 
            // ZoneTypeNameTextBox
            // 
            this.ZoneTypeNameTextBox.Location = new System.Drawing.Point(83, 34);
            this.ZoneTypeNameTextBox.Name = "ZoneTypeNameTextBox";
            this.ZoneTypeNameTextBox.Size = new System.Drawing.Size(175, 20);
            this.ZoneTypeNameTextBox.TabIndex = 1;
            // 
            // typeName
            // 
            this.typeName.AutoSize = true;
            this.typeName.Location = new System.Drawing.Point(6, 34);
            this.typeName.Name = "typeName";
            this.typeName.Size = new System.Drawing.Size(62, 13);
            this.typeName.TabIndex = 0;
            this.typeName.Text = "Type Name";
            // 
            // zoneTypeListView
            // 
            this.zoneTypeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.zoneTypeListView.FullRowSelect = true;
            this.zoneTypeListView.GridLines = true;
            this.zoneTypeListView.Location = new System.Drawing.Point(12, 136);
            this.zoneTypeListView.Name = "zoneTypeListView";
            this.zoneTypeListView.Size = new System.Drawing.Size(290, 242);
            this.zoneTypeListView.TabIndex = 2;
            this.zoneTypeListView.UseCompatibleStateImageBehavior = false;
            this.zoneTypeListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Zone Id";
            this.columnHeader1.Width = 62;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Zone Name";
            this.columnHeader2.Width = 218;
            // 
            // ZoneTypeSetupUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 406);
            this.Controls.Add(this.zoneTypeListView);
            this.Controls.Add(this.groupBox1);
            this.Name = "ZoneTypeSetupUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZoneTypeSetupUI";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ZoneTypeSetupUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ZoneTypeNameTextBox;
        private System.Windows.Forms.Label typeName;
        private System.Windows.Forms.Button zoneTypeSaveButton;
        private System.Windows.Forms.ListView zoneTypeListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}