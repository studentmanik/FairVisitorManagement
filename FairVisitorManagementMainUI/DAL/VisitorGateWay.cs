using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairVisitorManagementMainUI.Model;
using ExcelLibrary.SpreadSheet;
using ExcelLibrary.CompoundDocumentFormat;

namespace FairVisitorManagementMainUI.DAL
{
    class VisitorGateWay
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["VisitorInfoConString"].ConnectionString;
        public int SetupZoneType(ZoneType anZoneType)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            string query = string.Format("INSERT INTO ZoneTypeTable VALUES('" + anZoneType.ZoneName + "')");
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();

            return rowAffected;

        }

        public List<ZoneType> GetAllZoneType()
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM ZoneTypeTable";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            List<ZoneType> zoneTypelist = new List<ZoneType>();

            while (reader.Read())
            {
                ZoneType anZoneType = new ZoneType();
                anZoneType.ZoneTypeId = Convert.ToInt32(reader["ZoneTypeId"].ToString());
                anZoneType.ZoneName = reader["ZoneType"].ToString();

                zoneTypelist.Add(anZoneType);
            }
            reader.Close();
            connection.Close();

            return zoneTypelist;
        }

        public int InsartVisitor(Visitor aVisitor)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = string.Format("INSERT INTO VisitorInfoTable VALUES('" + aVisitor.VisitorName + "','" + aVisitor.VisitorEmail + "','" + aVisitor.VisitorContactNumber + "')");
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();
            int visitorId=0;
            if (rowAffected>0)
            {
                string query2 = "SELECT TOP 1 VisitorId FROM VisitorInfoTable ORDER BY VisitorId DESC";

                SqlCommand command2 = new SqlCommand(query2, connection);

                connection.Open();

                SqlDataReader reader = command2.ExecuteReader();

                

                while (reader.Read())
                {

                    visitorId = Convert.ToInt32(reader["VisitorId"].ToString());



                }
                reader.Close();
                connection.Close();
            }
            

            return visitorId;
        }

        public void MakeRealation(int visitorId, int zoneTypeId)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = string.Format("INSERT INTO VisitorAndZoneName VALUES('" + visitorId + "','" + zoneTypeId + "')");
            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            int rowAffected = command.ExecuteNonQuery();

            connection.Close();
            

        }

        public List<Visitor> GetVisitorByZoneType(int zoneTypeId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query2 = string.Format("SELECT VisitorInfoTable.VisitorId,VisitorInfoTable.VisitorName,VisitorInfoTable.VisitorEmail,VisitorInfoTable.VisitorContactNumber FROM VisitorAndZoneName INNER JOIN VisitorInfoTable ON VisitorInfoTable.VisitorId=VisitorAndZoneName.VisitorId AND VisitorAndZoneName.ZoneTypeId="+zoneTypeId);

            SqlCommand command2 = new SqlCommand(query2, connection);

            connection.Open();

            SqlDataReader reader = command2.ExecuteReader();
            List<Visitor> visitorByZone=new List<Visitor>();


            while (reader.Read())
            {
                Visitor anVisitor=new Visitor();
                anVisitor.VisitorId = Convert.ToInt32(reader["VisitorId"].ToString());
                anVisitor.VisitorName = reader["VisitorName"].ToString();
                anVisitor.VisitorEmail = reader["VisitorEmail"].ToString();
                anVisitor.VisitorContactNumber = reader["VisitorContactNumber"].ToString();
            visitorByZone.Add(anVisitor);
            }
            reader.Close();
            connection.Close();
            return visitorByZone;
        }


        public int GetTotalById(int zoneId)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query2 = string.Format("SELECT COUNT(ZoneTypeId) FROM VisitorAndZoneName WHERE ZoneTypeId=" + zoneId);

            SqlCommand command2 = new SqlCommand(query2, connection);
            int total=0;
            connection.Open();
            SqlDataReader reader = command2.ExecuteReader();

            while (reader.Read())
            {
                total = Convert.ToInt32(reader[""].ToString());
               
            }
            connection.Close();
            return total;
        }

        public int GetTotalVisitor()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query2 = string.Format("SELECT COUNT(VisitorId) FROM VisitorInfoTable");

            SqlCommand command2 = new SqlCommand(query2, connection);
            int totalVisitor=0;
            connection.Open();
            SqlDataReader reader = command2.ExecuteReader();

            while (reader.Read())
            {
                totalVisitor = Convert.ToInt32(reader[""].ToString());

            }
            connection.Close();
            return totalVisitor;
        }
    }
}
