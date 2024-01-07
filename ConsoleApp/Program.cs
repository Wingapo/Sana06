using ClassLibrary;

internal class Program
{
    private static void Main(string[] args)
    {
        Person[] people = new Person[5];
        people[0] = new Person("name1", "surname1", new DateTime(1982, 3, 20));
        people[1] = new Entrant("name2", "surname2", new DateTime(2006, 2, 11), 190, 11.2f, "school #1");
        people[2] = new Student("name3", "surname3", new DateTime(2004, 3, 20), 2, "group", "fac", "ihe");
        people[3] = new Teacher("name4", "surname4", new DateTime(1979, 8, 5), "pos", "depart", "ihe");
        people[4] = new LibraryUser("name5", "surname5", new DateTime(2001, 12, 10), 6349458, new DateTime(2024, 1, 1), 100);

        foreach (Person person in people)
        {
            Console.WriteLine(person.ShowInfo());
        }
    }
}