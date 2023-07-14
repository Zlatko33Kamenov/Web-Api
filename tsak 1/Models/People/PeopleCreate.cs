using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tsak_1.Models.People
{
    public class PeopleCreate
    {
        //public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = null;
        [Required]
        public uint Age { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
    }
}
