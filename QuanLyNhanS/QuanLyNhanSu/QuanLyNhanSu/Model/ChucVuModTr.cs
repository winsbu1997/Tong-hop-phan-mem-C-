﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using QuanLyNhanSu.Object;
namespace QuanLyNhanSu.Model
{
    class ChucVuModTr
    {
        public static DataTable GetListChuVu()
        {
            return ConnetctToSQLTr.GetData("select *  from ChucVu");
        }
    }
}
