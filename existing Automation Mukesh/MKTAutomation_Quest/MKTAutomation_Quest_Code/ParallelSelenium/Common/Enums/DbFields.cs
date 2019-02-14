using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DellQA.Common.Enums
{
    public struct DbFields
    {
        private static Dictionary<string, string> _dic = new Dictionary<string, string>();
        public static Dictionary<string, string> Fields
        {
            get
            {
                return _dic;

            }
        }
        static DbFields()
        {
            
            _dic.Add("Phone", "db_phone");
            _dic.Add("DB_Latitude", "DB_Latitude");
            _dic.Add("DB_Longitude", "DB_Longitude");
            _dic.Add("DB_Industry", "DB_Industry");
            _dic.Add("DB_SubIndustry", "DB_SubIndustry");
            _dic.Add("db_employee_range", "db_employee_range");
            _dic.Add("db_revenue_range", "db_revenue_range");
            _dic.Add("db_country_name", "db_country_name");
            _dic.Add("db_primary_naics", "db_primary_naics");
            _dic.Add("db_annual_sales", "db_annual_sales");
            _dic.Add("db_fortune_1000", "db_fortune_1000");
            _dic.Add("db_forbes_2000", "db_forbes_2000");
            _dic.Add("db_b2b", "db_b2b");
            _dic.Add("db_b2c", "db_b2c");
            _dic.Add("db_marketing_alias", "db_marketing_alias");
            _dic.Add("db_web_site", "db_web_site");
            _dic.Add("db_traffic", "db_traffic");
            _dic.Add("AssetCode_ID", "AssetCodeID");
            _dic.Add("FormFillType", "FormFillType");
        }
    }
}
