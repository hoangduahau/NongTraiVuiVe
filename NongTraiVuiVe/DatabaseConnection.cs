using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NongTraiVuiVe
{
    public static class DatabaseConnection
    {
        public static string ConnectionString
        {
            get
            {
                // Đọc chuỗi kết nối từ App.config
                return ConfigurationManager.ConnectionStrings["NongTraiVuiVeConnectionString"].ConnectionString;
            }
        }
    }

}
