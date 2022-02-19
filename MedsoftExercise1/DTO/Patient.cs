using System;
using System.Collections.Generic;
using System.Text;

namespace MedsoftExercise1.DTO
{
    class Patient
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirthday { get; set; }
        public int GenderID { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
