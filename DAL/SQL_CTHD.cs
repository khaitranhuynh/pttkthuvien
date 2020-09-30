using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
/*
CREATE TABLE CT_HOA_DON(
    MA_CT VARCHAR(5),
    MA_HD VARCHAR(5),
    MA_MH VARCHAR(5),
    SOLUONG int,
    DOI_TRA NVARCHAR(50) null,
    GIA float (12) null,
    PRIMARY KEY(MA_CT)
);
 
 */
namespace DAL
{
    public class SQL_CHITIETHD
    {
        KetnoiDB cn = new KetnoiDB();
        SQL_HOADON hd = new SQL_HOADON();
        // THÊM DỮ LIỆU
        public void AddData(CT_HOA_DON ex)
        {
            cn.ExecuteReader(@"INSERT INTO CT_HOA_DON(MA_HD,MA_MH,SOLUONG) VALUES ('" + ex.MaHD + "','" + ex.MaSP + "'," + ex.SLBan + ")");
        }
        //  SỬA DỮ LIỆU
        /*public void EditData(CT_HOA_DON ex)
        {
            cn.ExecuteReader(@"UPDATE CHI_TIET_HDBAN SET SLBan =N'" + ex.SLBan + "', DonGiaBan =N'" + ex.DonGiaBan + "', ThanhTienBan =N'" + ex.ThanhTienBan + "' Where MaHD=N'" + ex.MaHD + "'");
        }
        */
        //  XÓA DỮ LIỆU 
         
       
    }
}
