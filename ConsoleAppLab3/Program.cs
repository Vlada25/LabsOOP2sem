using PersonLibrary;
using System.Reflection;
using System.Xml.Serialization;

Type myType = typeof(Person);

Console.WriteLine($" Type: {myType}");

// Reading values of private fields
Person person = new Person("Tom", 32, "skunk");

FieldInfo? fieldInt = typeof(Person).GetField("_age", BindingFlags.Instance | BindingFlags.NonPublic);
FieldInfo? fieldStr = typeof(Person).GetField("_nickname", BindingFlags.Instance | BindingFlags.NonPublic);

int? age = (int?)fieldInt?.GetValue(person);
string? nickname = (string?)fieldStr?.GetValue(person);

Console.WriteLine("\n Values of private fields:");
Console.WriteLine($" - Age: {age}");
Console.WriteLine($" - Nickname: {nickname}");


// Private methods
Console.WriteLine("\n All private methods:");

foreach (MemberInfo method in myType.GetMethods(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static))
{
	Console.WriteLine($" - {method}");
}


// Public methods
Console.WriteLine("\n All public methods:");

foreach (MemberInfo member in myType.GetMethods())
{
	Console.WriteLine($" - {member.Name}");
}


// Private fields
Console.WriteLine("\n All private fields:");

foreach (MemberInfo field in myType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static))
{
	Console.WriteLine($" - {field}");
}

// Serialization

try
{
	XmlSerializer xmlSerializer = new XmlSerializer(typeof(Person));

	using (FileStream fs = new FileStream(@"E:\Лабы\2курс\ООП\LabsOOP2sem\ConsoleAppLab3\person.xml", FileMode.OpenOrCreate))
	{
		xmlSerializer.Serialize(fs, person);

		Console.WriteLine("\nObject has been serialized");
	}
}
catch (Exception ex)
{
	Console.WriteLine(ex.Message);
}

