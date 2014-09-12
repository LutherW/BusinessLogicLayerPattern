using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.LayerSuperType
{
    public class Customer : EntityBase<long>
    {
        public Customer() { }

        public Customer(long id)
            :base(id)
        {}

        public string FirstName { get; set; }

        public string LastName { get; set; }

        protected override void CheckBrokenRules()
        {
            if (string.IsNullOrEmpty(FirstName))
            {
                base.AddBrokenRule("You must supply a first name");
            }
            if (string.IsNullOrEmpty(LastName))
            {
                base.AddBrokenRule("You must supply a last name");
            }
        }
    }
}
