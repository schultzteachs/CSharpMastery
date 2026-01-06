using Newtonsoft.Json;


var currentDirectory = Directory.GetCurrentDirectory();
var storesDirectory = Path.Combine(currentDirectory, "stores");
Directory.CreateDirectory("IcancreateFoldersinCsharp");     
var salesTotalDir = Path.Combine(currentDirectory, "IcanCreateFoldersinCsharp");

var salesFiles = FindFiles(storesDirectory);

File.WriteAllText(Path.Combine(salesTotalDir, "HereIsMyNewFile.txt"), String.Empty);

IEnumerable<string> FindFiles(string folderName)
{
    List<string> salesFiles = new List<string>();

    var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

    foreach (var file in foundFiles)
    {
        var extension = Path.GetExtension(file);
        if (extension == ".json")
        {
            salesFiles.Add(file);
        }
    }

    return salesFiles;
}

double CalculateSalesTotal(IEnumerable<string> salesFiles)
{
    double salesTotal = 0;

    foreach (var file in salesFiles)
    {
        string salesJson = File.ReadAllText(file);
        SalesData? salesData = JsonConvert.DeserializeObject<SalesData?>(salesJson);
        salesTotal += salesData?.Total ?? 0;
        // The elvis operator (?.) checks for is an object is null before accessing a property or method on that object.
        // The "null-coalescing operator" (??) provides a default value if the value on the left is null and it checks for the value on the right instead and returns that. 
    }
    return salesTotal;
}
record SalesData (double Total);

