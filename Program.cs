StreamReader addresses = File.OpenText("C:/Users/black/source/repos/csharp-lista-indirizzi/addresses.csv");

string heading = addresses.ReadLine();

while (!addresses.EndOfStream)
{
    string row = addresses.ReadLine();
    Console.WriteLine(row);
    string[] data = row.Split(",");

    string name = data[0];
    string surname = data[1];
    string street = data[2];
    string city = data[3];
    string province = data[4];
    string zip = data[5];
}