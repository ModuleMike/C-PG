using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactClass
{
    internal class Contact
    {
        public string FirstName { get; set; }
        public string LastName  { get; set; }

        private DateTime _birthDate;
        public DateTime Birthdate
        {
            get { return _birthDate; }
            set
            {
                if (value > DateTime.Today)
                {
                    _birthDate = DateTime.Today;
                }
                else
                {
                    _birthDate = value;
                }
            }
        }
        public string NameLastFisrt
        {
            get { return $"{LastName}, {FirstName}"; }
        }
        public int AgeYears
        {
            get
            {
                int age = DateTime.Today.Year - Birthdate.Year;

                if (Birthdate.AddYears(age) > DateTime.Today)
                {
                    age--;
                }
                return age;
            }
        }
    }
}
