using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace recruiteAssessment
{
    class Handler
    {
        private List<Jobs> jobs = new List<Jobs>();
        private List<Contractor> contractors = new List<Contractor>();

        public Handler() { }


        public List<Jobs> Jobs {get { return jobs;}}
        public List<Contractor> Contractors { get { return contractors; } }

        public void AddContractor(string FirstName, string LastName, DateTime StartDate)
        {
           Contractor newContractors = new Contractor(FirstName,LastName,StartDate);
           contractors.Add(newContractors);
        }
        public void AddJob(string JobTitle, DateTime JobDate)
        {
            Jobs newjob = new Jobs(JobTitle,JobDate); // 쌰갈 여기말이야 개 빡치네
            jobs.Add(newjob);
        }
    }
}
