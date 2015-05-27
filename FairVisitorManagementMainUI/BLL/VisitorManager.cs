using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FairVisitorManagementMainUI.DAL;
using FairVisitorManagementMainUI.Model;

namespace FairVisitorManagementMainUI.BLL
{
    class VisitorManager
    {
        VisitorGateWay visitorGateWay=new VisitorGateWay();
        string msg = "";
        public string SetupZoneType(ZoneType anZoneType)
        {
           
            if (visitorGateWay.SetupZoneType(anZoneType)>0)
            {
                msg = "Success full";
            }
            else
            {
                msg = "fail";
            }
            return msg;
        }

        public List<ZoneType> GetAllZoneType()
        {
            return visitorGateWay.GetAllZoneType();
        }

        public int InsartVisitor(Visitor aVisitor)
        {
            return visitorGateWay.InsartVisitor(aVisitor);
        }

        public void MakeRealation(int visitorId, int zoneTypeId)
        {

            visitorGateWay.MakeRealation(visitorId, zoneTypeId);
        }

        public List<Visitor> GetVisitorByZoneType(int zoneTypeId)
        {
            return visitorGateWay.GetVisitorByZoneType(zoneTypeId);
            
        }


        public int GetTotalById(int zoneId)
        {
            return visitorGateWay.GetTotalById(zoneId);
        }

        public int GetTotalVisitor()
        {
            return visitorGateWay.GetTotalVisitor();
        }
    }
}
