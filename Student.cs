namespace ConsoleApp1;

public class Student : IComparable
{ 
    public string FirstName { get; set; }

    public string LastName { get; set; }

    public DateTime DateTime { get; set; }

    public StudentCard StudentCard { get; set; }


    public int CompareTo(object? obj)
    {
        return LastName.CompareTo(((Student)obj).LastName);
    }

    public override string ToString()
    {
        return $"{FirstName}\t{LastName}\t{DateTime.ToShortDateString()}\t{StudentCard}"; 
    }

    public object Clone()
    {
        Student clone = this.MemberwiseClone() as Student;
        clone.StudentCard= this.StudentCard.Clone() as StudentCard;
        //clone.StudentCard = new StudentCard
        //{
        //    Number = this.StudentCard.Number,
        //    Seria = this.StudentCard.Seria
        //};
        return clone;
    }


}
