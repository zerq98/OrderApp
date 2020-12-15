
namespace OrderApp
{
    partial class ProductForm
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
            this.AddBtn = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.QuantityLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.NameTBox = new System.Windows.Forms.TextBox();
            this.QuantityNum = new System.Windows.Forms.NumericUpDown();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.PriceNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNum)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(231, 184);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 0;
            this.AddBtn.Text = "Dodaj";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(12, 31);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(57, 20);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Nazwa";
            // 
            // QuantityLbl
            // 
            this.QuantityLbl.AutoSize = true;
            this.QuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityLbl.Location = new System.Drawing.Point(12, 75);
            this.QuantityLbl.Name = "QuantityLbl";
            this.QuantityLbl.Size = new System.Drawing.Size(42, 20);
            this.QuantityLbl.TabIndex = 2;
            this.QuantityLbl.Text = "Ilość";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLbl.Location = new System.Drawing.Point(12, 116);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(47, 20);
            this.PriceLbl.TabIndex = 3;
            this.PriceLbl.Text = "Cena";
            // 
            // NameTBox
            // 
            this.NameTBox.Location = new System.Drawing.Point(147, 31);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(230, 20);
            this.NameTBox.TabIndex = 4;
            // 
            // QuantityNum
            // 
            this.QuantityNum.Location = new System.Drawing.Point(147, 75);
            this.QuantityNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityNum.Name = "QuantityNum";
            this.QuantityNum.Size = new System.Drawing.Size(48, 20);
            this.QuantityNum.TabIndex = 5;
            this.QuantityNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuantityNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(315, 184);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 7;
            this.CancelBtn.Text = "Anuluj";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(231, 184);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 8;
            this.EditBtn.Text = "Edytuj";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Visible = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // PriceNum
            // 
            this.PriceNum.DecimalPlaces = 2;
            this.PriceNum.Location = new System.Drawing.Point(147, 116);
            this.PriceNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.PriceNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PriceNum.Name = "PriceNum";
            this.PriceNum.Size = new System.Drawing.Size(85, 20);
            this.PriceNum.TabIndex = 9;
            this.PriceNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PriceNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 219);
            this.Controls.Add(this.PriceNum);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.QuantityNum);
            this.Controls.Add(this.NameTBox);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.QuantityLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.AddBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)(this.QuantityNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label QuantityLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.TextBox NameTBox;
        private System.Windows.Forms.NumericUpDown QuantityNum;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.NumericUpDown PriceNum;
    }
}