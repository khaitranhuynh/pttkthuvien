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
    public class BUS_CHITIETHD
    {
        SQL_CHITIETHD bus = new SQL_CHITIETHD();
        // THÊM DỮ LIỆU
        public void AddData(CT_HOA_DON ex)
        {
            bus.AddData(ex);
        }
        //  SỬA DỮ LIỆU
       
    }
}
