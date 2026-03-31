class SimpleDataBase<T>
{
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void AddNewData(T d)
    {
        storedData.Add(d);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++) { 
            Console.WriteLine("Data " + (i + 1) + " berisi: " + storedData[i] + ", " +
                "yang disimpan pada waktu UTC: " + inputDates[i]);            
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        //103022400023
        SimpleDataBase<double> data = new SimpleDataBase<double>();
        Console.Write("Masukkan Jumlah Data: ");
        int jumlahData = int.Parse(Console.ReadLine());
        for (int i = 0; i < jumlahData; i++)
        {
            Console.Write("Masukkan Data " + (i + 1) + " : ");
            double d = double.Parse(Console.ReadLine());
            data.AddNewData(d);
        }
        Console.WriteLine();
        data.PrintAllData();
    }
}