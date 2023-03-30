using System.Data;
using Dal;
namespace SQLData
{
    public class SQL:BaseSQL
    {
        public DataTable GetAllData()
        {
            string query = @"exec GetMyData";
            DataTable dataTable = new DataTable();
            MyDal.RunCommand(query, dataTable.Load);


            return dataTable;
        }
        public DataTable GetAllData2()
        {
            string query = @"exec tryGet";
            DataTable dataTable = new DataTable();
            MyDal.RunCommand(query, dataTable.Load);


            return dataTable;
        }
    }
}