using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IAdminService:IGenericService<Admin>
    {
        List<Admin> GetAdmins();
        Admin GetByAdminUserName(string username);
    }
}
