using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouldntCommitSadge
{
    public class ScoolClassRepo
    {
        public List<SchoolClass> SchoolClasses { get; set; }=new List<SchoolClass>()
        {
                new()
                {
                    Evfolyam="10. a",
                    BefizetendoOsztalypenz=7000
                },
                new()
                {
                    Evfolyam="10. b",
                    BefizetendoOsztalypenz=8000
                }
        };

        public ScoolClassRepo() { }

        public string MostPaydSchoolClass()
        {
            string output = string.Empty;
            if (SchoolClasses.Count > 0)
            {
                int mostPays = 0;
                List<SchoolClass> mostPayingClasses=new List<SchoolClass>();
                foreach(SchoolClass schoolClass in SchoolClasses)
                {
                    if (schoolClass.BefizetendoOsztalypenz > mostPays)
                    {
                        mostPays = schoolClass.BefizetendoOsztalypenz;
                        mostPayingClasses.Clear();
                        mostPayingClasses.Add(schoolClass);
                    }
                    else if(schoolClass.BefizetendoOsztalypenz == mostPays)
                    {
                        mostPayingClasses.Add(schoolClass);
                    }
                }

                if (mostPayingClasses.Count == 1)
                {
                    return mostPayingClasses[0].Evfolyam;
                }

                output = mostPayingClasses[0].Evfolyam;
                for(int i=1; i<mostPayingClasses.Count; i++)
                {
                    output += ", "+mostPayingClasses[i].Evfolyam;
                }
            }
            return output;
        }
    }
}
