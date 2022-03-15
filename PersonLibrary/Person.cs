namespace PersonLibrary
{
    [Serializable]
    public class Person
    {
        public string Name;
        private int _age;
        private string _nickname;

        public Person() { }
        public Person(string name, int age, string nickname)
        {
            Name = name;
            _age = age;
            _nickname = nickname;
        }

        public static string SayHello() => "Hello";

        public string SaySometingStupid(string somethingStupid) => $"Hey! I'm {Name} and {somethingStupid}!";

        private void IncreaseAge() => _age++;

        private static int GetCountOfTeef() => 32;
    }
}