/**
* 命名空间: Apps.DAL
* 功 能： N/A
* 类 名： SysUserRepository
* 创建时间： 2017/1/5 22:19:05 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Linq;
using Apps.Models;
using System.Data;
using Apps.IDAL;
using System.Data.Entity;

namespace Apps.DAL
{
    public class SysUserRepository : ISysUserRepository, IDisposable
    {

        public IQueryable<SysUser> GetList(DBContainer db)
        {
            IQueryable<SysUser> list = db.SysUser.AsQueryable();
            return list;
        }

        public int Create(SysUser entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.SysUser.Add(entity);
                return db.SaveChanges();
            }
        }

        public int Delete(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysUser entity = db.SysUser.SingleOrDefault(a => a.Id == id);
                if (entity != null)
                {

                    db.SysUser.Remove(entity);
                }
                return db.SaveChanges();
            }
        }

        public void Delete(DBContainer db, string[] deleteCollection)
        {
            IQueryable<SysUser> collection = from f in db.SysUser
                                             where deleteCollection.Contains(f.Id)
                                             select f;
            foreach (var deleteItem in collection)
            {
                db.SysUser.Remove(deleteItem);
            }
        }

        public int Edit(SysUser entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.SysUser.Attach(entity);
                //db.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
                db.Entry<SysUser>(entity).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }

        public SysUser GetById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysUser.SingleOrDefault(a => a.Id == id);
            }
        }

        public SysUser GetByUserNmae(string username)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysUser.SingleOrDefault(a => a.UserName == username);
            }
        }

        public bool IsExist(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysUser entity = GetById(id);
                if (entity != null)
                    return true;
                return false;
            }
        }

        public bool CheckExist(string username)
        {
            using (DBContainer db = new DBContainer())
            {
                SysUser entity = GetByUserNmae(username);
                if (entity != null)
                    return true;
                return false;
            }
        }

        public void Dispose()
        {

        }

        public IQueryable<P_Sys_GetRoleByUserId_Result> GetRoleByUserId(DBContainer db, string userId)
        {
            return db.P_Sys_GetRoleByUserId(userId).AsQueryable();
        }

        public void UpdateSysRoleSysUser(string userId, string[] roleIds)
        {
            using (DBContainer db = new DBContainer())
            {
                db.P_Sys_DeleteSysRoleSysUserByUserId(userId);
                foreach (string roleid in roleIds)
                {
                    if (!string.IsNullOrWhiteSpace(roleid))
                    {
                        db.P_Sys_UpdateSysRoleSysUser(roleid, userId);
                    }
                }
                db.SaveChanges();
            }
        }
    }
}

