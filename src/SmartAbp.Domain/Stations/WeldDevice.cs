using System;
using Volo.Abp.Domain.Entities.Auditing;
namespace SmartAbp.Stations
{
  public class WeldSection : ValueObject
  {
    public int id { get; set; }
    public float voltage { get; set; }
    public float current { get; set; }
    public float speed { get; set; }
  }
  public class Robot : Entity<Guid>
  {
    public List<WeldSection> WeldSections { get; set; }
      protected Robot() {

      }
      // 实体的主键在基类（Entity<Guid>）中定义了，Robot没有再定义
      public Robot(Guid id) : base(id) {

      }
    public void maintain() {

    }
    public void repaire() {

    }
    public void welding(int id, float volt, float curr, float speed) {

    }
  }
}