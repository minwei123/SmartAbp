using System;
using Volo.Abp.Domain.Entities.Auditing;
namespace SmartAbp.Stations
{
    public class Station : AuditedAggregateRoot<Guid>
    {

        public String Name { get; set; }
        public String Description { get; set; }
        public String Remarks { get; set; }
        public String CreatedDT { get; set; }
        public String ModifiedDT { get; set; }
        public String DeletedDT { get; set; }
        public String IsEnabled { get; set; }
        public String IsDeleted { get; set; }
        public String LinePK { get; set; }
        public String LineID { get; set; }
        public String SkillScore { get; set; }
    }
}
