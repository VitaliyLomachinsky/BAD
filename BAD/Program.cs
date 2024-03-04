using BAD.DataAccess;
using BAD.DataProcess;
var watch = System.Diagnostics.Stopwatch.StartNew();


FileReader file_reader =  new FileReader();
const string file_name = "C:\\Users\\lomac\\Desktop\\10m.txt";
string[] data_from_file = file_reader.ReadFileByName(file_name);

DataAnalysis data_process = new DataAnalysis(data_from_file);
data_process.PrintHandledFileInfo();

watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);