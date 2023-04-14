using System.IO;

string fpath = @"file1.txt";
FileStream fs = new FileStream(fpath,FileMode.OpenOrCreate,FileAccess.ReadWrite);
StreamWriter sw = new StreamWriter(fs);
StreamReader sr = new StreamReader(fs);
string str = "pooja";
sw.WriteLine(str);
string txt;
while((txt = sr.ReadLine()) != null)
{
    Console.WriteLine(sr.ReadLine());
}
Console.WriteLine(fs.Length);
sw.Close();
fs.Close();
