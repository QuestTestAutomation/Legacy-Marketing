using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParallelSelenium.Common
{
    public class ItemData
    {
        private String zoneName;
        private String upc;
        private String vendorName;
        private String level1;
        private String level2;
        private String level3;
        private String level4;

        public ItemData()
        {
        }

        public String ZoneName
        {
            get { return zoneName; }
            set { zoneName = value; }
        }

        public String Upc
        {
            get { return upc; }
            set { upc = value; }
        }

        public String VendorName
        {
            get { return vendorName; }
            set { vendorName = value; }
        }

        public String Level1
        {
            get { return level1; }
            set { level1 = value; }
        }

        public String Level2
        {
            get { return level2; }
            set { level2 = value; }
        }

        public String Level3
        {
            get { return level3; }
            set { level3 = value; }
        }

        public String Level4
        {
            get { return level4; }
            set { level4 = value; }
        }

    }
}
