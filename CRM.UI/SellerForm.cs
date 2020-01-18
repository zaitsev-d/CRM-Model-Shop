﻿using CRM.BusinessLogic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.UI
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }
        public SellerForm()
        {
            InitializeComponent();
        }

        public SellerForm(Seller seller): this()
        {
            Seller = seller;
            textBox2.Text = Seller.Name;
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var s = Seller ?? new Seller();
            s.Name = textBox2.Text;
            Close();
        }
    }
}
