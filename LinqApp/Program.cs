using LinqApp;

try
{
    FileReader.Read(@"..\file1.txt");

    Console.WriteLine("Data from file:");
    foreach (string line in FileReader.DataList)
        Console.WriteLine(line);

    Console.WriteLine("\nResult:");

    Console.WriteLine((from line in FileReader.DataList select line.Split(' ').Average(d => int.Parse(d))).Sum());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
            