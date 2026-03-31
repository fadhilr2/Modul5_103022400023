class PemrosesData
{
    public void DapatkanNilaiTerbesar<T>(T a, T b, T c)
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

        Console.WriteLine(m);
    }

}

class Program
{
    public static void Main(string[] args)
    {
        PemrosesData data = new PemrosesData();
        // 103022 40 00 23
        data.DapatkanNilaiTerbesar<double>(10, 30, 22);
    }
}