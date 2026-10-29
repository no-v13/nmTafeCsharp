using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recruiteAssessment
{
    public class Jobs
    {
        public string jobTitle {  get; set; }
        public int totalSalary { get; set; }
        public DateTime jobDate { get; set; }

        public bool isDone = false;
        public Contractor assignContractor {  get; set; }
        
       
        public Jobs() 
        {
            
        }

        public Jobs(string jobTitle, int totalSalary, DateTime jobDate)
        {
            this.jobTitle = jobTitle;
            this.totalSalary = totalSalary;
            this.jobDate = jobDate;
            bool isDone = false; //? 
        }

        public override string ToString()
        {
            return $"{jobTitle},{totalSalary},{jobDate},{isDone}";
        }
    }
}
