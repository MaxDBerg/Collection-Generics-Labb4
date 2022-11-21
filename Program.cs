using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionGenericsLabb4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoStack();

            DoList();
        }
        static void DoList()
        {
            var person1 = new Employee(1, "Max", "Male", 50000);
            var person2 = new Employee(2, "Anas", "Male", 60000);
            var person3 = new Employee(3, "Tobias", "Male", 40000);
            var person4 = new Employee(4, "Anna", "Female", 30000);
            var person5 = new Employee(5, "Reidar", "Male", 20000);

            var employees = new List<Employee>();
            employees.Add(person1); employees.Add(person2); employees.Add(person3); employees.Add(person4); employees.Add(person5);

            Console.WriteLine("---------------------------------");
            DoesEmployeeExistList(person2, employees);

            Console.WriteLine("---------------------------------");
            FindFirstMaleList(employees);

            Console.WriteLine("---------------------------------");
            FindAllMalesList(employees);
        }
        static void FindAllMalesList(List<Employee> employees)
        {
            List<Employee> allMaleEmployees = employees.FindAll(emplo => emplo._gender.Contains("Male"));
            foreach (Employee maleEmployee in allMaleEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", maleEmployee._id, maleEmployee._name, maleEmployee._gender, maleEmployee._salary);
            }
        }
        static void DoesEmployeeExistList(Employee person2, List<Employee> employees)
        {
            if (employees.Contains(person2))
            {
                Console.WriteLine("{0} exists in the list", person2._name);
            }
            else Console.WriteLine("{0} does not exist in the list", person2._name);
        }
        static void FindFirstMaleList(List<Employee> employees)
        {
            Employee firstMaleEmployee = employees.Find(employee => employee._gender.Contains("Male"));
            Console.WriteLine("ID = {0}, Name = {1}, Gender = {2}, Salary = {3}", firstMaleEmployee._id, firstMaleEmployee._name, firstMaleEmployee._gender, firstMaleEmployee._salary);

        }
        static void PrintStack(Stack employees)
        {
            foreach (Employee employee in employees)
            {
                Console.WriteLine("{0} - {1} - {2} - {3}", employee._id, employee._name, employee._gender, employee._salary);
                Console.WriteLine("Items left in the stack - {0}", employees.Count);
            }
        }
        static void PopOutStack(Stack employees)
        {
            do
            {
                Employee employee = (Employee)employees.Pop();
                Console.WriteLine("{0} - {1} - {2} - {3}", employee._id, employee._name, employee._gender, employee._salary);
                Console.WriteLine("Items left in the stack - {0}", employees.Count); 
            } while (employees.Count != 0);
        }
        static void PeekAtStack(Stack employees)
        {

            for (int i = 0; i < 2; i++)
            {
                Employee employee = (Employee)employees.Peek();
                Console.WriteLine("{0} - {1} - {2} - {3}", employee._id, employee._name, employee._gender, employee._salary);
                Console.WriteLine("Items left in the stack - {0}", employees.Count); 
            }
            
        }
        static bool SearchInStack(Stack employees)
        {
            foreach (Employee employee in employees)
            {
                if (employee._id == 3)
                {
                    return true;
                }
            }
            return false;
        }
        static void DoStack()
        {
            var person1 = new Employee(1, "Max", "Male", 50000);
            var person2 = new Employee(2, "Anas", "Male", 60000);
            var person3 = new Employee(3, "Tobias", "Male", 40000);
            var person4 = new Employee(4, "Anna", "Female", 30000);
            var person5 = new Employee(5, "Reidar", "Male", 20000);

            var employees = new Stack();
            for (int i = 1; i < 3; i++)
            {
                employees.Push(person1);
                employees.Push(person2);
                employees.Push(person3);
                employees.Push(person4);
                employees.Push(person5);

                if (i == 1)
                {
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Retrieved using foreach");
                    PrintStack(employees);
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Retrieved using the Pop method");
                    PopOutStack(employees);
                }
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Retrieved using the Peek method");
            PeekAtStack(employees);
            Console.WriteLine("---------------------------------");

            bool SuccessfulSearch = SearchInStack(employees);

            if (SuccessfulSearch)
            {
                Console.WriteLine("Object3 is in stack");
            }
        }

    }
}
