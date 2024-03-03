using BAD.DataAccess;
using BAD.DataProcess;
var watch = System.Diagnostics.Stopwatch.StartNew();


FileReader file_reader =  new FileReader();
const string file_name = "C:\\Users\\lomac\\Desktop\\10m.txt";
DataProces data_process = new DataProces(file_reader.ReadFileByName(file_name));

Console.WriteLine("MIN - "+data_process.ReturnMinValue());
Console.WriteLine("MAX - " + data_process.ReturnMaxValue());
Console.WriteLine("AVG - " + data_process.ReturnAverageValue());


watch.Stop();
Console.WriteLine(watch.ElapsedMilliseconds);