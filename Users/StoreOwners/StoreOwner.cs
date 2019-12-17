﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineStore.Data;
using OnlineStore.Database_Files;
using OnlineStore.srcFiles;
using OnlineStore.Users.UserFactoryPattern;

namespace OnlineStore.Users.StoreOwners
{
    public class StoreOwner : IUser
    {
        public Store[] storeslist;
        private DataBase dataBase;


        public StoreOwner()
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.dataBase = DataBase.GetInstance(connectionString);
        }

        public override void ConnectPage(UserData data)
        {
            this.hand = UserController.GetInstance();
            this.Data = data;
            StoreOwnerPage ap = new StoreOwnerPage(this);
            ap.Show();
        }


        public void RefreshData()
        {
            String cmd1 = "select count(UserID) from UserStore where UserID = " + Data.ID+"";
            DataTable tp = dataBase.Query(cmd1);
            int sz = System.Convert.ToInt32(tp.Rows[0][0].ToString());
            storeslist = new Store[sz];
            String cmd2 = "select Store.StoreID,StoreName,StoreType,StoreLocation,StoreInfo from Store inner join UserStore on Store.StoreID = UserStore.StoreID and UserStore.UserID = " + Data.ID;
            DataTable tpData = dataBase.Query(cmd2);
            int i = 0;
            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ",";
                }

                StoreRawData tpStoreData = new StoreRawData();
                tpStoreData.Handler(tpStr.Split(','));
                storeslist[i] = new Store(tpStoreData);
                i++;
            }
        }
        public Store[] GetStores()
        {

            return storeslist;
        }

        public void AddStore(String name, String type, String Location, String info)
        {
            String cmd = "insert into StoreRequests (UserID,StoreName,Storetype,StoreLocation,StoreInfo) values(" + Data.ID + ",'" + name + "','" + type + "','" + Location + "','" + info + "')";
            dataBase.QueryExec(cmd);
        }

        public void DeleteStore(String StoreID)
        {
            String cmd = "Delete from Store where StoreID = " + StoreID;
            dataBase.QueryExec(cmd);
        }
    }
}
