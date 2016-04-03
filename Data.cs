using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoSearchCombobox
{
    class Data
    {
        public static IEnumerable<String> Names
        {
            get
            {
                return Properties.Resources.Countries.Split('\r', '\n').Where(x => !string.IsNullOrWhiteSpace(x));
            }
        }
    }
}
