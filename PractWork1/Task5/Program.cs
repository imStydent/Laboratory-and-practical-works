Console.WriteLine("Введите путь к папке");
string path = Console.ReadLine();

DirectoryInfo directory = new(path);
FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);
directory.Create();
foreach (var file in files)
{
    if (directory.Name != directory.LastAccessTime.Date.ToShortDateString().ToString())
    {
        directory.Create(); 
    }
}
