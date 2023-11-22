using NguyenTac1_Single;

internal class Program
{
    private static void Main(string[] args)
    {
        List<IEmployee> list = new List<IEmployee>();
        list.Add(new CasualEmployee());
        list.Add(new ContractualEmployee());
        foreach (var item in list)
        {
            item.GetEmployeeDetail();
        }
    }
}