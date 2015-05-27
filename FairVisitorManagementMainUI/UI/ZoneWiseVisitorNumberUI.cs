using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairVisitorManagementMainUI.BLL;
using FairVisitorManagementMainUI.Model;

namespace FairVisitorManagementMainUI.UI
{
    public partial class ZoneWiseVisitorNumberUI : Form
    {
        public ZoneWiseVisitorNumberUI()
        {
            InitializeComponent();
        }
        VisitorManager anVisitorManager = new VisitorManager();
        private void ZoneWiseVisitorNumberUI_Load(object sender, EventArgs e)
        {
            List<ZoneType> zoneTypes = anVisitorManager.GetAllZoneType();
            List<ZoneType> allCountList=new List<ZoneType>();
            foreach (ZoneType anZone in zoneTypes)
            {
                anZone.TotalVisitor = anVisitorManager.GetTotalById(anZone.ZoneTypeId);
                allCountList.Add(anZone);
            }
            LoadTotalVisitorById(allCountList);

        }
        int i = 0;
        public void LoadTotalVisitorById(List<ZoneType> allCountList)
        {
            zoneWiseVisitorListView.Items.Clear();
            foreach (ZoneType andZoneType in allCountList)
            {
                ListViewItem item = new ListViewItem(andZoneType.ZoneName);
                item.SubItems.Add(andZoneType.TotalVisitor.ToString());
                item.Tag = andZoneType;
                zoneWiseVisitorListView.Items.Add(item);
               i= i + andZoneType.TotalVisitor;
            }
            i = anVisitorManager.GetTotalVisitor();
            totalVisitorTextbox.Text = i.ToString();
            
        }
    }
}
