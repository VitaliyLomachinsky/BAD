using BAD.DataAccess;
using BAD.DataProcess;
var watch = System.Diagnostics.Stopwatch.StartNew();


FileReader file_reader = new FileReader();
string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
string file_name = System.IO.Path.Combine(desktopPath, "10m.txt");


DataAnalysis data_process = new DataAnalysis(file_reader.ReadFileByName(file_name));
data_process.PrintHandledFileInfo();


watch.Stop();
Console.WriteLine("\n"+"Work in milliseconds: "+watch.ElapsedMilliseconds);