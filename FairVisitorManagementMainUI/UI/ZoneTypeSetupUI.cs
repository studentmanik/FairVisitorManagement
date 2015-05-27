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
    public partial class ZoneTypeSetupUI : Form
    {
        public ZoneTypeSetupUI()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        VisitorManager anVisitorManager=new VisitorManager();
        private void zoneTypeSaveButton_Click(object sender, EventArgs e)
        {
            if (ZoneTypeNameTextBox.Text!="")
            {
                ZoneType anZoneType=new ZoneType();
                anZoneType.ZoneName = ZoneTypeNameTextBox.Text;
                MessageBox.Show(anVisitorManager.SetupZoneType(anZoneType));
                List<ZoneType> zoneTypes = anVisitorManager.GetAllZoneType();
                LoadZoneType(zoneTypes);
                ZoneTypeNameTextBox.Text = string.Empty;
                ZoneTypeNameTextBox.BackColor = Color.White;
            }
            else
            {
                ZoneTypeNameTextBox.BackColor=Color.Red;
            }
            
        }

        private void ZoneTypeSetupUI_Load(object sender, EventArgs e)
        {
            List<ZoneType> zoneTypes = anVisitorManager.GetAllZoneType();
            LoadZoneType(zoneTypes);
        }

        private void LoadZoneType(List<ZoneType> zoneTypes)
        {
            zoneTypeListView.Items.Clear();
            foreach (ZoneType anZoneType in zoneTypes)
            {
                ListViewItem item = new ListViewItem(anZoneType.ZoneTypeId.ToString());
                item.SubItems.Add(anZoneType.ZoneName);
                item.Tag = anZoneType;
                zoneTypeListView.Items.Add(item);
            }
        }

       
    }
}
