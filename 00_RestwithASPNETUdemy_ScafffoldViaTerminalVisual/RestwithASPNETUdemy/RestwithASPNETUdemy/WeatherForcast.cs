using System;
using sysytem

namespace RestWithAPNETYdemy
{
    public class WatherForcast {

        public DateTime  Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => { get; set; }32 + (int)(TemparatureC / .5556);
        public string Summary { get; set}

    }

}

