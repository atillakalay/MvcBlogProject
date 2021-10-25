
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IContactService:IGenericService<Contact>
    {
        Contact FindContact(int id);
    }
}
