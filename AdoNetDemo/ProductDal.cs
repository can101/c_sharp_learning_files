using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetDemo
{
    internal class ProductDal
    {
        SqlConnection _conn = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");//@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=false;uid=****;password=*******"

        //List<Product>
        public DataTable GetAll2()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * from Products", _conn);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _conn.Close();
            return dataTable;
        }
        public List<Product> GetAll()
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Products", _conn);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product product = new Product
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Name = reader["name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"])
                };
                products.Add(product);
            }


            reader.Close();
            _conn.Close();
            return products;
        }
        private void ConnectionControl()
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }
        public void Add(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Insert into Products values(@name,@unitprice,@stockAmount)", _conn);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitprice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.ExecuteNonQuery(); //insert time return 1
            _conn.Close();
        }
        public void Update(Product product)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Products set Name=@name,UnitPrice=@unitprice,StockAmount=@stockAmount where Id=@id", _conn);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitprice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            command.Parameters.AddWithValue("@id", product.Id);
            command.ExecuteNonQuery(); //insert time return 1
            _conn.Close();
        }
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Products where Id=@id", _conn);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery(); //insert time return 1
            _conn.Close();
        }
    }

}
