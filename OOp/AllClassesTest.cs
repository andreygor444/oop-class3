using NUnit.Framework;
using static NUnit.Framework.Assert;

namespace task1;

public class AllClassesTest
{
    [Test]
    public void GradeManagerTest()
    {
        That(GradeManager.GetGradeByPost("cleaner").ToInt(), Is.EqualTo(1));
        That(GradeManager.GetGradeByPost("senior intern").ToInt(), Is.EqualTo(12));
        That(GradeManager.GetGradeByPost("software developer").ToInt(), Is.EqualTo(14));
        That(GradeManager.GetGradeByPost("owner").ToInt(), Is.EqualTo(25));
        That(GradeManager.GetPostByGrade(Grade.FromInt(1))[0], Is.EqualTo("cleaner"));
        That(GradeManager.GetPostByGrade(Grade.FromInt(12))[0], Is.EqualTo("senior intern"));
        That(GradeManager.GetPostByGrade(Grade.FromInt(14))[0], Is.EqualTo("software developer"));
        That(GradeManager.GetPostByGrade(Grade.FromInt(25))[0], Is.EqualTo("owner"));
    }
}