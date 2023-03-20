using Tasks.Sweeft.EFCore.Models;

namespace Tasks.Sweeft.EFCore
{
    public class DbHelper
    {
        public static Teacher[] GetAllTeachersByStudent(string studentName)
        {
            using (SchoolDbContext db = new())
            {
                return (from t in db.Teachers
                        join tp in db.TeacherPupils on t.TeacherID equals tp.TeacherID
                        join p in db.Pupils on tp.PupilID equals p.PupilID
                        where p.FirstName == studentName
                        select t).ToArray();
            }
        }
    }
}