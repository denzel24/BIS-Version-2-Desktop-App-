using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ResidenceInfo
    {

        //Residence Informations
        public string resFullName { get; set; }
        public string resBdate { get; set; }
        public string resBplace { get; set; }
        public string resAddress { get; set; }
        public string resPurok { get; set; }
        public string resGender { get; set; }
        public string resReligion { get; set; }
        public string resCitizenship { get; set; }
        public string resCivilStatus { get; set; }
        public string resBloodType { get; set; }
        public string resContact { get; set; }
        public string resStartedLiving { get; set; }
        public string resId { get; set; }

        //Registered Voter Informations
        public string VIN { get; set; }
        public string PrecinctNo { get; set; }
        public string Address { get; set; }

        //PWD Informations
        public string pwdControlNo { get; set; }
        public string dateRegistered { get; set; }
        public string disabilityType { get; set; }
        public string causeOfDisability { get; set; }


        //Senior Citizen Informations
        public string SenControlNo { get; set; }

    }
}
