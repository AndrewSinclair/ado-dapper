using System;
using System.Text;

namespace Ado
{
    class Person
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ContactInfo ContactInfo { get; set; }

        public Person(Guid id, string name, ContactInfo contactInfo)
        {
            this.Id = id;
            this.Name = name;
            this.ContactInfo = contactInfo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Person Id:\t{0}\n");
            sb.Append("Name:\t{1}\n");
            sb.Append("ContactInfo:\t{2}\n");

            return String.Format(sb.ToString(), Id, Name, ContactInfo);
        }
    }
}
