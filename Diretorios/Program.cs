

string path = @"c:\temp\myfolder";

try
{
    IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FOLDERS:");
    foreach (string s in folders)
    {
        Console.WriteLine(s); 
    }
}
catch(IOException e)
{
    Console.WriteLine("An error occurred");
    Console.WriteLine(e.Message);
}