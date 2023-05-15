using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        TaikhoanAcess tkAcess = new TaikhoanAcess();
        public string CheckLogicBLL(TaiKhoan taikhoan)
        {
            if(taikhoan.Tendangnhap == "")
            {
                return "requeid_taikhoan";
            }
            if (taikhoan.Matkhau == "")
            {
                return "requeid_pass";
            }
            string infor = tkAcess.CheckLogic(taikhoan);
            return infor;
        }
    }
}
