using Microsoft.EntityFrameworkCore;
using SmartAbp.Books;
using SmartAbp.Stations;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace SmartAbp.EntityFrameworkCore
{
    public static class SmartAbpDbContextModelCreatingExtensions
    {
        public static void ConfigureSmartAbp(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(SmartAbpConsts.DbTablePrefix + "YourEntities", SmartAbpConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});

            //下面是创建数据库表时候用的语句
            builder.Entity<Book>(b =>
            {
                b.ToTable(SmartAbpConsts.DbTablePrefix + "Books",
                          SmartAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
            //下面是创建数据库表时候用的语句
            builder.Entity<Station>(b =>
            {
                b.ToTable(SmartAbpConsts.DbTablePrefix + "Stations",
                          SmartAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
            //下面是创建数据库表时候用的语句
            builder.Entity<WeldSection>(b =>
            {
                b.ToTable(SmartAbpConsts.DbTablePrefix + "WeldSections",
                          SmartAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
            //下面是创建数据库表时候用的语句
            builder.Entity<Robot>(b =>
            {
                b.ToTable(SmartAbpConsts.DbTablePrefix + "Robots",
                          SmartAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
                //b.Property(x => x.Name).IsRequired().HasMaxLength(128);
            });
            //下面是创建数据库表时候用的语句
            builder.Entity<TransportRobot>(b =>
            {
                b.ToTable(SmartAbpConsts.DbTablePrefix + "TransportRobots",
                          SmartAbpConsts.DbSchema);
                b.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<Station.ProtectedGas>(b =>
            {
                b.ToTable(SmartAbpConsts.DbTablePrefix + "ProtectedGas",
                          SmartAbpConsts.DbSchema);
                b.Property<int>("Id").IsRequired();  // Id is a shadow property

                b.HasKey("Id");   // Id is a shadow property
                b.ConfigureByConvention(); //auto configure for the base class props
            });
            builder.Entity<Station.CompressedGas>(b =>
            {
                b.ToTable(SmartAbpConsts.DbTablePrefix + "CompressedGas",
                          SmartAbpConsts.DbSchema);
                b.Property<int>("Id").IsRequired();  // Id is a shadow property

                b.HasKey("Id");   // Id is a shadow property
                b.ConfigureByConvention(); //auto configure for the base class props
            });
        }
    }
}