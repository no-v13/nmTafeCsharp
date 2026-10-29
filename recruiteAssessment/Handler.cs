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
        private List<Jobs> jobList = new List<Jobs>(); 
        private List<Contractor> contractorList = new List<Contractor>();
       

        // property (encapsulate)
        public List<Jobs> JobList { get { return jobList; } } 
        public List<Contractor> ContractorList { get { return contractorList; } } 



        public void AddContractor(string FirstName, string LastName, DateTime StartDate)
        {
            Contractor newContractor = new Contractor(FirstName, LastName, StartDate);
            contractorList.Add(newContractor);
        }

        public void DelContractor(Contractor contractor)
        {
            
            if (contractor != null) 
            {
                contractorList.Remove(contractor); /// [conractor] : One specific item from the  list

            }

        }

        public void AddJob(string JobTitle, int totalSalary, DateTime JobDate)
        {
            Jobs newJob = new Jobs(JobTitle, totalSalary, JobDate);
            jobList.Add(newJob);
        }

        public void DelJob(Jobs job)
        {
            if(job != null) // 왜 잡인가 잡리스트가 아니라
            {
                jobList.Remove(job);
            }
        }
    }   
}
