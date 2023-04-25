namespace task1;

public class Office
{
    private class EmployeeIdGenerator
    {
        private static int _currentMaxId = 0;

        public static int GetNextId()
        {
            return _currentMaxId++;
        }
    }
    private Dictionary<int,Employee> _employees;

    public Office() => _employees = new Dictionary<int, Employee>();

    public int HireAnEmployee(string firstName, string lastName, string post)
    {
        int newEmployeeId = EmployeeIdGenerator.GetNextId();
        Grade grade = GradeManager.GetGradeByPost(post);
        _employees[newEmployeeId] = new Employee(newEmployeeId, firstName, lastName, post, grade);
        return newEmployeeId;
    }

    public Employee GetEmployee(int employeeId) => _employees[employeeId];
}