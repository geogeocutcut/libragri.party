
using libragri.core.common;
using System;

namespace libragri.party.model
{
    public class PartyRole:Entity<string>
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

        public Role role { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ThruDate { get; set; }

        public override string GetId()
        {
            return Id;
        }
    }
}
