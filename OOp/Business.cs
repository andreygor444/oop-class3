namespace task1;

public record Event(Employee Employee);

public interface IObservable
{
    public void Subscribe(IObserver observer);
}

public interface IObserver
{
    public void HandleNotification(Event e);
}

public class Logger : IObserver
{
    public void HandleNotification(Event e)
    {
        Console.WriteLine(e.Employee.ToString());
    }
}

//service
public class Business : IObservable
{
    private List<IObserver> _observersList = new();

    public void Run(Office office)
    {
        office.HireAnEmployee("Ivan", "Petrov", "intern");
        Notify(new Event(office.GetEmployee(0)));
        office.HireAnEmployee("Petr", "Ivanov", "cleaner");
        Notify(new Event(office.GetEmployee(1)));
        office.HireAnEmployee("Ivan", "Petrov", "software developer");
        Notify(new Event(office.GetEmployee(2)));

        office.GetEmployee(0).GradeUp("manager");
        Notify(new Event(office.GetEmployee(0)));
        office.GetEmployee(1).GradeUp("senior cleaner");
        Notify(new Event(office.GetEmployee(1)));
        office.GetEmployee(2).GradeUp("senior software developer");
        Notify(new Event(office.GetEmployee(2)));
        Console.WriteLine(office.GetEmployee(0).ToString());
        Console.WriteLine(office.GetEmployee(1).ToString());
        Console.WriteLine(office.GetEmployee(2).ToString());
    }

    public void Subscribe(IObserver observer)
    {
        _observersList.Add(observer);
    }

    private void Notify(Event e)
    {
        foreach (var observer in _observersList)
        {
            observer.HandleNotification(e);
        }
    }
}