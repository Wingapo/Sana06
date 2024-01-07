using System.Text;

namespace ClassLibrary
{
    public class Student : Person
    {
        protected byte Course;
        protected string Group;
        protected string Faculty;
        protected string IHE;

        public Student() : base() 
        {
            Course = 0;
            Group = string.Empty;
            Faculty = string.Empty;
            IHE = string.Empty;
        }

        public Student(
            string name,
            string surname,
            DateTime birthDate,
            byte course,
            string group,
            string faculty,
            string iHE) : base(name, surname, birthDate)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            IHE = iHE;
        }

        public Student (
            Person person,
            byte course,
            string group,
            string faculty,
            string iHE) : base(person)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            IHE = iHE;
        }

        public override string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ShowInfo());
            sb.Append(", Course: "); sb.Append(Course);
            sb.Append(", Group: "); sb.Append(Group);
            sb.Append(", Faculty: "); sb.Append(Faculty);
            sb.Append(", IHE: "); sb.Append(IHE);

            return sb.ToString();
        }
    }
}
