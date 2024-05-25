using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace vsv_back.src.sql
{
          public class publicDatas
          {
                    public string city(string cityName)
                    {
                              configureSQL.localhostConfig();
                              SQL s = new SQL();
                              DataTable result = s.GetTable($"SELECT * FROM world.city WHERE `Name` LIKE '{cityName}';");

                              Console.WriteLine(JsonConvert.SerializeObject(result) + "OK");
                              return JsonConvert.SerializeObject(result);
                    }

                    public string state(string stateName)
                    {
                              configureSQL.localhostConfig();
                              SQL s = new SQL();
                              DataTable result = s.GetTable($"SELECT * FROM world.city WHERE `District` LIKE '{stateName}';");

                              Console.WriteLine(JsonConvert.SerializeObject(result) + "OK");
                              return JsonConvert.SerializeObject(result);
                    }
          }
}
