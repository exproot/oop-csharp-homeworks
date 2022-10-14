/**
    * OOP Hafta 2 Ödevi
    * @author Ertan Yağmur
    * see {@link https://github.com/exproot}
    * 10/14/2022
*/

namespace HelloWorld
{
    class Employee{
        public int Id { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee ertan = new Employee();
            Employee yagmur = new Employee();
            ertan.Id = 29;
            yagmur.Id = 0;
            
            EmployeeManager man = new EmployeeManager();

            man.Add(ertan);
            man.Add(yagmur);

            man.Remove(25);

            man.ReadList();
            
        }
    }
}