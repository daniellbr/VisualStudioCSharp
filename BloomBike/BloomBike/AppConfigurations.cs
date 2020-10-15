using System.Collections.Generic;

namespace BloomBike
{
    public class AppConfigurations
    {
        public List<DatabaseConfiguration> Databeses { get; set; }

        public LogFilterConfiguration LogFilter { get; set; }

    }
}