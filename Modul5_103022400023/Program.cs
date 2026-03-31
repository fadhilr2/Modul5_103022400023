
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

﻿class PemrosesData
{
    public dynamic DapatkanNilaiTerbesar<T>(T a, T b, T c)
    {
        dynamic m = (dynamic) a;
        dynamic btemp = (dynamic) b;
        dynamic ctemp = (dynamic) c;

        if(btemp > m)
        {
            m = btemp;
        }
        if (ctemp > m)
        {
            m = ctemp;
        }

        return m;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        PemrosesData data2 = new PemrosesData();
        // 103022 40 00 23
        Console.Write("Masukkan NIM 1: ");
        double a = int.Parse(Console.ReadLine());
        Console.Write("Masukkan NIM 2: ");

        double b = int.Parse(Console.ReadLine());
        Console.Write("Masukkan NIM 3: ");

        double c = int.Parse(Console.ReadLine());
        dynamic res = data2.DapatkanNilaiTerbesar<double>(a, b, c);
        Console.WriteLine();
        Console.Write("Nilai terbesar: ");
        Console.WriteLine(res);
        Console.WriteLine();

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