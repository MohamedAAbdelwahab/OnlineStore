﻿using OnlineStore.App.Stores.Data;

namespace OnlineStore.App.Stores
{
    public class Store
    {
        public UserStoreData storeData;
        public StatisticsController productStatistic;
        public StoreProductController products;

        public Store()
        {
            this.storeData = new UserStoreData();
            this.productStatistic = new StatisticsController();
            this.products = new StoreProductController();

        }

        public Store(UserStoreData storeData)
        {
            this.storeData = storeData;
            this.productStatistic = new StatisticsController();
            this.products = new StoreProductController();
        }

        
        public void GetStat()
        {
            /*
            String cmd1 = "select NumOfViews,NumOfSold from MyStatistics MS inner join StoreStat SS on MS.StatID = SS.StatID and SS.StoreID = " + SD.ID;
            DataTable tp = dataBase.Query(cmd1);
            if (tp.Rows.Count > 0)
            {
                String[] tpData = new String[2];
                foreach (DataRow row in tp.Rows)
                {
                    int i = 0;
                    foreach (DataColumn col in tp.Columns)
                    {
                        tpData[i] = row[col].ToString();
                    }

                }
                int num1 = System.Convert.ToInt32(tpData[0]);
                int num2 = System.Convert.ToInt32(tpData[1]);
                //SS = new Statistics(num1, num2);
            }

            String cmd2 = "select SS.Product,NumOfViews,NumOfSold from MyStatistics MS inner join StoreProductStat SS on MS.StatID = SS.StatID and SS.StoreID = " + SD.ID;
            tp = dataBase.Query(cmd2);
            if (tp.Rows.Count > 0)
            {
                foreach (DataRow row in tp.Rows)
                {
                    String[] tpData = new String[3];
                    int i = 0;
                    foreach (DataColumn col in tp.Columns)
                    {
                        tpData[i] = row[col].ToString();
                        i++;
                    }
                    try
                    {
                        PS.Add(tpData[0], new Statistics(System.Convert.ToInt32(tpData[1]), System.Convert.ToInt32(tpData[2])));
                    }
                    catch
                    {
                        //MessageBox.Show("el dania biza");
                    }
                }
            }
            */
        }

        public void GetProducts()
        {
            /*
            int i = 0;
            string cmd = "select ProductID,ProductName,BrandName,BrandType,SPS.amount,SPS.price from Product P inner join StoreProductStat SPS on P.ProductID = SPS.Product and SPS.StoreID =" + SD.ID;
            DataTable tp = dataBase.Query(cmd);
            if (tp.Rows.Count > 0)
            {
                int sz = tp.Rows.Count;
                PD = new ProductRawData[sz];
                for (int k = 0; k < sz; k++)
                    PD[k] = new ProductRawData();
                foreach (DataRow row in tp.Rows)
                {
                    String tpStr = "";
                    foreach (DataColumn col in tp.Columns)
                    {
                        tpStr += row[col].ToString() + ",";
                    }
                    PD[i].Handler(tpStr.Split(','));
                    i++;
                }
            }
            */
        }
        public void addProduct()
        {

        }
        
    }
}
