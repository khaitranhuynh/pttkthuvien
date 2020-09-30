using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAL
{
    public class SQL_HOADON
    {
        KetnoiDB cn = new KetnoiDB();
        // THÊM DỮ LIỆU
        public void AddData(HOA_DON ex)
        {
            cn.ExecuteReader(@" INSERT INTO HOA_DON(MA_HD, NGAYBAN ) VALUES ('" + ex.MaHD + "','" +  ex.NgayBan + "')");
        }
        public void hoadonmoi_id(HOA_DON ex)
        {
            cn.ExecuteReader(@" INSERT INTO HOA_DON(MA_HD,NGAYBAN ) VALUES ('" + ex.MaHD + "','" + ex.NgayBan + "')");
        }
        public void HuyDon(string Condition)
        {
            cn.ExecuteReader(@" DELETE FROM HOA_DON WHERE MA_HD = '" + Condition + "'");
        }
        public void HuyChiTiet(string Condition)
        {
            cn.ExecuteReader(@" DELETE FROM CT_HOA_DON WHERE MA_HD = '" + Condition + "'");
        }
        public DataTable XemHoaDon(string Condition)
        {
            return cn.GetDataTable(@"Select MH.Ten_MH, MH.Gia, CT.SoLuong from CT_HOA_DON CT, MAT_HANG MH where CT.Ma_MH = MH.Ma_MH and CT.MA_HD = '" + Condition + "'");
        }
        public DataTable XemHoaDonThanhToan(string Condition)
        {
            return cn.GetDataTable(@"Select Ma_HD, Tong_HD, HINHTHUC,NGAYBAN from HOA_DON Where MA_HD = '" + Condition + "'");
        }
        public void ThemTrucTiep(string Condition)
        {
            cn.ExecuteReader(@" UPDATE HOA_DON SET HINHTHUC='Truc Tiep' WHERE MA_HD = '" + Condition + "'");
        }
        public void ThemQuaThe(string Condition)
        {
            cn.ExecuteReader(@" UPDATE HOA_DON SET HINHTHUC='Qua The' WHERE MA_HD = '" + Condition + "'");
        }
        public DataTable GetTongHoaDon(string Condition)
        {
            return cn.GetDataTable("Select Tong_HD from HOA_DON WHERE MA_HD = '" + Condition + "'");
        }
        /*
        //  SỬA DỮ LIỆU //
        public void EditData(HOA_DON ex)
        {
            cn.ExecuteReader(@"UPDATE HOA_DON_BAN SET  MaNV =N'" + ex.MaNV + "', MaKH =N'" + ex.MaKH + "', NgayBan =N'" + ex.NgayBan + "' Where MaHD=N'" + ex.MaHD + "'");
        }
        //  XÓA DỮ LIỆU
        public void DeleteData(HOA_DON ex)
        {
            cn.ExecuteReader(@"DELETE FROM HOA_DON_BAN Where MaHD=N'" + ex.MaHD + "'");
        }
        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select * from HOA_DON_BAN " + Condition);
        }
        public DataTable GetData_HD(string Condition)
        {
            return cn.GetDataTable("SELECT TOP (1) RIGHT(MaHD,5) AS MaHD FROM HOA_DON_BAN ORDER BY MaHD DESC " + Condition);
        }
        */
    }
}
