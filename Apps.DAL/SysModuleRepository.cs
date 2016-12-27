﻿
using Apps.IDAL;
using Apps.Models;
/**
* 命名空间: Apps.DAL
* 功 能： N/A
* 类 名： SysModuleRepository
* 创建时间： 2016/12/27 22:24:33 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apps.DAL
{
    public class SysModuleRepository : IDisposable, ISysModuleRepository
    {
        public IQueryable<SysModule> GetList(DBContainer db)
        {
            IQueryable<SysModule> list = db.SysModule.AsQueryable();
            return list;
        }

        public IQueryable<SysModule> GetModuleBySystem(DBContainer db, string parentId)
        {
            return db.SysModule.Where(a => a.ParentId == parentId).AsQueryable();
        }

        public int Create(SysModule entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.SysModule.Add(entity);
                return db.SaveChanges();
            }
        }

        public void Delete(DBContainer db, string id)
        {
            SysModule entity = db.SysModule.SingleOrDefault(a => a.Id == id);
            if (entity != null)
            {

                //删除SysRight表数据
                var sr = db.SysRight.AsQueryable().Where(a => a.ModuleId == id);
                foreach (var o in sr)
                {
                    //删除SysRightOperate表数据
                    var sro = db.SysRightOperate.AsQueryable().Where(a => a.RightId == o.Id);
                    foreach (var o2 in sro)
                    {
                        db.SysRightOperate.Remove(o2);
                    }
                    db.SysRight.Remove(o);
                }
                //删除SysModuleOperate数据
                var smo = db.SysModuleOperate.AsQueryable().Where(a => a.ModuleId == id);
                foreach (var o3 in smo)
                {
                    db.SysModuleOperate.Remove(o3);
                }
                db.SysModule.Remove(entity);
            }
        }

        public int Edit(SysModule entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.SysModule.Attach(entity);
                //db.ObjectStateManager.ChangeObjectState(entity, EntityState.Modified);
                db.Entry<SysModule>(entity).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }

        public SysModule GetById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysModule.SingleOrDefault(a => a.Id == id);
            }
        }

        public bool IsExist(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysModule entity = GetById(id);
                if (entity != null)
                    return true;
                return false;
            }
        }
        public void Dispose()
        {

        }
    }
}