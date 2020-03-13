using System;
using System.Collections.Generic;
using System.Linq;

namespace Srp
{
    public class WorkReport
    {



        /*
        Problems With This Code

         We can add even more features in this class, like the Load or UploadToCloud methods because they 
           are all related to our WorkReport, but, just because we can doesn’t mean we have to do it.
           
           Right now, there is one issue with the WorkReport class.
           
           It has more than one responsibility.
           
           Its job is not only to keep track of our work report entries but to save the entire work report to a file.
           This means that we are violating the SRP and our class has more than one reason to change in the future.
           
           The first reason to change this class is if we want to modify the way we keep track of our entries. 
           But if we want to save a file in a different way, that is entirely a new reason to change our class. And imagine
           what this class would look like if we added additional functionalities to it. We would have so many unrelated code parts in a single class.  
         */



        private readonly List<WorkReportEntry> _entries;

        public WorkReport()
        {
            _entries = new List<WorkReportEntry>();
        }

        public void AddEntry(WorkReportEntry entry) => _entries.Add(entry);

        public void RemoveEntryAt(int index) => _entries.RemoveAt(index);

        public override string ToString() =>
            string.Join(Environment.NewLine, _entries.Select(x => $"Code: {x.ProjectCode}, Name: {x.ProjectName}, Hours: {x.SpentHours}"));



        /*
        In this case, we have separated our responsibilities in two classes. The WorkReport 
        class is now responsible for keeping track of work report entries and the FileSaver class is responsible for saving a file.

        Having done this, we have separated the concerns of each class thus making 
        them more readable and maintainable as well. As a result, if we want to 
        change how we save a file, we only have one reason to do that and one place 
        to do it, which is the FileSaver class.
        */

    }
}

