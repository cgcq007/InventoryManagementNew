﻿namespace InventoryTest
{
    partial class OutboundItemAdd
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
            this.TrackingNumLabel = new System.Windows.Forms.Label();
            this.TrackingNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SN = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.Qty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.itemTitile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TrackingNumLabel
            // 
            this.TrackingNumLabel.AutoSize = true;
            this.TrackingNumLabel.Location = new System.Drawing.Point(8, 106);
            this.TrackingNumLabel.Name = "TrackingNumLabel";
            this.TrackingNumLabel.Size = new System.Drawing.Size(102, 20);
            this.TrackingNumLabel.TabIndex = 34;
            this.TrackingNumLabel.Text = "TrackingNum";
            // 
            // TrackingNum
            // 
            this.TrackingNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrackingNum.Location = new System.Drawing.Point(126, 98);
            this.TrackingNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TrackingNum.MaxLength = 255;
            this.TrackingNum.Name = "TrackingNum";
            this.TrackingNum.Size = new System.Drawing.Size(337, 28);
            this.TrackingNum.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "SN";
            // 
            // SN
            // 
            this.SN.AcceptsReturn = true;
            this.SN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SN.Location = new System.Drawing.Point(125, 265);
            this.SN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SN.MaxLength = 30000;
            this.SN.Multiline = true;
            this.SN.Name = "SN";
            this.SN.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SN.Size = new System.Drawing.Size(337, 132);
            this.SN.TabIndex = 27;
            this.SN.Tag = "fashdufhas";
            this.SN.TextChanged += new System.EventHandler(this.SN_TextChanged);
            // 
            // date
            // 
            this.date.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date.Location = new System.Drawing.Point(126, 146);
            this.date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(337, 32);
            this.date.TabIndex = 25;
            // 
            // Qty
            // 
            this.Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Qty.Location = new System.Drawing.Point(126, 201);
            this.Qty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Qty.MaxLength = 32;
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(337, 28);
            this.Qty.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 205);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 22);
            this.label7.TabIndex = 30;
            this.label7.Text = "Quantity";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(363, 445);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 39);
            this.button2.TabIndex = 29;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(96, 445);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 39);
            this.button1.TabIndex = 28;
            this.button1.Text = "Save(&s)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemTitile
            // 
            this.itemTitile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemTitile.Location = new System.Drawing.Point(125, 49);
            this.itemTitile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.itemTitile.MaxLength = 128;
            this.itemTitile.Name = "itemTitile";
            this.itemTitile.Size = new System.Drawing.Size(337, 28);
            this.itemTitile.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(68, 156);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = "Item Title";
            // 
            // OutboundItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 566);
            this.Controls.Add(this.TrackingNumLabel);
            this.Controls.Add(this.TrackingNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SN);
            this.Controls.Add(this.date);
            this.Controls.Add(this.Qty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemTitile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "OutboundItemAdd";
            this.Text = "OutboundItemAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TrackingNumLabel;
        private System.Windows.Forms.TextBox TrackingNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SN;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.TextBox Qty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox itemTitile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}