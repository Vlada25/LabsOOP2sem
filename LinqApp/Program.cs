using LinqApp;

try
{
    FileReader.Read(@"..\file1.txt");

    Console.WriteLine("Data from file:");
    foreach (string line in FileReader.DataList)
        Console.WriteLine(line);

    Console.WriteLine("\nResult:");

    var result = from line in FileReader.DataList
                 from digit in line.Split(' ').OfType<double>()
                 select digit;

    foreach (double r in result)
        Console.WriteLine(r);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
            