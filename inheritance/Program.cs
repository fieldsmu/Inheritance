using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance {
	class Program {
		static void Main(string[] args) {

			Manager Greg = new Manager() {
				Name = "Doud, Greg",
				Salary = 80000,
				Position = "Web Development Manager",
				VacationDays = 14,
				PurchaseAuth = 99.99M
			};

			Employee Marcus = new Employee() {
				Name = "Fields, Marcus",
				Salary = 60000,
				Position = "Senior Web Developer",
				VacationDays = 14,
				Manager = Greg
			};

			Administrator Nancy = new Administrator() {
				Name = "Harville, Nancy",
				Salary = 50000,
				Position = "Web Development Administrator",
				VacationDays = 10,
				Manager = Greg,
				AssistantTo = Greg
			};

			List<Employee> employees = new List<Employee>();
			employees.Add(Greg);
			employees.Add(Marcus);
			employees.Add(Nancy);

			foreach (Employee employee in employees) {
				Console.WriteLine(employee.Print());
			}
		}
	}
}
