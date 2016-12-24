using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Mlp.RestApp.DataService;
using SQLite;
using System.IO;

namespace Mlp.RestApp.Droid.DataService
{
    public class RepositorySQLite<T> : SQLiteConnection, 
        IRepository<T> 
        where T : BaseEntity<int>, new()
        
    {

        static object locker = new object();
        public static string DatabaseFilePath
        {
            get
            {
                var sqliteFilename = DateTime.Now.Year + "_RestAppDroid.db3";
                string libraryPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); ;
                var path = Path.Combine(libraryPath, sqliteFilename);
                return path;
            }
        }
        public RepositorySQLite(): base(DatabaseFilePath)
        {
            //InitTables();
            CreateTable<T>();
        }

        public int Delete(T entity)
        {
            lock (locker)
            {
                return Delete<T>(entity.Id);
            }
        }

        public IEnumerable<T> GetAll()
        {
            lock (locker)
            {
                var table = Table<T>();
                //(from i in Table<Stock> () select i).ToList ();
                return table;
            }
        }

        public T GetById(int id)
        {
            lock (locker)
            {
                return Table<T>().FirstOrDefault(x => x.Id == id );
            }
        }
       
        public int Save(T entity)
        {
            lock (locker)
            {
                if (!entity.IsEmptyId())
                {
                    Update(entity);
                }
                else
                {
                    Insert(entity);
                }
                return entity.Id;
            }
        }

        #region prvm
        private void InitTables()
        {
            
        }   
        
        private bool Compare<T1>(T1 a, T1 b) where T1 : class
        {
            return a == b;
        }     
        #endregion
    }
}