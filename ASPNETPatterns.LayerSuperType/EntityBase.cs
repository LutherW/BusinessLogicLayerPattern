using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETPatterns.LayerSuperType
{
    public abstract class EntityBase<T>
    {
        private T _id;
        private IList<string> _brokenRules = new List<string>();
        private bool _idHasBeenSet = false;

        public EntityBase() { }

        public EntityBase(T id) 
        {
            _id = id;
        }

        public T Id
        {
            get;
            set 
            {
                if (_idHasBeenSet)
                {
                    ThrowExceptionIfOverwrittingAnId();
                }
                _id = value;
                _idHasBeenSet = true;
            }
        }

        private void ThrowExceptionIfOverwrittingAnId() 
        {
            throw new ApplicationException("不能改变一个实体的ID");
        }

        public bool IsValid() 
        {
            ClearCollectionOfBrokenRules();
            CheckBrokenRules();

            return _brokenRules.Count == 0;
        }

        private void ClearCollectionOfBrokenRules() 
        {
            _brokenRules.Clear();
        }

        protected abstract void CheckBrokenRules();

        public IEnumerable<string> GetBrokenRules() 
        {
            return _brokenRules;
        }

        protected void AddBrokenRule(string brokenRule) 
        {
            _brokenRules.Add(brokenRule);
        }
    }
}
