namespace ConsoleApp2;
/// <summary>
/// The <c>Student2</c> class provide methods 
/// for showing Person info.
/// </summary>
public class Person1
{
    /// <summary>
    /// Person FirstName
    /// </summary>
    public string FirstName { get; set; }
    /// <summary>
    /// Person LastName
    /// </summary>
    public string LastName { get; set; }
    /// <summary>
    /// Person Age
    /// </summary>
    public int Age { get; set; }

    /// <summary>
    /// Showing Persons info
    /// </summary>
    /// <param name="person1">
    /// info about Person
    /// </param>
    /// <returns>
    /// Info about Person
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// if <paramref name="person1"/> is null.
    /// </exception>
    public static string Print(Person1 person1)
    {
        if (person1 == null)
            throw new ArgumentNullException();

        return person1.FirstName + " " + person1.LastName + " " + person1.Age;
    }

    /// <summary>
    /// Showing Persons Name
    /// </summary>
    /// <param name="person1">
    /// name of Person
    /// </param>
    /// <returns>
    /// name of Person
    /// </returns>
    /// <exception cref="ArgumentNullException">
    /// if <paramref name="person1"/> is null.
    /// </exception>
    public static string GetName(Person1 person1)
    {
        if (person1 == null)
            throw new ArgumentNullException();

        return person1.FirstName;
    }
}
