namespace CSharpEgitimKampi301.DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()//update metodunu çalıştırırsan yapılacak değişiklikler aşağıda gösterildi
        {
            AddColumn("dbo.Customers", "CustomerStatus", c => c.Boolean(nullable: false));
        }
        
        public override void Down()//eğer vazgeçersen bu migration silinecek
        {
            DropColumn("dbo.Customers", "CustomerStatus");
        }
    }
}
