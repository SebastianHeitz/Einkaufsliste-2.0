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
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Ambrosia"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader_articleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_createShoppinglist = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_addArticle = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.txtbox_articleName = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtbox_categoryName = new System.Windows.Forms.TextBox();
			this.btn_createCategory = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.CheckBoxes = true;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_articleName});
			listViewItem1.StateImageIndex = 0;
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
			this.listView1.Location = new System.Drawing.Point(287, 12);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(566, 532);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader_articleName
			// 
			this.columnHeader_articleName.Text = "Artikel";
			this.columnHeader_articleName.Width = 300;
			// 
			// btn_createShoppinglist
			// 
			this.btn_createShoppinglist.Location = new System.Drawing.Point(34, 486);
			this.btn_createShoppinglist.Name = "btn_createShoppinglist";
			this.btn_createShoppinglist.Size = new System.Drawing.Size(158, 23);
			this.btn_createShoppinglist.TabIndex = 1;
			this.btn_createShoppinglist.Text = "Einkaufslist erstellen (Excel)";
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
			// txtbox_categoryName
			// 
			this.txtbox_categoryName.Location = new System.Drawing.Point(7, 37);
			this.txtbox_categoryName.Name = "txtbox_categoryName";
			this.txtbox_categoryName.Size = new System.Drawing.Size(200, 20);
			this.txtbox_categoryName.TabIndex = 0;
			this.txtbox_categoryName.Text = "Kategoriename hier eingeben";
			this.txtbox_categoryName.Enter += new System.EventHandler(this.txtbox_categoryName_Enter);
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(865, 556);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_createShoppinglist);
			this.Controls.Add(this.listView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader_articleName;
		private System.Windows.Forms.Button btn_createShoppinglist;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txtbox_articleName;
		private System.Windows.Forms.Button btn_addArticle;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btn_createCategory;
		private System.Windows.Forms.TextBox txtbox_categoryName;
	}
}

