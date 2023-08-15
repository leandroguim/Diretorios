

string path = @"c:\temp\myfolder";

try
{
    IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FOLDERS:");
    foreach (string s in folders)
    {
        Console.WriteLine(s); 
    }

    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FILES:");
    foreach (string s in files)
    {
        Console.WriteLine(s);
    }
}
catch(IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}