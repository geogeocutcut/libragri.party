
using libragri.core.common;
using System;
using System.Collections.Generic;

namespace libragri.party.model
{
    public class Party:Entity<string>
    {
        public string Id {
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

        public string Name {get;set;}

        public string Identifier { get; set; }
        
        public IList<Address> Addresses { get; set; }

        public PartyData()
        {
            Addresses = new List<Address>();
        }

        public override string GetId()
        {
            return Id;
        }
    }
}
