using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks.Sweeft.EFCore.Models
{
    public class TeacherPupil
    {
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        public int PupilID { get; set; }
        public Pupil Pupil { get; set; }
    }
}
