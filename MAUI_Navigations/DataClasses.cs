using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Navigations
{
    public class ContactDetail
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
    }

    public class ContactDetails : List<ContactDetail>
    {
        public ContactDetails()
        {
            Add(new ContactDetail() { ContactId=1,Name="Mahesh"});
            Add(new ContactDetail() { ContactId = 2, Name = "Tejas" });
        }
    }
}
