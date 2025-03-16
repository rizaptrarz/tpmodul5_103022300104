using tpmodul5_103022300104;

class Program
{
    static void Main()
    {
        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Riza"); 


        DataGeneric<long> data = new DataGeneric<long>(103022300104);
        data.PrintData();
    }
}
