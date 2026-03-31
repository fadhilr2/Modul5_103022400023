class PemrosesData
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
        PemrosesData data = new PemrosesData();
        // 103022 40 00 23
        double a = int.Parse(Console.ReadLine());
        double b = int.Parse(Console.ReadLine());
        double c = int.Parse(Console.ReadLine());
        dynamic res = data.DapatkanNilaiTerbesar<double>(a, b, c);
        Console.WriteLine();
        Console.WriteLine(res);
    }
}