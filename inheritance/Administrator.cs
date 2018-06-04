using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance {
	class Administrator : Employee {

		public Manager AssistantTo { get; set; }

		public override string Print() {
			return base.Print() + $"\nIsAdministrator \nIs assistant to: {AssistantTo.Name}";
		}
	}
}
