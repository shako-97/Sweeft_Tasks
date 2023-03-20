using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Sweeft.EFCore.Models
{
    public class Pupil
    {
        public int PupilID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Class { get; set; }
        public ICollection<TeacherPupil> TeacherPupils { get; set; }
    }
}
