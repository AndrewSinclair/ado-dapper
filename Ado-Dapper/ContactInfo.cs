using System;

namespace Ado
{
    class ContactInfo
    {
        public Guid Id { get; set; }

        public ContactInfo(Guid id)
        {
            this.Id = id;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
