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
        // plural : [jobs / contractors] : A list that hold items
        // singular:[job/conractor] : One specific item from the  list
        // new :    [newjob/newContr-] :to the memory
        public Handler() { }

        // property (encapsulate)
        public List<Jobs> Jobs { get { return jobs; } } // also List
        public List<Contractor> Contractors { get { return contractors; } }  // also List



        public void AddContractor(string FirstName, string LastName, DateTime StartDate)
        {
            Contractor newContractors = new Contractor(FirstName, LastName, StartDate);
            contractors.Add(newContractors);
        }

        public void DelContractor(Contractor contractor)
        {
            
            if (contractor != null) 
            {
               contractors.Remove(contractor); //contractors] : A list that hold items / [conractor] : One specific item from the  list

            }

        }

        public void AddJob(string JobTitle, string totalSalary, DateTime JobDate)
        {
            Jobs newjob = new Jobs(JobTitle, totalSalary, JobDate);
            jobs.Add(newjob);
        }

        public void DelJob(Jobs job)
        {
            if(jobs != null)
            {
                jobs.Remove(job);
            }
        }
    }   
}
