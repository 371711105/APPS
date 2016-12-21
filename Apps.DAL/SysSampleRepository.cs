﻿/**
* 命名空间: Apps.DAL
* 功 能： N/A
* 类 名： SysSampleRepository
* 创建时间： 2016/12/18 1:00:48 
* 创建人：小强
* 电子邮箱：371711105@qq.com
*/
using System;
using System.Linq;
using Apps.IDAL;
using Apps.Models;
using System.Data;
using System.Data.Entity;

namespace Apps.DAL
{
    public class SysSampleRepository : ISysSampleRepository, IDisposable
    {
        /// <summary>
        /// 获取列表
        ///</summary>
        /// <param name="db">数据库上下文</param>
        /// <returns>数据列表</returns>
        public IQueryable<SysSample> GetList(DBContainer db)
        {
            IQueryable<SysSample>
                list = db.SysSample.AsQueryable();
            return list;
        }

        /// <summary>
        /// 创建一个实体
        ///</summary>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">实体</param>
        public int Create(SysSample entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.Set<SysSample>().Add(entity);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 删除一个实体
        ///</summary>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">主键ID</param>
        public int Delete(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysSample entity = db.SysSample.SingleOrDefault(a => a.Id == id);
                db.Set<SysSample>().Remove(entity);
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 修改一个实体
        ///</summary>
        /// <param name="db">数据库上下文</param>
        /// <param name="entity">实体</param>
        public int Edit(SysSample entity)
        {
            using (DBContainer db = new DBContainer())
            {
                db.Set<SysSample>().Attach(entity);
                db.Entry<SysSample>(entity).State = EntityState.Modified;
                return db.SaveChanges();
            }
        }

        /// <summary>
        /// 获得一个实体
        ///</summary>
        /// <param name="id">id</param>
        /// <returns>实体</returns>
        public SysSample GetById(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                return db.SysSample.SingleOrDefault(a => a.Id == id);
            }
        }

        /// <summary>
        /// 判断一个实体是否存在
        ///</summary>
        /// <param name="id">id</param>
        /// <returns>是否存在 true or false</returns>
        public bool IsExist(string id)
        {
            using (DBContainer db = new DBContainer())
            {
                SysSample entity = GetById(id);
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
