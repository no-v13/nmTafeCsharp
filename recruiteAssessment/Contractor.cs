using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recruiteAssessment
{
    public class Contractor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Startdate { get; set; }

        public Contractor(){ }
        public Contractor(string FirstName, string LastName, DateTime Startdate)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Startdate = Startdate;
        }

        public override string ToString() 
        {
            return $"{FirstName},{LastName},{Startdate}";
        }

    }
}
