using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrentDate.Models
{
    public class GetTheDate
    {
        public DateTime TheDate { get; set; }

        public void SetDate()
        {
            TheDate = DateTime.Now;
            string sendDate = TheDate.ToString();
        }
    }
}
