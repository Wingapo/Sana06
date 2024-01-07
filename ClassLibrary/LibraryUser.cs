using System.Text;

namespace ClassLibrary
{
    public class LibraryUser : Person
    {
        protected int TicketNumber;
        DateTime IssueDate;
        double MonthlyFee;

        public LibraryUser() : base() 
        {
            TicketNumber = 0;
            IssueDate = DateTime.MinValue;
            MonthlyFee = 0;
        }

        public LibraryUser(
            string name,
            string surname,
            DateTime birthDate,
            int ticketNumber, 
            DateTime issueDate, 
            double monthlyFee) : base(name, surname, birthDate)
        {
            TicketNumber = ticketNumber;
            IssueDate = issueDate;
            MonthlyFee = monthlyFee;
        }

        public LibraryUser (
            Person person,
            int ticketNumber,
            DateTime issueDate, 
            double monthlyFee) : base(person)
        {
            TicketNumber = ticketNumber;
            IssueDate = issueDate;
            MonthlyFee = monthlyFee;
        }

        public override string ShowInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ShowInfo());
            sb.Append(", Ticket number: "); sb.Append(TicketNumber);
            sb.Append(", Issue date: "); sb.Append(IssueDate.ToShortDateString());
            sb.Append(", Monthly fee: "); sb.Append(MonthlyFee);
            
            return sb.ToString();
        }
    }
}
