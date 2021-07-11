using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Domain.Values;

namespace SmartAbp.Stations
{
  public class WeldSection : Entity<Guid>
    {
    public float voltage { get; set; }
    public float current { get; set; }
    public float speed { get; set; }

    //protected override IEnumerable<object> GetAtomicValues()
    //{
    //  throw new NotImplementedException();
    //}
    }
  public class Robot : AuditedAggregateRoot<Guid> 
  {
      public List<WeldSection> WeldSections { get; set; }

      public string name { get; set; }

      protected Robot() {

      }
      // 实体的主键在基类（Entity<Guid>）中定义了，Robot没有再定义
      public Robot(Guid id,string name) : base(id) {
            this.name = name;
      }
    public void maintain() {

    }
    public void repaire() {

    }
    public void welding(int id, float volt, float curr, float speed) {

    }
  }
}