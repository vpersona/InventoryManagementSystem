namespace InventoryManagementSystem
{
    partial class ViewOrders
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OrderGV = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 100);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(914, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(406, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Orders";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 518);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(947, 38);
            this.panel2.TabIndex = 20;
            // 
            // OrderGV
            // 
            this.OrderGV.BackgroundColor = System.Drawing.Color.White;
            this.OrderGV.ColumnHeadersHeight = 29;
            this.OrderGV.Location = new System.Drawing.Point(91, 122);
            this.OrderGV.Name = "OrderGV";
            this.OrderGV.RowHeadersWidth = 51;
            this.OrderGV.Size = new System.Drawing.Size(801, 349);
            this.OrderGV.TabIndex = 41;
            this.OrderGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGV_CellContentClick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(441, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 27);
            this.button3.TabIndex = 45;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ViewOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 556);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.OrderGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewOrders";
            this.Load += new System.EventHandler(this.ViewOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView OrderGV;
        private System.Windows.Forms.Button button3;
    }
}