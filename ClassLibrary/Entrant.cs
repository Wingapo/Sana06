using System.Text;

namespace ClassLibrary
{
    public class Entrant : Person
    {
        byte EIT_Score;
        float EducationDocumentPoints;
        string GeneralEducationalInstitution;

        public Entrant() : base() 
        {
            EIT_Score = 0;
            EducationDocumentPoints = 0;
            GeneralEducationalInstitution = string.Empty;
        }


        public Entrant(
            string name, 
            string surname, 
            DateTime birthDate,
            byte eIT_Score,
            float educationDocumentPoints,
            string generalEducationalInstitution) : base(name, surname, birthDate)
        {
            EIT_Score = eIT_Score;
            EducationDocumentPoints = educationDocumentPoints;
            GeneralEducationalInstitution = generalEducationalInstitution;
        }

        public Entrant( 
            Person person,
            byte eIT_Score,
            float educationDocumentPoints,
            string generalEducationalInstitution) : base (person)
        {
            EIT_Score = eIT_Score;
            EducationDocumentPoints = educationDocumentPoints;
            GeneralEducationalInstitution = generalEducationalInstitution;
        }

        public override string ShowInfo()
        { 
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ShowInfo());
            sb.Append(", EIT score: "); sb.Append(EIT_Score);
            sb.Append(", Education document points: ");
            sb.Append(EducationDocumentPoints);
            sb.Append(", General education institution: ");
            sb.Append(GeneralEducationalInstitution);

            return sb.ToString();
        }
    }
}
