

using libragri.core.common;
using System;

namespace libragri.party.model
{
    public class City : Entity<string>
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
        public string Label { get; set; }

        public string Code_INSEE_2C { get; set; }
        public string Code_INSEE_3C { get; set; }
        public override string GetId()
        {
            return Id;
        }
    }
}
