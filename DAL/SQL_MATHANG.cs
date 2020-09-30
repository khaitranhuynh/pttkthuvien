using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class SQL_MATHANG
    {
        KetnoiDB cn = new KetnoiDB();

        //  LẤY DỮ LIỆU
        public DataTable GetData(string Condition)
        {
            return cn.GetDataTable("Select  ma_MH, ten_MH, soluong_ton, gia, TEN_NCC from MAT_HANG m, NHA_CUNG_CAP n where m.NHACC = n.MA_NCC  " + Condition);
        }
        public DataTable GetDataMua(string Condition)
        {
            return cn.GetDataTable("Select ma_MH, ten_MH, gia from MAT_HANG " + Condition);
        }
        public DataTable GetSL(string Condition)
        {
            return cn.GetDataTable(@"SELECT SOLUONG_TON FROM mat_hang Where Ma_MH = '" + Condition + "'");
        }
        /*public DataTable Show(string Condition)
        {
            return cn.GetDataTable("SELECT MAT_HANG.Ma_mh, MAT_HANG.Ten_MH, CHI_TIET_HDBAN.SLTon,CT_HOA_DON., CHI_TIET_HDBAN.ThanhTienBan FROM SAN_PHAM INNER JOIN CHI_TIET_HDBAN ON SAN_PHAM.MaSP = CHI_TIET_HDBAN.MaSP INNER JOIN HOA_DON_BAN ON CHI_TIET_HDBAN.MaHD = HOA_DON_BAN.MaHD" + Condition);
        }*/
        public DataTable GetMaSP(string Condition)
        {
            return cn.GetDataTable("SELECT Ma_mh, Ten_mh, Gia FROM MAT_HANG" + Condition);
        }

        public DataTable GetAUTOMaSP()
        {
            return cn.GetDataTable("SELECT TOP(1) RIGHT(Ma_mh,6) FROM mat_HANG ORDER BY Ma_MH DESC ");
        }
        public DataTable getTable()
        {
            //string myCommand = "Select * from MAT_HANG";
          //  cn.OpenConnect();
            return cn.GetDataTable("Select * from MAT_HANG");
           
        }
    }
}
