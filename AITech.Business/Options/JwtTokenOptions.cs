using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AITech.Business.Options
{
    public class JwtTokenOptions
    {
        public string Issuer { get; set; }
        public string Audince { get; set; }
        public string Key { get; set; }
        public int ExpireInMinutes { get; set; }
    }
}
