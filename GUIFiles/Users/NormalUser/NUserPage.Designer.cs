﻿namespace OnlineStore
{
    partial class NUserPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lrole = new System.Windows.Forms.Label();
            this.Trole = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.Label();
            this.Lemail = new System.Windows.Forms.Label();
            this.LuserName = new System.Windows.Forms.Label();
            this.Temail = new System.Windows.Forms.TextBox();
            this.TuserName = new System.Windows.Forms.TextBox();
            this.Tname = new System.Windows.Forms.TextBox();
            this.LogOut = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.BRefresh = new System.Windows.Forms.Button();
            this.OpenStore = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Store = new System.Windows.Forms.CheckedListBox();
            this.Products = new System.Windows.Forms.CheckedListBox();
            this.AddToCart = new System.Windows.Forms.Button();
            this.ViewCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lrole
            // 
            this.Lrole.AutoSize = true;
            this.Lrole.Location = new System.Drawing.Point(575, 17);
            this.Lrole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lrole.Name = "Lrole";
            this.Lrole.Size = new System.Drawing.Size(29, 13);
            this.Lrole.TabIndex = 16;
            this.Lrole.Text = "Role";
            // 
            // Trole
            // 
            this.Trole.Location = new System.Drawing.Point(607, 13);
            this.Trole.Margin = new System.Windows.Forms.Padding(2);
            this.Trole.Name = "Trole";
            this.Trole.ReadOnly = true;
            this.Trole.Size = new System.Drawing.Size(132, 20);
            this.Trole.TabIndex = 15;
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(393, 15);
            this.Lname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(35, 13);
            this.Lname.TabIndex = 14;
            this.Lname.Text = "Name";
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.Location = new System.Drawing.Point(212, 15);
            this.Lemail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(32, 13);
            this.Lemail.TabIndex = 13;
            this.Lemail.Text = "Email";
            // 
            // LuserName
            // 
            this.LuserName.AutoSize = true;
            this.LuserName.Location = new System.Drawing.Point(7, 15);
            this.LuserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LuserName.Name = "LuserName";
            this.LuserName.Size = new System.Drawing.Size(57, 13);
            this.LuserName.TabIndex = 12;
            this.LuserName.Text = "UserName";
            // 
            // Temail
            // 
            this.Temail.Location = new System.Drawing.Point(248, 11);
            this.Temail.Margin = new System.Windows.Forms.Padding(2);
            this.Temail.Name = "Temail";
            this.Temail.ReadOnly = true;
            this.Temail.Size = new System.Drawing.Size(132, 20);
            this.Temail.TabIndex = 11;
            // 
            // TuserName
            // 
            this.TuserName.Location = new System.Drawing.Point(68, 11);
            this.TuserName.Margin = new System.Windows.Forms.Padding(2);
            this.TuserName.Name = "TuserName";
            this.TuserName.ReadOnly = true;
            this.TuserName.Size = new System.Drawing.Size(132, 20);
            this.TuserName.TabIndex = 10;
            // 
            // Tname
            // 
            this.Tname.Location = new System.Drawing.Point(429, 13);
            this.Tname.Margin = new System.Windows.Forms.Padding(2);
            this.Tname.Name = "Tname";
            this.Tname.ReadOnly = true;
            this.Tname.Size = new System.Drawing.Size(132, 20);
            this.Tname.TabIndex = 9;
            // 
            // LogOut
            // 
            this.LogOut.Location = new System.Drawing.Point(42, 405);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(75, 23);
            this.LogOut.TabIndex = 20;
            this.LogOut.Text = "LogOut";
            this.LogOut.UseVisualStyleBackColor = true;
            this.LogOut.Click += new System.EventHandler(this.LogOut_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(248, 405);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 21;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // BRefresh
            // 
            this.BRefresh.Location = new System.Drawing.Point(252, 213);
            this.BRefresh.Name = "BRefresh";
            this.BRefresh.Size = new System.Drawing.Size(75, 23);
            this.BRefresh.TabIndex = 25;
            this.BRefresh.Text = "Refresh";
            this.BRefresh.UseVisualStyleBackColor = true;
            this.BRefresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // OpenStore
            // 
            this.OpenStore.Location = new System.Drawing.Point(252, 117);
            this.OpenStore.Name = "OpenStore";
            this.OpenStore.Size = new System.Drawing.Size(75, 23);
            this.OpenStore.TabIndex = 24;
            this.OpenStore.Text = "Open Store";
            this.OpenStore.UseVisualStyleBackColor = true;
            this.OpenStore.Click += new System.EventHandler(this.OpenStore_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Available stores";
            // 
            // Store
            // 
            this.Store.FormattingEnabled = true;
            this.Store.Location = new System.Drawing.Point(26, 97);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(174, 184);
            this.Store.TabIndex = 22;
            // 
            // Products
            // 
            this.Products.FormattingEnabled = true;
            this.Products.Location = new System.Drawing.Point(440, 85);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(285, 184);
            this.Products.TabIndex = 26;
            // 
            // AddToCart
            // 
            this.AddToCart.Location = new System.Drawing.Point(396, 324);
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Size = new System.Drawing.Size(75, 23);
            this.AddToCart.TabIndex = 27;
            this.AddToCart.Text = "AddToCart";
            this.AddToCart.UseVisualStyleBackColor = true;
            this.AddToCart.Click += new System.EventHandler(this.AddToCart_Click);
            // 
            // ViewCart
            // 
            this.ViewCart.Location = new System.Drawing.Point(547, 324);
            this.ViewCart.Name = "ViewCart";
            this.ViewCart.Size = new System.Drawing.Size(75, 23);
            this.ViewCart.TabIndex = 28;
            this.ViewCart.Text = "ViewCart";
            this.ViewCart.UseVisualStyleBackColor = true;
            this.ViewCart.Click += new System.EventHandler(this.ViewCart_Click);
            // 
            // NUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 450);
            this.Controls.Add(this.ViewCart);
            this.Controls.Add(this.AddToCart);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.BRefresh);
            this.Controls.Add(this.OpenStore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Store);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.Lrole);
            this.Controls.Add(this.Trole);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Lemail);
            this.Controls.Add(this.LuserName);
            this.Controls.Add(this.Temail);
            this.Controls.Add(this.TuserName);
            this.Controls.Add(this.Tname);
            this.Name = "NUserPage";
            this.Text = "NUserPage";
            this.Load += new System.EventHandler(this.NUserPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lrole;
        private System.Windows.Forms.TextBox Trole;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.Label LuserName;
        private System.Windows.Forms.TextBox Temail;
        private System.Windows.Forms.TextBox TuserName;
        private System.Windows.Forms.TextBox Tname;
        private System.Windows.Forms.Button LogOut;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button BRefresh;
        private System.Windows.Forms.Button OpenStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox Store;
        private System.Windows.Forms.CheckedListBox Products;
        private System.Windows.Forms.Button AddToCart;
        private System.Windows.Forms.Button ViewCart;
    }
}