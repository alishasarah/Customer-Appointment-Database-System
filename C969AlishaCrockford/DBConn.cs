using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace C969AlishaCrockford
{
    public class DBConn
    {
        public static MySqlConnection conn { get; set; }


    }
}
