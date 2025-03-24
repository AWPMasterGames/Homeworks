using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontr.Classes
{
    public class User
    {
        public string Photo { get; set; }
        public string Name { get; set; }

        public string Country { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }

        public string Post { get; set; }
        public string WorkTime { get; set; }
        public string Organization { get; set; }
        public string Duties { get; set; }

        public string Institution { get; set; }
        public string Specialization { get; set; }
        public string Faculty { get; set; }
        public string FinishedEducationDate { get; set; }

        public string ToSave()
        {
            return $"{Photo}\n{Name}\n{Email}\n{Phone}\n{DateOfBirth}\n{Specialization}\n{Faculty}\n{Post}\n{WorkTime}\n{Duties}";
        }
    }
}
