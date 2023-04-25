namespace task1;

//Entity
public class Employee
{
    private int _employeeId;
    private string _firstName;
    private string _lastName;
    private string _post;
    private Grade _grade;

    public Employee(int employeeId, string firstName, string lastName, string post, Grade grade)
    {
        _employeeId = employeeId;
        _firstName = firstName;
        _lastName = lastName;
        _post = post;
        _grade = grade;
    }

    public void GradeUp(string post)
    {
        SetPost(post);
        _grade = _grade.GradeUp();
    }
            
    public void SetPost(string post) => _post = post;

    public new string ToString() => $"Employee {_lastName} {_firstName}; post: {_post}, grade: {_grade.ToInt()}";
}