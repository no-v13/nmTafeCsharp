using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recruiteAssessment
{
    public class Contractor
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public DateTime startdate { get; set; }

        public Contractor(){ }
        public Contractor(string firstName, string lastName, DateTime startdate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.startdate = startdate;
        }

        public override string ToString() 
        {
            return $"{firstName},{lastName},{startdate}";
        }

    }
}
