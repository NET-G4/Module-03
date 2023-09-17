using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Davlatshokh_lesson01_hw
{
    internal class fine
    {
        public string PassportID { get; set; }
        public string TechnicalId { get; set; }
        public string CarNumber { get; set; }

        public fine(string passportid, string technicalid,string carnumber)
            {
            PassportID = passportid;
            TechnicalId = technicalid;
            CarNumber = carnumber;
            }
        public void passportID(string passportid)
        {
            if (PassportID != null) { }

        }

    }
}
