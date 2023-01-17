using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburguesaDavidTrujillo.Models;
using SQLite;


namespace HamburguesaDavidTrujillo.Data
{
    public class BurgerDatabaseDT
    {
        string _dbPath;
        private SQLiteConnection conn;
        public BurgerDatabaseDT(string DatabasePath)
        {
            _dbPath = DatabasePath;
        }
        private void Init()
        {
            if (conn != null)
                return;
            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BurgerDT>();
        }
        public int AddNewBurger(BurgerDT burger)
        {
            Init();
            int result = conn.Insert(burger);
            return result;
        }
        public List<BurgerDT> GetAllBurgers()
        {
            Init();
            List<BurgerDT> burgers = conn.Table<BurgerDT>().ToList();
            return burgers;
        }

    }
}
