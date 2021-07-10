using System;
using Volo.Abp.Domain.Entities.Auditing;
namespace SmartAbp.Stations
{
    //工作站类型没有使用继承技术
    public enum StationType
    {
        WeldStation,
        MeasureStation
    }
    public class Station : AuditedAggregateRoot<Guid>
    {
        private class ProtectedGas : ValueObject
        {

        }
        private class CompressedGas : ValueObject
        {
            
        }
        private CompressedGas compressedGas { get; }
        private List<ProtectedGas> protectedGases { get; }
        public List<Robot> robots { get; set; }
        // private表示不能直接修改这个值
        // 在构造时确定类型后，就不允许变化了
        public StationType stationType { get; private set; }

        public String Name { get; set; }
        public String Description { get; set; }
        public String Remarks { get; set; }
        public String IsEnabled { get; set; }
        public String IsDeleted { get; set; }
        public String SkillScore { get; set; }
        
        private Station()  { }
        public Station(Guid id, StationType st) : base(id) {
            stationType = st;
        }
        public bool powerOn()
        {
            // 上电，可能包含机器人的上电
            return false;
        }
        public bool start()
        {
            // 开始加工
            return false;
        }
        public void working()
        {
            // 加工过程，它应该按照生产节拍反复调用
            // 这儿逻辑，比如减少气体量，耗材量，保养周期等等
        }
    }
}
