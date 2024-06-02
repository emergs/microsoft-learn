var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");
var salesTotalDir = Path.Combine(currentDirectory, "salesTotalDir");

Directory.CreateDirectory(salesTotalDir);
File.WriteAllText(Path.Combine(salesTotalDir, "totals.txt"), String.Empty);

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        if (file.EndsWith("sales.json")) 
        { 
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

var salesFiles = FindFiles(storesDirectory);
