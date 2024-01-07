using System.Text;

namespace ClassLibrary
{
    public class Person
    {
        protected string Name;
        protected string Surname;
        protected DateTime BirthDate;

        public Person()
        {
            Name = string.Empty;
            Surname = string.Empty;
            BirthDate = DateTime.MinValue;
        }

        public Person(string name, string surname, DateTime birthDate)
        {
            Name = name;
            Surname = surname;
            BirthDate = birthDate;
        }

        public Person(Person person)
        {
            Name = person.Name;
            Surname = person.Surname;
            BirthDate = person.BirthDate;
        }

        public virtual string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: "); sb.Append(Name);
            sb.Append(", Surname: "); sb.Append(Surname);
            sb.Append(", Birth date: "); sb.Append(BirthDate.ToShortDateString());
            return sb.ToString();
        }
    }
}