namespace InventoryManagementSystem
{
    partial class ManageOrders
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomersGV = new System.Windows.Forms.DataGridView();
            this.OrderIdTb = new System.Windows.Forms.TextBox();
            this.CustIdTb = new System.Windows.Forms.TextBox();
            this.OrderDt = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchCombo = new System.Windows.Forms.ComboBox();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.QuantityTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CustNameTb = new System.Windows.Forms.TextBox();
            this.OrderGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.TotAmount = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(965, 100);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(932, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(298, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(438, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "INVENTORY MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(430, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 565);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(965, 38);
            this.panel2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(179, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "CUSTOMERS LIST";
            // 
            // CustomersGV
            // 
            this.CustomersGV.BackgroundColor = System.Drawing.Color.White;
            this.CustomersGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGV.Location = new System.Drawing.Point(12, 131);
            this.CustomersGV.Name = "CustomersGV";
            this.CustomersGV.RowHeadersWidth = 51;
            this.CustomersGV.RowTemplate.Height = 24;
            this.CustomersGV.Size = new System.Drawing.Size(471, 172);
            this.CustomersGV.TabIndex = 21;
            this.CustomersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellContentClick);
            // 
            // OrderIdTb
            // 
            this.OrderIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OrderIdTb.Location = new System.Drawing.Point(83, 326);
            this.OrderIdTb.Name = "OrderIdTb";
            this.OrderIdTb.Size = new System.Drawing.Size(73, 27);
            this.OrderIdTb.TabIndex = 22;
            // 
            // CustIdTb
            // 
            this.CustIdTb.Enabled = false;
            this.CustIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CustIdTb.Location = new System.Drawing.Point(12, 359);
            this.CustIdTb.Name = "CustIdTb";
            this.CustIdTb.Size = new System.Drawing.Size(144, 27);
            this.CustIdTb.TabIndex = 23;
            // 
            // OrderDt
            // 
            this.OrderDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.OrderDt.Location = new System.Drawing.Point(12, 471);
            this.OrderDt.Name = "OrderDt";
            this.OrderDt.Size = new System.Drawing.Size(240, 27);
            this.OrderDt.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(12, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Order Date:";
            // 
            // SearchCombo
            // 
            this.SearchCombo.FormattingEnabled = true;
            this.SearchCombo.Location = new System.Drawing.Point(662, 106);
            this.SearchCombo.Name = "SearchCombo";
            this.SearchCombo.Size = new System.Drawing.Size(167, 24);
            this.SearchCombo.TabIndex = 34;
            this.SearchCombo.Text = "Select Category";
            this.SearchCombo.SelectionChangeCommitted += new System.EventHandler(this.SearchCombo_SelectionChangeCommitted);
            // 
            // ProductsGV
            // 
            this.ProductsGV.BackgroundColor = System.Drawing.Color.White;
            this.ProductsGV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGV.Location = new System.Drawing.Point(489, 131);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.RowHeadersWidth = 51;
            this.ProductsGV.RowTemplate.Height = 24;
            this.ProductsGV.Size = new System.Drawing.Size(464, 172);
            this.ProductsGV.TabIndex = 33;
            this.ProductsGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellContentClick);
            // 
            // QuantityTb
            // 
            this.QuantityTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.QuantityTb.Location = new System.Drawing.Point(558, 314);
            this.QuantityTb.Name = "QuantityTb";
            this.QuantityTb.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.QuantityTb.Size = new System.Drawing.Size(98, 27);
            this.QuantityTb.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(463, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Quantity";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(662, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 27);
            this.button1.TabIndex = 37;
            this.button1.Text = "Add to Order";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustNameTb
            // 
            this.CustNameTb.Enabled = false;
            this.CustNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CustNameTb.Location = new System.Drawing.Point(12, 392);
            this.CustNameTb.Name = "CustNameTb";
            this.CustNameTb.Size = new System.Drawing.Size(144, 27);
            this.CustNameTb.TabIndex = 39;
            // 
            // OrderGV
            // 
            this.OrderGV.BackgroundColor = System.Drawing.Color.PaleTurquoise;
            this.OrderGV.ColumnHeadersHeight = 29;
            this.OrderGV.Location = new System.Drawing.Point(271, 347);
            this.OrderGV.Name = "OrderGV";
            this.OrderGV.RowHeadersWidth = 51;
            this.OrderGV.Size = new System.Drawing.Size(682, 182);
            this.OrderGV.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(541, 534);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Total Amount PLN";
            // 
            // TotAmount
            // 
            this.TotAmount.AutoSize = true;
            this.TotAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.TotAmount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.TotAmount.Location = new System.Drawing.Point(720, 534);
            this.TotAmount.Name = "TotAmount";
            this.TotAmount.Size = new System.Drawing.Size(23, 25);
            this.TotAmount.TabIndex = 42;
            this.TotAmount.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(12, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 27);
            this.button2.TabIndex = 43;
            this.button2.Text = "Insert Order";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(140, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 27);
            this.button3.TabIndex = 44;
            this.button3.Text = "View Orders";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(8, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 45;
            this.label8.Text = "OrderId";
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 603);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TotAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CustNameTb);
            this.Controls.Add(this.OrderGV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.QuantityTb);
            this.Controls.Add(this.SearchCombo);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OrderDt);
            this.Controls.Add(this.CustIdTb);
            this.Controls.Add(this.OrderIdTb);
            this.Controls.Add(this.CustomersGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView CustomersGV;
        private System.Windows.Forms.TextBox OrderIdTb;
        private System.Windows.Forms.TextBox CustIdTb;
        private System.Windows.Forms.DateTimePicker OrderDt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SearchCombo;
        private System.Windows.Forms.DataGridView ProductsGV;
        private System.Windows.Forms.TextBox QuantityTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CustNameTb;
        private System.Windows.Forms.DataGridView OrderGV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotAmount;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
    }
}