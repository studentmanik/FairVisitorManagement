using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairVisitorManagementMainUI.Model
{
    public class ZoneType
    {
        private int zoneTypeId;
        private String zoneName;
        private int totalVisitor;
        public int ZoneTypeId
        {
            set { zoneTypeId = value; }
            get { return zoneTypeId; }
        }
        public string ZoneName
        {
            set { zoneName = value; }
            get { return zoneName; }
        }

        public int TotalVisitor
        {
            get { return totalVisitor; }
            set { totalVisitor = value; }
        }
    }
}
