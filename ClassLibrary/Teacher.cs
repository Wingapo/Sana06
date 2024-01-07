using System.Text;

namespace ClassLibrary
{
    public class Teacher : Person
    {
        protected string Position;
        protected string Department;
        protected string IHE;


        public Teacher() : base()
        {
            Position = string.Empty;
            Department = string.Empty;
            IHE = string.Empty;
        }
        public Teacher(
            string name,
            string surname,
            DateTime birthDate,
            string position,
            string department,
            string iHE) : base(name, surname, birthDate)
        {
            Position = position;
            Department = department;
            IHE = iHE;
        }
        public Teacher(
            Person person,
            string position,
            string department,
            string iHE) : base(person)
        {
            Position = position;
            Department = department;
            IHE = iHE;
        }

        public override string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ShowInfo());
            sb.Append(", Position: "); sb.Append(Position);
            sb.Append(", Department: "); sb.Append(Department);
            sb.Append(", IHE: "); sb.Append(IHE);

            return sb.ToString();
        }
    }
}
