#nullable enable //I added this line to disable nullable warnings but DateTime and decimal are still nullable,
                  // so I had to put ? to make them nullable, Why this line is not working?
using BLL.DAL;

namespace BLL.Models
{
    public class StudentModel
    {
        public Student Record { get; set; }

        public string Name => Record.Name;

        public string Surname => Record.Surname;

        public DateTime? BirthDate => Record.BirthDate;

        public decimal? Gpa => Record.Gpa;
    }
}
