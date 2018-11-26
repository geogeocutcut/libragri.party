
using libragri.core.common;
using System;

namespace libragri.party.model
{
    public class Role:Entity<string>
    {
        public string Id
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                    _id = Guid.NewGuid().ToString();
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public virtual string Code{get;set;}
        public virtual string Name{get;set;}

        public override string GetId()
        {
            return Id;
        }
    }
}
