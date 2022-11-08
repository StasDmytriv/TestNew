namespace ConsoleApp2;
/// <summary>
/// The <c>Student2</c> class provide methods 
/// for showing students marks.
/// </summary>
public class Student2
{
    /// <summary>
    /// Student FirstName
    /// </summary>
    public string FirstName { get; set; }
    /// <summary>
    /// Student LastName
    /// </summary>
    public string LastName { get; set; }
    /// <summary>
    /// Student Age
    /// </summary>
    public int Age { get; set; }

   /// <summary>
   /// Get Students marks.
   /// </summary>
   /// <param name="student2">
   /// info about student
   /// </param>
   /// <returns>
   /// Marks
   /// </returns>
   /// <exception cref="ArgumentNullException">
   /// if <paramref name="student2"/> is null.
   /// </exception>
    public static List<int> GetStudentsMarks(Student2 student2)
    {
        if (student2 == null)
            throw new ArgumentNullException();
        return new List<int> { 1, 23, 3, 3, 4, 5, 6, 7, 9 };
    }
}
