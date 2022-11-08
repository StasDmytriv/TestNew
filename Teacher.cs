namespace ConsoleApp2;

public class Teacher
{
    public event ExamDelegate examEvent;

    public void ExamTeacher(string task)
    {
        if(examEvent != null)
            examEvent(task);
    }
}
