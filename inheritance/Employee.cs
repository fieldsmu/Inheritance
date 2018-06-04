using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance {
	class Employee {

		public string Name { get; set; }
		public string Position { get; set; }
		public Manager Manager { get; set; }
		public decimal Salary { get; set; }
		public int VacationDays { get; set; }

		public static int Counter { get; set; }

		public Employee() {
			++Counter;
		}

		public virtual string Print() {
			return $"\nName: {Name} \nSalary: {string.Format("{0:C}", Salary)} \nVacation Days: {VacationDays}";
		}
		 public void ChangeSalary(int amount) {
			Salary += amount;
		}
	}
}
