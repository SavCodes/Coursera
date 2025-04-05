namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Kid kid = new Kid();

            kid.PrintMessage();

            Kid disobedientKid = new Disobedient();

            (disobedientKid as Disobedient).PrintMessage();

            Kid smartKid = new Smart();

            (smartKid as Smart).PrintMessage();

        }
    }
}
