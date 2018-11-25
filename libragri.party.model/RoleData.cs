
using libragri.core.common;

namespace libragri.party.model
{
    public class RoleData:Entity<string>
    {
        public virtual string Code{get;set;}
        public virtual string Name{get;set;}
    }
}
