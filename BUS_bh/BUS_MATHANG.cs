using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using DTO;
namespace BUS_BH
{
    public class BUS_MATHANG
    {
        SQL_MATHANG bus = new SQL_MATHANG();
    
        /*public void AddData(MAT_HANG ex)
        {
            bus.AddData(ex);
        }*/
        //  SỬA DỮ LIỆU
       /* public void EditData(MAT_HANG ex)
        {
            bus.EditData(ex);
        }
        */
        //  CẬP NHẬT SỐ LƯỢNG
       /* public void EditSL(MAT_HANG ex)
        {
            bus.EditSL(ex);
        }*/
        //  XÓA DỮ LIỆU
      /*  public void DeleteData(MAT_HANG ex)
        {
            bus.DeleteData(ex);
        }*/
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return bus.GetData(Condition);
        }
        public DataTable GetDataMua(string Condition)
        {
            return bus.GetDataMua(Condition);
        }
        public DataTable GetTable()
        {
            return bus.getTable();
        }
        public DataTable GetSL(string Condition)
        {
            return bus.GetSL(Condition);
        }
       /* public DataTable Show(string Condition)
        {
            return bus.Show(Condition);
        }*/
        public DataTable GetMaSP(string Condition)
        {
            return bus.GetMaSP(Condition);
        }
 
        public DataTable GetAUTOMaSP()
        {
            return bus.GetAUTOMaSP();
        }
    }
}
