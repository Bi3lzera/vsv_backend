using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsv_back.src.sql
{
          public class configureSQL
          {
                    public static void localhostConfig()
                    {
                              SQL.server = "localhost";
                              SQL.port = "3306";
                              SQL.uid = "root";
                              SQL.pwd = "biel123";
                    }
          }
}
