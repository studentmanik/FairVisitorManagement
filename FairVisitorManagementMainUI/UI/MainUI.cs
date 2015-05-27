using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairVisitorManagementMainUI.UI;

namespace FairVisitorManagementMainUI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void entryVisitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisitorEntryUI visitorEntry=new VisitorEntryUI();
            visitorEntry.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zoneTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneTypeSetupUI zoneTypeSetup=new ZoneTypeSetupUI();
            zoneTypeSetup.Show();
        }

        private void zoneSpecificVisitorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneSpecificVisitorReportUI zoneSpecificVisitorReport=new ZoneSpecificVisitorReportUI();
            zoneSpecificVisitorReport.Show();
        }

        private void zoneWaiseVisitorNumberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ZoneWiseVisitorNumberUI zoneWiseVisitorNumber=new ZoneWiseVisitorNumberUI();
            zoneWiseVisitorNumber.Show();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {
            
        }
    }
}
