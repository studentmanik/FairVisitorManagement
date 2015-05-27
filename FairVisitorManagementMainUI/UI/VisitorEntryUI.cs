using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using FairVisitorManagementMainUI.BLL;
using FairVisitorManagementMainUI.Model;

namespace FairVisitorManagementMainUI.UI
{
    public partial class VisitorEntryUI : Form
    {
        public VisitorEntryUI()
        {
            InitializeComponent();
        }
        VisitorManager anVisitorManager = new VisitorManager();

        private void VisitorEntryUI_Load(object sender, EventArgs e)
        {
            LoadCheckedListBox();
        }

        
        private void LoadCheckedListBox()
        {
            
            checkedListBox1.Items.Clear();
            checkedListBox1.CheckOnClick = true;

            List<ZoneType> zoneTypes = anVisitorManager.GetAllZoneType();

            foreach (ZoneType zoneType in zoneTypes)
            {
                if (zoneType != null)
                {
                    checkedListBox1.Items.Add(zoneType, true);
                }
            }
            checkedListBox1.DisplayMember = "ZoneName";
        }

        private void visitorSaveButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && emailTextBox.Text != "" && contactNumberTextBox3.Text!="")
            {
                
            
            Visitor aVisitor=new Visitor();
            aVisitor.VisitorName = nameTextBox.Text;
            aVisitor.VisitorEmail = emailTextBox.Text;
            aVisitor.VisitorContactNumber = contactNumberTextBox3.Text;
            int VisitorId=anVisitorManager.InsartVisitor(aVisitor);

         

            foreach (int indexChecked in checkedListBox1.CheckedIndices)
            {
                ZoneType anZoneType = (ZoneType)checkedListBox1.Items[indexChecked];

                anVisitorManager.MakeRealation(VisitorId, anZoneType.ZoneTypeId);
             
            }
            ClearTextBox();
            MessageBox.Show("Success");
            LoadCheckedListBox();
            nameTextBox.BackColor = Color.White;
            emailTextBox.BackColor = Color.White;
            contactNumberTextBox3.BackColor = Color.White;
            }
            else
            {
                if (nameTextBox.Text == "")
                {
                    nameTextBox.BackColor = Color.Red;
                }
                else
                {
                    nameTextBox.BackColor = Color.White;
                }

                if (emailTextBox.Text == "")
                {
                    emailTextBox.BackColor = Color.Red;
                }
                else
                {
                    emailTextBox.BackColor = Color.White;
                }
                if (contactNumberTextBox3.Text == "")
                {
                    contactNumberTextBox3.BackColor = Color.Red;
                }
                else
                {
                    contactNumberTextBox3.BackColor = Color.White;
                } 
            }
             
        }

        private void ClearTextBox()
        {
            nameTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            contactNumberTextBox3.Text = string.Empty;
        }
    }
}
