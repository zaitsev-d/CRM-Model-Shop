using CRM.BusinessLogic.Model;
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
    public partial class ModelForm : Form
    {
        ShopComputerModel model = new ShopComputerModel();

        private Label PriceLabel { get; set; }
        private Label QueueLabel { get; set; }
        private Label LeaveCustomersLabel { get; set; }

        public ModelForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PriceLabel = new Label();
            QueueLabel = new Label();
            LeaveCustomersLabel = new Label();

            PriceLabel.Location = new System.Drawing.Point(130, 7);
            PriceLabel.Size = new System.Drawing.Size(35, 13);
            PriceLabel.Text = "Price";
            Controls.Add(PriceLabel);

            QueueLabel.Location = new System.Drawing.Point(230, 7);
            QueueLabel.Size = new System.Drawing.Size(90, 13);
            QueueLabel.Text = "Queue Length";
            Controls.Add(QueueLabel);

            LeaveCustomersLabel.Location = new System.Drawing.Point(354, 7);
            LeaveCustomersLabel.Size = new System.Drawing.Size(40, 13);
            LeaveCustomersLabel.Text = "Leave";
            Controls.Add(LeaveCustomersLabel);

            CashBoxSerialize();

            button1.Enabled = true;
            button4.Enabled = false;

            model.Start();
        }

        private void CashBoxSerialize()
        {
            var cashBoxes = new List<CashBoxView>();

            for (int i = 0; i < model.CashDesks.Count; i++)
            {
                var box = new CashBoxView(model.CashDesks[i], i, 10, 26 * i);
                cashBoxes.Add(box);
                Controls.Add(box.CashDeskName);
                Controls.Add(box.Price);
                Controls.Add(box.QueueLength);
                Controls.Add(box.LeaveCustomersCount);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button4.Enabled = true;
            button1.Enabled = false;

            model.Stop();
            Controls.Clear();
            this.Close();

            var form = new ModelForm();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        private void ModelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controls.Clear();
            model.Stop();
        }

        private void ModelForm_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = model.CustomerSpeed;
            numericUpDown2.Value = model.CashDeskSpeed;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            model.CustomerSpeed = (int)numericUpDown1.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            model.CashDeskSpeed = (int)numericUpDown2.Value;
        }

        private void ModelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            model.Stop();
        }
    }
}
