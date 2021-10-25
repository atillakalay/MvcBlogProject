using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
  public  class AdminManager:IAdminService
  {
      private IAdminDal _adminDal;

      public AdminManager(IAdminDal adminDal)
      {
          _adminDal = adminDal;
      }

      public void Add(Admin admin)
      {
          _adminDal.Add(admin);
      }

      public void Delete(Admin admin)
      {
          _adminDal.Delete(admin);
      }

      public List<Admin> GetAdmins()
      {
          return _adminDal.List();
      }

      public List<Admin> GetAll()
      {
          throw new NotImplementedException();
      }

      public Admin GetById(int id)
      {
          return _adminDal.Get(a => a.AdminId == id);
      }

      public Admin GetByAdminUserName(string username)
      {
          return _adminDal.Get(x => x.UserName == username);
        }

      public void Update(Admin admin)
      {
          _adminDal.Update(admin);
      }

      public void Delete(int id)
      {
          throw new NotImplementedException();
      }
  }
}
