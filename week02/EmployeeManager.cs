/**
    * OOP Hafta 2 Ödevi
    * @author Ertan Yağmur
    * see {@link https://github.com/exproot}
    * 10/14/2022
*/

namespace HelloWorld
{
    class EmployeeManager
    {
        List<Employee> employees;

        public EmployeeManager(){
            employees = new List<Employee>();
        }

        public void Add(Employee a){
            employees.Add(a);
        }

        public void Remove(int id){
            List<int> ids = new List<int>();
            for(int i = 0; i <employees.Count(); i++){
                ids.Add(employees[i].Id);
                if(employees[i].Id == id){
                    System.Console.WriteLine("IDs matched, removing the employee...");
                    employees.RemoveAt(i);
                }
            }
            if(!ids.Contains(id)){
                System.Console.WriteLine("ID didn't match!");
            }
        }

        public void ReadList(){
            System.Console.WriteLine("Registered Employee's IDs : ");
            foreach(var item in employees){
                System.Console.WriteLine(item.Id.ToString());
                
            }
        }

 
    }
}