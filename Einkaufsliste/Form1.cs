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
		public Form1()
		{
			InitializeComponent();
		}

		private void listView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Diese Funktion zeigt schön wie man den Wert aus einem CheckedItem auslesen kann.

			if (listView1.SelectedIndices.Count <= 0)
			{
				return;
			}
			int intselectedindex = listView1.SelectedIndices[0];
			if (intselectedindex >= 0)
			{
				String text = listView1.Items[intselectedindex].Text;

				//do something
				MessageBox.Show(listView1.Items[intselectedindex].Text); 
			}
		}

		private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
		{
			// Entweder wird an dieser Stelle bei jedem Click in die Checkbox die Datenbank aktualisiert oder 
			// diese Eventlistener ist unsinnig. Ich könnte auch erst beim Erstellen der Liste die CheckedItems wegschreiben.
			// Nachteil: Wenn das Programm abstürzt oder geschlossen wird, sind alle zwischenzeitlich gemachten Einstellungen weg.
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
	}
}
