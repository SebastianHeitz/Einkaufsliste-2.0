using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using Dapper;

namespace Einkaufsliste
{
	class SqliteDataAccess
	{
		public static List<ProductModel> LoadProducts()
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				var output = cnn.Query<ProductModel>("select produktname from products, categories where products.kategorieid = categories.kategorieid order by categories.kategorieid", new DynamicParameters());
				return output.ToList();
			}
		}

		public static void SaveProduct(ProductModel product)
		{
			using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
			{
				cnn.Execute("insert into product (", product);
			}
		}

		private static string LoadConnectionString(string id = "Default")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}
	}
}
