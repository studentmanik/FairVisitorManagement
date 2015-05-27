using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FairVisitorManagementMainUI.BLL;
using FairVisitorManagementMainUI.Model;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.CompoundDocumentFormat;

namespace FairVisitorManagementMainUI.UI
{
    public partial class ZoneSpecificVisitorReportUI : Form
    {
        public ZoneSpecificVisitorReportUI()
        {
            InitializeComponent();
        }
        VisitorManager anVisitorManager = new VisitorManager();
        private void ZoneSpecificVisitorReportUI_Load(object sender, EventArgs e)
        {
            List<ZoneType> zoneTypes = anVisitorManager.GetAllZoneType();
            foreach (ZoneType zoneType in zoneTypes)
            {
                zoneComboBox.Items.Add(zoneType);
               }
            zoneComboBox.DisplayMember = "zoneName";
        }

        private void zoneShowButton_Click(object sender, EventArgs e)
        {
            
            ZoneType aZoneType = (ZoneType) zoneComboBox.SelectedItem;
            if (aZoneType!=null)
            {
                List<Visitor> anVisitorslist = anVisitorManager.GetVisitorByZoneType(aZoneType.ZoneTypeId);
                LoadVisitorById(anVisitorslist);
            }
            else
            {
                MessageBox.Show("Select Zone");
                
            }
          

            
            
        }
       
            public void LoadVisitorById(List<Visitor> anVisitorslist)
        {

            zoneShowListView.Items.Clear();
                int i = 0;
            foreach (var anVisitor in anVisitorslist)
            {
                ListViewItem item = new ListViewItem(anVisitor.VisitorName);
                item.SubItems.Add(anVisitor.VisitorEmail);
                item.SubItems.Add(anVisitor.VisitorContactNumber);
                item.Tag = anVisitor;
                zoneShowListView.Items.Add(item);
                i++;
            }
                totalTextBox.Text = i.ToString();
                zoneShowListView.Tag = anVisitorslist;
        }

            private void exportToExcelButton_Click(object sender, EventArgs e)
            {
                List<Visitor> anVisitorslist = (List<Visitor>)zoneShowListView.Tag;
                if (anVisitorslist!=null)
                {
                    
               
               
               ZoneType aZoneType = (ZoneType)zoneComboBox.SelectedItem;

                int i = 1;
                Workbook workbook = new Workbook();
                Worksheet worksheet = new Worksheet("First Sheet");
                worksheet.Cells[0, 0] = new Cell("Visitor Name");
                worksheet.Cells[0, 1] = new Cell("Visitor Email");
                worksheet.Cells[0, 2] = new Cell("Visitor Contac tNumber");
                foreach (Visitor aVisitor in anVisitorslist)
                {
                    worksheet.Cells[i, 0] = new Cell(aVisitor.VisitorName);
                    worksheet.Cells[i, 1] = new Cell(aVisitor.VisitorEmail);
                    worksheet.Cells[i, 2] = new Cell(aVisitor.VisitorContactNumber);
                    i++;
                }
                worksheet.Cells[i, 0] = new Cell("Total Visitor");
                worksheet.Cells[i, 1] = new Cell(i-1);
              
                worksheet.Cells.ColumnWidth[0, 1] = 3000;
                workbook.Worksheets.Add(worksheet);
                string file = aZoneType.ZoneName + " VisitorInfo.xls";
                if (File.Exists(file))
                {
                    try
                    {
                        File.Delete(file);
                        workbook.Save(file);
                        MessageBox.Show("Export Success");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Close the Excel file");
                    }


                }
                else
                {
                    workbook.Save(file);
                    MessageBox.Show("Export Success");
                }


                }
                else
                {
                    MessageBox.Show("Select Zone");
                }

            }


    }
}
