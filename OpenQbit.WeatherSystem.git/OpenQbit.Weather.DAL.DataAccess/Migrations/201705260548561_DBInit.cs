namespace OpenQbit.Weather.DAL.DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        countryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Daydetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        DayDescription = c.String(),
                        NightDescription = c.String(),
                        Sunrise = c.DateTime(nullable: false),
                        Sunset = c.DateTime(nullable: false),
                        Moonrise = c.DateTime(nullable: false),
                        Moonset = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Forecast",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(nullable: false),
                        DaydetailId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Forecastdetail",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Time = c.DateTime(nullable: false),
                        Temperature = c.String(),
                        Windspeed = c.String(),
                        ForecastId = c.Int(nullable: false),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Forecast", t => t.ForecastId, cascadeDelete: true)
                .Index(t => t.ForecastId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Forecastdetail", "ForecastId", "dbo.Forecast");
            DropIndex("dbo.Forecastdetail", new[] { "ForecastId" });
            DropTable("dbo.Forecastdetail");
            DropTable("dbo.Forecast");
            DropTable("dbo.Daydetail");
            DropTable("dbo.Country");
        }
    }
}
