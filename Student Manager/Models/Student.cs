using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Models
{
    public class StudentList
    {
        public string Name { get; set; }
        public string Year { get; set; }
        public string Image { get; set; }
    }
    public class StudenListManager
    {
        public static List<StudentList> GetBooks()
        {
            var studentList = new List<StudentList>();
            studentList.Add(new StudentList { Name = "Nguyen Quang Huy", Year = "2002", Image = "Assets/1.jfif" });
            studentList.Add(new StudentList { Name = "Nguyen Quang Huy", Year = "2002", Image = "Assets/1.jfif" });
            studentList.Add(new StudentList { Name = "Nguyen Quang Huy", Year = "2001", Image = "Assets/1.jfif" });
            studentList.Add(new StudentList { Name = "Nguyen Quang Huy", Year = "2001", Image = "Assets/1.jfif" });

            return studentList;
        }
    }
}
