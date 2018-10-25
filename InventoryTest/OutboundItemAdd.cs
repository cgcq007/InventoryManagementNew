﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryTest
{
    public partial class OutboundItemAdd : Form
    {
        string manipulator;
        public OutboundItemAdd(string uname)
        {
            this.manipulator = uname;
            //date.Refresh();
            InitializeComponent();
        }

        private void SN_TextChanged(object sender, EventArgs e)
        {
            long numLines = SN.Text.Split('\n').Where(x => x.Trim().Length != 0).LongCount();

            Qty.Text = Convert.ToString(numLines);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (itemTitile.Text.Trim().Length != 0 && TrackingNum.Text.Trim().Length != 0 && SN.Text.Trim().Length != 0)
            {
                try
                {
                    using (var ctx = new ItemContext())
                    {
                        ItemOutbound IO = new ItemOutbound() { ItemTitle = itemTitile.Text.Trim(), TrackingNum = TrackingNum.Text.Trim(), Date = Convert.ToDateTime(date.Text.ToString()), Qty = Convert.ToInt32(Qty.Text), Manipulator = manipulator, SN = SN.Text.Trim(), isDelete = false };
                        ctx.ItemOutbounds.Add(IO);
                        ctx.SaveChanges();
                    }
                    MessageBox.Show("Record successfully added!");
                    SN.Text = "";
                    TrackingNum.Text = "";
                    date.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("itemTitile, TrackingNum, SN cannot be null.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
