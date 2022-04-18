using LinqApp;

try
{
    FileReader.Read(@"..\file1.txt");

    Console.WriteLine("Data from file:");
    foreach (string line in FileReader.DataList)
        Console.WriteLine(line);

    Console.WriteLine("\nResult:");

    List<string> data = FileReader.DataList;

    var result = from line in FileReader.DataList
                select line.Split(' ').Average(d => int.Parse(d));

    foreach (double r in result)
        Console.WriteLine(r);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
            