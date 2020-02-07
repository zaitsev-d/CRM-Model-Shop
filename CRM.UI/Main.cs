using CRM.BusinessLogic.Model;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM.UI
{
    public partial class Main : Form
    {
        CRMContext db;
        Cart cart;
        Customer customer;
        CashDesk cashDesk;

        public Main()
        {
            InitializeComponent();
            db = new CRMContext();

            cart = new Cart(customer);
            cashDesk = new CashDesk(1, db.Sellers.FirstOrDefault(), db)
            {
                IsModel = false
            };
        }

        private void ProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogProduct = new Catalog<Product>(db.Products, db);
            catalogProduct.Show();
        }

        private void SellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogSeller = new Catalog<Seller>(db.Sellers, db);
            catalogSeller.Show();
        }

        private void BuyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCustomer = new Catalog<Customer>(db.Customers, db);
            catalogCustomer.Show();
        }

        private void CheckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var catalogCheck = new Catalog<Check>(db.Checks, db);
            catalogCheck.Show();
        }

        private void BuyerAddToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new CustomerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

        private void SellerAddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new SellerForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }
            
        private void ProductAddToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new ProductForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(form.Product);
                db.SaveChanges();
            }
        }

        private void ModellingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new ModelForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                listBox1.Invoke((Action)delegate 
                {
                    listBox1.Items.AddRange(db.Products.ToArray());
                    UpdateLists();
                });
            });
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem is Product product)
            {
                cart.Add(product);
                listBox2.Items.Add(product);
                UpdateLists();
            }
        }

        private void UpdateLists()
        {
            listBox2.Items.Clear();
            listBox2.Items.AddRange(cart.GetAll().ToArray());
            label3.Text = "Total Price: " + cart.Price;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new AuthorizationForm();
            form.ShowDialog();
            if(form.DialogResult == DialogResult.Yes)
            {
                var tempCustomer = db.Customers.FirstOrDefault(c => c.Name.Equals(form.Customer.Name));
                if (tempCustomer != null)
                {
                    customer = tempCustomer;
                }
                else
                {
                    db.Customers.Add(form.Customer);
                    db.SaveChanges();
                    customer = form.Customer;
                }

                cart.Customer = customer;
            }

            linkLabel1.Text = $"Hello, {customer.Name}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(customer != null)
            {
                cashDesk.Enqueue(cart);
                var price = cashDesk.Dequeue();
                listBox2.Items.Clear();
                cart = new Cart(customer);

                MessageBox.Show("Purchase completed successfully! Amount: " + price, "Purchase successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Login In, Please", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
