using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance {
	class Manager : Employee {

		public decimal PurchaseAuth { get; set; }

		public override string Print() {
			return base.Print() + $"\nIsManager \nPurchase Authorization: {PurchaseAuth}";
		}
	}
}
