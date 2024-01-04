using System.Text;

namespace RecordType;

public record Person(string FullName, DateOnly DateOfBirth)
{
    // protected Person(Person oldPerson)
    // {
    //     FullName = oldPerson.FullName;
    //     DateOfBirth = oldPerson.DateOfBirth;
    // }

    protected virtual bool PrintMembers(StringBuilder builder)
    {
        builder.Append($"FullName is: {FullName}");
        builder.Append($"DateOfBirth is: {DateOfBirth}");
        return true;
    }
}

public record struct PersonAsStruct(string FullName, DateOnly DateOfBirth);

public class PersonAsClass(string FullName, DateOnly DateOfBirth);
