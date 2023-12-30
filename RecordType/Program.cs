using RecordType;

var nick = new Person("Nick Chapsas", new DateOnly(1993, 6, 9));
var nick2 = new Person("Nick Chapsas", new DateOnly(1993, 6, 9));

var (a, b) = nick;

Console.WriteLine($"{a} {b}");

var nickButOlder = nick with { DateOfBirth = new DateOnly(1991, 2, 4) };

var nickAsClass = new PersonAsClass("Nick Chapsas", new DateOnly(1993, 6, 9));

