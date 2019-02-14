using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DellQA.Common.Enums
{
    public class VerifyFields
    {
        private static Dictionary<string, string> _dic = new Dictionary<string, string>();
        public static Dictionary<string, string> Fields
        {
            get
            {
                return _dic;

            }
        }
        static VerifyFields()
        {
            _dic.Add("eVar2", "microsoft platform management");
        }

    }
}
