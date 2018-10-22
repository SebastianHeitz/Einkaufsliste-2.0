using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;

namespace Einkaufsliste
{
	public partial class Form1 : Form
	{
		List<ProductModel> products = new List<ProductModel>();

		public Form1()
		{
			InitializeComponent();

			LoadProductList();
		}

		private void LoadProductList()
		{
			products = SqliteDataAccess.LoadProducts();

			FillListBoxWithProducts();

		}

		private void FillListBoxWithProducts()
		{
			listBox_Products.DataSource = null;
			listBox_Products.DataSource = products;
			listBox_Products.DisplayMember = "produktname";
			for (int i = 0; i <= 5; i++)
			{
				listBox_Products.SetSelected(i, true);
			}
			listBox_Products.SetSelected(0, false);
		}

		private void CreateExcelSheet()
		{
			ExcelPackage ExcelPkg = new ExcelPackage();
			ExcelWorksheet wsSheet1 = ExcelPkg.Workbook.Worksheets.Add("Obst");

			using (ExcelRange Rng = wsSheet1.Cells[2, 2, 2, 2])
			{
				Rng.Value = "Ananas";
				Rng.Style.Font.Size = 11;
				Rng.Style.Font.Bold = false;
				Rng.Style.Font.Italic = false;
			}
			wsSheet1.Protection.IsProtected = false;
			wsSheet1.Protection.AllowSelectLockedCells = false;
			ExcelPkg.SaveAs(new FileInfo(@"\\192.168.0.10\Daten\Ute_Ralli\Bancarella\Einkaufsliste\Dynamische Einkaufsliste\test.xlsx"));
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			txtbox_articleName.Text = "";
		}

		private void btn_createShoppinglist_Click(object sender, EventArgs e)
		{
			CreateExcelSheet();
		}

		private void txtbox_categoryName_Enter(object sender, EventArgs e)
		{
			txtbox_categoryName.Text = "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//test = listBox_Products.SelectedItems;
		}
	}
}
