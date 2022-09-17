namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;

            Employee employee1 = new Employee("Ivan", "Kryzhanivsky", Position.Developer, Experience.Junior);
            Employee employee2 = new Employee("Pavel", "Morozov", Position.Manager);

            Console.WriteLine(employee1.ToString());
            Console.WriteLine(employee2.ToString());
        }
    }
}