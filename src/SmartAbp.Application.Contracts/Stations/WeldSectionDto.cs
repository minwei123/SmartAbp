using System;
namespace SmartAbp.Stations
{
    public class WeldSectionDto
    {
        public int rid { get; private set; }
        public float voltage { get; private set; }
        public float current { get; private set; }
        public float speed { get; private set; }
    }
}
