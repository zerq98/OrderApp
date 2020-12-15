
using System.Windows.Forms;

namespace OrderApp
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.BirthLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.NameTBox = new System.Windows.Forms.TextBox();
            this.SurnameTBox = new System.Windows.Forms.TextBox();
            this.BirthTBox = new System.Windows.Forms.TextBox();
            this.OrderLbl = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DbSaveBtn = new System.Windows.Forms.Button();
            this.XmlSaveBtn = new System.Windows.Forms.Button();
            this.ProductGrid = new System.Windows.Forms.DataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BirthLbl
            // 
            this.BirthLbl.AutoSize = true;
            this.BirthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BirthLbl.Location = new System.Drawing.Point(12, 116);
            this.BirthLbl.Name = "BirthLbl";
            this.BirthLbl.Size = new System.Drawing.Size(136, 24);
            this.BirthLbl.TabIndex = 2;
            this.BirthLbl.Text = "Data urodzenia";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SurnameLbl.Location = new System.Drawing.Point(12, 70);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(90, 24);
            this.SurnameLbl.TabIndex = 1;
            this.SurnameLbl.Text = "Nazwisko";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(12, 28);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(45, 24);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Imię";
            // 
            // NameTBox
            // 
            this.NameTBox.Location = new System.Drawing.Point(190, 28);
            this.NameTBox.Name = "NameTBox";
            this.NameTBox.Size = new System.Drawing.Size(270, 20);
            this.NameTBox.TabIndex = 3;
            // 
            // SurnameTBox
            // 
            this.SurnameTBox.Location = new System.Drawing.Point(190, 70);
            this.SurnameTBox.Name = "SurnameTBox";
            this.SurnameTBox.Size = new System.Drawing.Size(270, 20);
            this.SurnameTBox.TabIndex = 4;
            // 
            // BirthTBox
            // 
            this.BirthTBox.Location = new System.Drawing.Point(190, 120);
            this.BirthTBox.Name = "BirthTBox";
            this.BirthTBox.Size = new System.Drawing.Size(270, 20);
            this.BirthTBox.TabIndex = 5;
            // 
            // OrderLbl
            // 
            this.OrderLbl.AutoSize = true;
            this.OrderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderLbl.Location = new System.Drawing.Point(12, 212);
            this.OrderLbl.Name = "OrderLbl";
            this.OrderLbl.Size = new System.Drawing.Size(187, 24);
            this.OrderLbl.TabIndex = 7;
            this.OrderLbl.Text = "Zamówione produkty";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(16, 162);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(132, 33);
            this.AddBtn.TabIndex = 6;
            this.AddBtn.Tag = "Add";
            this.AddBtn.Text = "Dodaj produkt";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.ProductDetails_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(154, 162);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(132, 33);
            this.RemoveBtn.TabIndex = 7;
            this.RemoveBtn.Text = "Usuń produkt";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(292, 162);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(132, 33);
            this.EditBtn.TabIndex = 8;
            this.EditBtn.Tag = "Edit";
            this.EditBtn.Text = "Zmień produkt";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.ProductDetails_Click);
            // 
            // DbSaveBtn
            // 
            this.DbSaveBtn.Location = new System.Drawing.Point(518, 496);
            this.DbSaveBtn.Name = "DbSaveBtn";
            this.DbSaveBtn.Size = new System.Drawing.Size(132, 33);
            this.DbSaveBtn.TabIndex = 10;
            this.DbSaveBtn.Text = "Zapisz do bazy danych";
            this.DbSaveBtn.UseVisualStyleBackColor = true;
            this.DbSaveBtn.Click += new System.EventHandler(this.DbSaveBtn_ClickAsync);
            // 
            // XmlSaveBtn
            // 
            this.XmlSaveBtn.Location = new System.Drawing.Point(656, 496);
            this.XmlSaveBtn.Name = "XmlSaveBtn";
            this.XmlSaveBtn.Size = new System.Drawing.Size(132, 33);
            this.XmlSaveBtn.TabIndex = 11;
            this.XmlSaveBtn.Text = "Zapis do XML";
            this.XmlSaveBtn.UseVisualStyleBackColor = true;
            this.XmlSaveBtn.Click += new System.EventHandler(this.XmlSaveBtn_Click);
            // 
            // ProductGrid
            // 
            this.ProductGrid.AllowUserToAddRows = false;
            this.ProductGrid.AllowUserToDeleteRows = false;
            this.ProductGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameHeader,
            this.QuantityHeader,
            this.PriceHeader});
            this.ProductGrid.Location = new System.Drawing.Point(12, 239);
            this.ProductGrid.MultiSelect = false;
            this.ProductGrid.Name = "ProductGrid";
            this.ProductGrid.ReadOnly = true;
            this.ProductGrid.RowHeadersVisible = false;
            this.ProductGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.ProductGrid.Size = new System.Drawing.Size(776, 251);
            this.ProductGrid.TabIndex = 12;
            this.ProductGrid.SelectionChanged += new System.EventHandler(this.ProductGrid_SelectionChanged);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // NameHeader
            // 
            this.NameHeader.DataPropertyName = "Name";
            this.NameHeader.HeaderText = "Nazwa produktu";
            this.NameHeader.Name = "NameHeader";
            this.NameHeader.ReadOnly = true;
            // 
            // QuantityHeader
            // 
            this.QuantityHeader.DataPropertyName = "Quantity";
            this.QuantityHeader.HeaderText = "Ilość";
            this.QuantityHeader.Name = "QuantityHeader";
            this.QuantityHeader.ReadOnly = true;
            // 
            // PriceHeader
            // 
            this.PriceHeader.DataPropertyName = "Price";
            this.PriceHeader.HeaderText = "Cena";
            this.PriceHeader.Name = "PriceHeader";
            this.PriceHeader.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(OrderApp.App.Dto.ProductDto);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.ProductGrid);
            this.Controls.Add(this.XmlSaveBtn);
            this.Controls.Add(this.DbSaveBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.OrderLbl);
            this.Controls.Add(this.BirthTBox);
            this.Controls.Add(this.SurnameTBox);
            this.Controls.Add(this.NameTBox);
            this.Controls.Add(this.BirthLbl);
            this.Controls.Add(this.SurnameLbl);
            this.Controls.Add(this.NameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "OrderApp";
            ((System.ComponentModel.ISupportInitialize)(this.ProductGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BirthLbl;
        private System.Windows.Forms.Label SurnameLbl;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.TextBox NameTBox;
        private System.Windows.Forms.TextBox SurnameTBox;
        private System.Windows.Forms.TextBox BirthTBox;
        private System.Windows.Forms.Label OrderLbl;
        private Button AddBtn;
        private Button RemoveBtn;
        private Button EditBtn;
        private Button DbSaveBtn;
        private Button XmlSaveBtn;
        private DataGridView ProductGrid;
        private BindingSource productBindingSource;
        private DataGridViewTextBoxColumn IdColumn;
        private DataGridViewTextBoxColumn NameHeader;
        private DataGridViewTextBoxColumn QuantityHeader;
        private DataGridViewTextBoxColumn PriceHeader;
    }
}

