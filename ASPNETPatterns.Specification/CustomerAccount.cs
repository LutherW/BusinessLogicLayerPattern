using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.Specification
{
    public class CustomerAccount
    {
        private ISpecification<CustomerAccount> _hasReachedRentalThreshold;
        private ISpecification<CustomerAccount> _customerAccountIsActive;
        private ISpecification<CustomerAccount> _customerAccountHasLateFees;
        private ISpecification<CustomerAccount> _customerAccountIsVip;

        public CustomerAccount() 
        {
            _hasReachedRentalThreshold = new HasReachedRentalThresholdSpecification();
            _customerAccountIsActive = new CustomerAccountStillActiveSpecification();
            _customerAccountHasLateFees = new CustomerAccountHasLateFeesSpecification();
            _customerAccountIsVip = new CustomerAccountIsVipSpecification();
        }

        public decimal NumberOfRentalThisMonth { get; set; }

        public bool AccountAcitve { get; set; }

        public decimal LateFees { get; set; }

        public bool IsVip { get; set; }

        public bool CanRent() 
        {
            ISpecification<CustomerAccount> canRent = _customerAccountIsActive
                .And(_hasReachedRentalThreshold.Not())
                .And(_customerAccountHasLateFees.Not())
                .Or(_customerAccountIsVip);
            return canRent.IsSatiesfiedBy(this);
        }
    }
}
