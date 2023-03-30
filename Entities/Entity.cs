using System.Data;
using Models;
using SQLData;
namespace Entities
{
    public class Entity:BaseEntity
    {
        SQL query = new SQL();
        public List<Model> GetAllData()
        {
            DataTable table = query.GetAllData();
            return ConvertDataTableToDataList(table);
        }
        private List<Model> ConvertDataTableToDataList(DataTable table)
        {
            List<Model> list = new List<Model>();
            foreach (DataRow dr in table.Rows)
            {
                var values = dr.ItemArray;
                var mod = new Model()
                {
                    ProductName = values[0].ToString(),
                    CategoryName = values[1].ToString()                };
                list.Add(mod);
            }
            return list;
        }
    }
}