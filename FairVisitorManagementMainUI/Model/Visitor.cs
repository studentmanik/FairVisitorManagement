using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairVisitorManagementMainUI.Model
{
    public class Visitor
    {
        private int visitorId;
        private String visitorName;
        private string visitorEmail;
        private string visitorContactNumber;
        public int VisitorId
        {
            set { visitorId = value; }
            get { return visitorId; }
        }
        public string VisitorName
        {
            set { visitorName = value; }
            get { return visitorName; }
        }

        public string VisitorEmail
        {
            get { return visitorEmail; }
            set { visitorEmail = value; }
        } 

        public string VisitorContactNumber
        {
            get { return visitorContactNumber; }
            set { visitorContactNumber = value; }
        }
        
    }
}
