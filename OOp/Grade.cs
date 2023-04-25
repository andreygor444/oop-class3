namespace task1;

class GradeManager
{
    private static readonly Dictionary<int, List<string>> GradeDict = new Dictionary<int, List<string>>
    {
        { 1, new List<string> { "cleaner" } },
        { 2, new List<string> { "middle cleaner" } },
        { 3, new List<string> { "senior cleaner" } },
        { 4, new List<string> { "post4" } },
        { 5, new List<string> { "post5" } },
        { 6, new List<string> { "post6" } },
        { 7, new List<string> { "post7" } },
        { 8, new List<string> { "post8" } },
        { 9, new List<string> { "post9" } },
        { 10, new List<string> { "intern" } },
        { 11, new List<string> { "middle intern" } },
        { 12, new List<string> { "senior intern" } },
        { 13, new List<string> { "post13" } },
        { 14, new List<string> { "software developer" } },
        { 15, new List<string> { "middle software developer" } },
        { 16, new List<string> { "senior software developer" } },
        { 17, new List<string> { "team lead" } },
        { 18, new List<string> { "post18" } },
        { 19, new List<string> { "post19" } },
        { 20, new List<string> { "post20" } },
        { 21, new List<string> { "post21" } },
        { 22, new List<string> { "manager" } },
        { 23, new List<string> { "middle manager" } },
        { 24, new List<string> { "senior manager" } },
        { 25, new List<string> { "owner" } }
    };

    public static List<string> GetPostByGrade(Grade grade)
    {
        if (!GradeDict.ContainsKey(grade.ToInt()))
            throw new ArgumentException("Invalid Grade");
        return GradeDict[grade.ToInt()];
    }

    public static Grade GetGradeByPost(string post)
    {
        foreach (var kv in GradeDict)
        {
            if (kv.Value.Contains(post)) return Grade.FromInt(kv.Key);
        }

        throw new ArgumentException("Unknown post");
    }
}

//Value class
public class Grade
{
    private readonly int _value;

    private Grade(int value)
    {
        if (value < 1 || value > 25)
        {
            throw new ArgumentOutOfRangeException(nameof(value), "Value must be integer between 1 and 25");
        }

        _value = value;
    }

    public static Grade FromInt(int value) => new Grade(value);

    public Grade GradeUp() => new Grade(_value + 1);

    public int ToInt() => _value;
}