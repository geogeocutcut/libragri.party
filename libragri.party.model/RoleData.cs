
using libragri.core.common;

namespace libragri.party.model
{
    public class RoleData:Entity<string>
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
