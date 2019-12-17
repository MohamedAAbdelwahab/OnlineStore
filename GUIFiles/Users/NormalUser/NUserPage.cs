﻿using OnlineStore.App.Stores.Data;
using OnlineStore.Database_Files;
using OnlineStore.GUIFiles;
using OnlineStore.ShoppingCart;
using OnlineStore.Users.NormalUsers;
using OnlineStore.Users.UserFactoryPattern;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    public partial class NUserPage : Form
    {
        public static int amount;
        NormalUserController controller;
        ShoppingCartController cartController;
        CartObject cartObject;

        public NUserPage(NormalUserController user)
        {
            // My Online MSQL DataBase
            String connectionStr = "Data Source=SQL5047.site4now.net;Initial Catalog=DB_A5071D_OnlineStore;User Id=DB_A5071D_OnlineStore_admin;Password=01152160972Ah;";
            // Local MSQL DataBase
            //String connectionStr = "Data Source=DESKTOP-JEM2R23\\;Initial Catalog=OnlineStore;Integrated Security=True";

            IConnectionString connectionString = new DataBaseConnection();
            connectionString.SetConnectionString(connectionStr);

            this.controller = user;
            InitializeComponent();
            TuserName.Text = controller.normalUser.Data.userName;
            Temail.Text = controller.normalUser.Data.email;
            Tname.Text = controller.normalUser.Data.name;
            Trole.Text = controller.normalUser.Data.role;
            cartController = new ShoppingCartController();
            cartObject = new CartObject();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            mainPage.GetInstance().Show();
            this.Close();
        }

        private void Store_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NUserPage_Load(object sender, EventArgs e)
        {

        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Store.Items.Clear();
            DataTable tpData = controller.GetAllStores();
            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ",";
                }
                Store.Items.Add(tpStr.Substring(0, tpStr.Length - 1));
            }
        }

        private void OpenStore_Click(object sender, EventArgs e)
        {
            Products.Items.Clear();
            String[] s = null;
            List<int> select = new List<int>();

            for (int i = 0; i < Store.Items.Count; i++)
            {
                if (Store.GetItemChecked(i))
                {
                    select.Add(i);
                    break;
                }
            }
            foreach (int inx in select)
            {
                s = Store.Items[inx].ToString().Split(',');
            }
            DataTable tpData = controller.GetProductsInStore(s[2]);
            if (tpData == null)
                return;
            foreach (DataRow row in tpData.Rows)
            {
                String tpStr = "";
                foreach (DataColumn col in tpData.Columns)
                {
                    tpStr += row[col].ToString() + ",";
                }
                Products.Items.Add(tpStr.Substring(0, tpStr.Length - 1));
            }

        }

        private void AddToCart_Click(object sender, EventArgs e)
        {
            ProductInfo temp = new ProductInfo();
            temp.ShowDialog();
            String[] s = null;
            List<int> select = new List<int>();

            for (int i = 0; i < Store.Items.Count; i++)
            {
                if (Products.GetItemChecked(i))
                {
                    select.Add(i);
                    break;
                }
            }
            foreach (int inx in select)
            {
                s = Products.Items[inx].ToString().Split(',');
            }
            cartObject = new CartObject(s[7], s[0], System.Convert.ToDouble(s[5]), amount);
            cartController.addCartItem(cartObject);
        }

        private void ViewCart_Click(object sender, EventArgs e)
        {
            cartController.viewCart();
        }

        private void CalcTotalPrice_Click(object sender, EventArgs e)
        {
            double price =cartController.calcTotalPrice("NormalUser");
            MessageBox.Show(price.ToString());
        }
    }
}
