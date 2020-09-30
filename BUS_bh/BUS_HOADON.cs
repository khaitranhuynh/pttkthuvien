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
    public class BUS_HOADON
    {
        SQL_HOADON bus = new SQL_HOADON();
        public void AddData(HOA_DON ex)
        {
            bus.AddData(ex);
        }
        public void hoadonmoi_id(HOA_DON ex)
        {
              bus.hoadonmoi_id(ex);
        }
        public void ThemQuaThe(string condition)
        {
            bus.ThemQuaThe(condition);
        }
        public void HuyDon(string condition)
        {
            bus.HuyDon(condition);
        }
        public void HuyChiTiet(string condition)
        {
            bus.HuyChiTiet(condition);
        }
        public void ThemTrucTiep(string condition)
        {
            bus.ThemTrucTiep(condition);
        }
        public DataTable XemHoaDon(string Condition)
        {
            return bus.XemHoaDon(Condition);
        }
        public DataTable XemHoaDonThanhToan(string Condition)
        {
            return bus.XemHoaDonThanhToan(Condition);
        }
        public DataTable GetTongHoaDon(string Condition)
        {
            return bus.GetTongHoaDon(Condition);
        }


    }
}
