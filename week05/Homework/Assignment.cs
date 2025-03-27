public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Public method to get the summary
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

    // Getter for student name (to access in derived classes)
    public string GetStudentName()
    {
        return _studentName;
    }
}
