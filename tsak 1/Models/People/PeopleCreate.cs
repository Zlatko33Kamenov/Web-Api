using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tsak_1.Models.People
{
    public class PeopleCreate
    {
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public uint Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
