using System;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.Users;

namespace SmartAbp.Users
{
  // 技能接口，满足用户技能及设备技能要求匹配的需求。
  public interface ITechnicalSkill {
    bool matchSkill(ITechnicalSkill other);
  }
}