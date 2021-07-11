using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;
namespace SmartAbp.Stations
{
    public class WeldSection : Entity<Guid>
    {
        public int rid { get; private set; }
        public float voltage { get; private set; }
        public float current { get; private set; }
        public float speed { get; private set; }
        private WeldSection() { }
        public WeldSection(int rid, float vol, float cur, float speed)
        {
            this.rid = rid;
            voltage = vol;
            current = cur;
            this.speed = speed;
        }
    }
    public enum RobotType
    {
        WeldingRobot,
        TransferRobot
    }
    public class Robot : Entity<Guid>
    {
        public RobotType robotType { get; private set; }
        public List<WeldSection> weldSections { get; set; }
        protected Robot()
        {

        }
        // 实体的主键在基类（Entity<Guid>）中定义了，Robot没有再定义
        public Robot(Guid id, RobotType rt) : base(id)
        {
            robotType = rt;
        }
        public void maintain()
        {
            // 对机器人的保养
        }
        public void repaire()
        {
            // 对机器人的维修
        }
        public void welding(int id, float volt, float curr, float speed)
        {

        }
    }
}