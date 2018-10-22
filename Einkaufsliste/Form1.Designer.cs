namespace Einkaufsliste
{
	partial class Form1
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
			this.btn_createShoppinglist = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_addArticle = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.txtbox_articleName = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_createCategory = new System.Windows.Forms.Button();
			this.txtbox_categoryName = new System.Windows.Forms.TextBox();
			this.comboBox2 = new System.Windows.Forms.ComboBox();
			this.listBox_Products = new System.Windows.Forms.ListBox();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_createShoppinglist
			// 
			this.btn_createShoppinglist.Location = new System.Drawing.Point(34, 486);
			this.btn_createShoppinglist.Name = "btn_createShoppinglist";
			this.btn_createShoppinglist.Size = new System.Drawing.Size(158, 23);
			this.btn_createShoppinglist.TabIndex = 1;
			this.btn_createShoppinglist.Text = "Einkaufsliste erstellen (Excel)";
			this.btn_createShoppinglist.UseVisualStyleBackColor = true;
			this.btn_createShoppinglist.Click += new System.EventHandler(this.btn_createShoppinglist_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_addArticle);
			this.groupBox1.Controls.Add(this.comboBox1);
			this.groupBox1.Controls.Add(this.txtbox_articleName);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(217, 194);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Neuen Artikel hinzufügen";
			// 
			// btn_addArticle
			// 
			this.btn_addArticle.Location = new System.Drawing.Point(6, 141);
			this.btn_addArticle.Name = "btn_addArticle";
			this.btn_addArticle.Size = new System.Drawing.Size(124, 23);
			this.btn_addArticle.TabIndex = 2;
			this.btn_addArticle.Text = "Artikel hinzufügen";
			this.btn_addArticle.UseVisualStyleBackColor = true;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(6, 85);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(201, 21);
			this.comboBox1.TabIndex = 1;
			this.comboBox1.Text = "Kategorie wählen ...";
			// 
			// txtbox_articleName
			// 
			this.txtbox_articleName.Location = new System.Drawing.Point(6, 39);
			this.txtbox_articleName.Name = "txtbox_articleName";
			this.txtbox_articleName.Size = new System.Drawing.Size(201, 20);
			this.txtbox_articleName.TabIndex = 0;
			this.txtbox_articleName.Text = "Artikelname hier eingeben";
			this.txtbox_articleName.Enter += new System.EventHandler(this.textBox1_Enter);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btn_createCategory);
			this.groupBox2.Controls.Add(this.txtbox_categoryName);
			this.groupBox2.Location = new System.Drawing.Point(12, 240);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(217, 146);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Neue Kategorie erstellen";
			// 
			// btn_createCategory
			// 
			this.btn_createCategory.Location = new System.Drawing.Point(7, 91);
			this.btn_createCategory.Name = "btn_createCategory";
			this.btn_createCategory.Size = new System.Drawing.Size(123, 23);
			this.btn_createCategory.TabIndex = 1;
			this.btn_createCategory.Text = "Kategorie erstellen";
			this.btn_createCategory.UseVisualStyleBackColor = true;
			// 
			// txtbox_categoryName
			// 
			this.txtbox_categoryName.Location = new System.Drawing.Point(7, 37);
			this.txtbox_categoryName.Name = "txtbox_categoryName";
			this.txtbox_categoryName.Size = new System.Drawing.Size(200, 20);
			this.txtbox_categoryName.TabIndex = 0;
			this.txtbox_categoryName.Text = "Kategoriename hier eingeben";
			this.txtbox_categoryName.Enter += new System.EventHandler(this.txtbox_categoryName_Enter);
			// 
			// comboBox2
			// 
			this.comboBox2.FormattingEnabled = true;
			this.comboBox2.Location = new System.Drawing.Point(287, 12);
			this.comboBox2.Name = "comboBox2";
			this.comboBox2.Size = new System.Drawing.Size(246, 21);
			this.comboBox2.TabIndex = 4;
			this.comboBox2.Text = "Kategorie wählen ...";
			// 
			// listBox_Products
			// 
			this.listBox_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox_Products.FormattingEnabled = true;
			this.listBox_Products.ItemHeight = 20;
			this.listBox_Products.Location = new System.Drawing.Point(486, 51);
			this.listBox_Products.Name = "listBox_Products";
			this.listBox_Products.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
			this.listBox_Products.Size = new System.Drawing.Size(349, 504);
			this.listBox_Products.TabIndex = 5;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(486, 592);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 7;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(973, 648);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listBox_Products);
			this.Controls.Add(this.comboBox2);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_createShoppinglist);
			this.Name = "Form1";
			this.Text = "Einkaufslisten-Generator";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btn_createShoppinglist;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtbox_articleName;
		private System.Windows.Forms.Button btn_addArticle;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn_createCategory;
		private System.Windows.Forms.TextBox txtbox_categoryName;
		private System.Windows.Forms.ComboBox comboBox2;
		private System.Windows.Forms.ListBox listBox_Products;
		private System.Windows.Forms.Button button1;
	}
}

