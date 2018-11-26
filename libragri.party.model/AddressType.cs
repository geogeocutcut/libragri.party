using libragri.core.common;
using System;

namespace libragri.party.model
{
    public class AddressType:Entity<string>
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

        public string Code { get; set; }
        public string Label { get; set; }

        public override string GetId()
        {
            throw new System.NotImplementedException();
        }
    }
}
