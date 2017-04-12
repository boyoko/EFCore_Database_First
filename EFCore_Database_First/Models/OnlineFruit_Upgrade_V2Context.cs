using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCore_Database_First.Models
{
    public partial class OnlineFruit_Upgrade_V2Context : DbContext
    {
        public virtual DbSet<ProductLibrary> ProductLibrary { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            optionsBuilder.UseSqlServer(@"Server=.;Database=OnlineFruit_Upgrade_V2;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductLibrary>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK_ProductLibrary");

                entity.Property(e => e.AcreateDate)
                    .HasColumnName("ACreateDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AmodifyDate)
                    .HasColumnName("AModifyDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.AspecialType).HasColumnName("ASpecialType");

                entity.Property(e => e.AsportsType).HasColumnName("ASportsType");

                entity.Property(e => e.Astatus).HasColumnName("AStatus");

                entity.Property(e => e.Attributes).HasMaxLength(500);

                entity.Property(e => e.AvgCommentScore).HasColumnType("decimal");

                entity.Property(e => e.BookBeginTime).HasColumnType("varchar(20)");

                entity.Property(e => e.BookEndTime).HasColumnType("varchar(20)");

                entity.Property(e => e.DiscountPrice).HasColumnType("decimal");

                entity.Property(e => e.IsAvailable).HasColumnName("isAvailable");

                entity.Property(e => e.IsImportFood).HasColumnName("isImportFood");

                entity.Property(e => e.IsOrganicFood).HasColumnName("isOrganicFood");

                entity.Property(e => e.LeastbuyMg)
                    .HasColumnName("leastbuy_mg")
                    .HasColumnType("decimal");

                entity.Property(e => e.LongDescription).HasColumnName("long_description");

                entity.Property(e => e.MemberDiscount)
                    .HasColumnType("decimal")
                    .HasDefaultValueSql("10.0");

                entity.Property(e => e.MinQuantity).HasDefaultValueSql("1");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.Plunum)
                    .IsRequired()
                    .HasColumnName("PLUNum")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.PollingImg1).HasMaxLength(100);

                entity.Property(e => e.PollingImg2).HasMaxLength(100);

                entity.Property(e => e.PollingImg3).HasMaxLength(100);

                entity.Property(e => e.Price).HasColumnType("decimal");

                entity.Property(e => e.ProductCode)
                    .HasColumnName("productCode")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductName)
                    .HasColumnName("productName")
                    .HasMaxLength(100);

                entity.Property(e => e.Ptype).HasColumnName("PType");

                entity.Property(e => e.QrcodeImg).HasMaxLength(500);

                entity.Property(e => e.ShortDescription)
                    .HasColumnName("short_description")
                    .HasMaxLength(100);

                entity.Property(e => e.SpId).HasColumnName("spID");

                entity.Property(e => e.Tags).HasMaxLength(200);

                entity.Property(e => e.Thumbnail)
                    .HasColumnName("thumbnail")
                    .HasMaxLength(100);

                entity.Property(e => e.TimePrecision).HasColumnType("varchar(20)");

                entity.Property(e => e.TypeIds).HasColumnType("varchar(200)");

                entity.Property(e => e.TypeNames).HasMaxLength(500);

                entity.Property(e => e.UnitName).HasMaxLength(20);
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.Property(e => e.ShopId).HasColumnName("shopID");

                entity.Property(e => e.AadminRole).HasColumnName("AAdminRole");

                entity.Property(e => e.AapplyPayLimitDays).HasColumnName("AApplyPayLimitDays");

                entity.Property(e => e.AapplyPayLimitMoney)
                    .HasColumnName("AApplyPayLimitMoney")
                    .HasColumnType("decimal");

                entity.Property(e => e.Aarea)
                    .HasColumnName("AArea")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AareaList)
                    .HasColumnName("AAreaList")
                    .HasMaxLength(200);

                entity.Property(e => e.AbillGenerateType).HasColumnName("ABillGenerateType");

                entity.Property(e => e.AcertificateId).HasColumnName("ACertificateId");

                entity.Property(e => e.Acity)
                    .HasColumnName("ACity")
                    .HasMaxLength(50);

                entity.Property(e => e.Acounty)
                    .HasColumnName("ACounty")
                    .HasMaxLength(50);

                entity.Property(e => e.AcreateDate)
                    .HasColumnName("ACreateDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200);

                entity.Property(e => e.Adistrict)
                    .HasColumnName("ADistrict")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AdistrictId)
                    .HasColumnName("ADistrictID")
                    .HasMaxLength(200);

                entity.Property(e => e.Afrom)
                    .HasColumnName("AFrom")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("N'manager'");

                entity.Property(e => e.AgroupId).HasColumnName("AGroupID");

                entity.Property(e => e.AisForShop).HasColumnName("AIsForShop");

                entity.Property(e => e.AisSetBillRule).HasColumnName("AIsSetBillRule");

                entity.Property(e => e.AisShare).HasColumnName("AIsShare");

                entity.Property(e => e.AmemDiscount)
                    .HasColumnName("AMemDiscount")
                    .HasColumnType("decimal");

                entity.Property(e => e.AmodifyDate)
                    .HasColumnName("AModifyDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.Aowner).HasColumnName("AOwner");

                entity.Property(e => e.ApplyTime).HasColumnType("datetime");

                entity.Property(e => e.Aprovince)
                    .HasColumnName("AProvince")
                    .HasMaxLength(50);

                entity.Property(e => e.AreaIds).HasColumnType("varchar(200)");

                entity.Property(e => e.Asort)
                    .HasColumnName("ASort")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Astatus)
                    .HasColumnName("AStatus")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.AuditTime).HasColumnType("datetime");

                entity.Property(e => e.AverageCost)
                    .HasColumnName("averageCost")
                    .HasColumnType("decimal");

                entity.Property(e => e.BusinessId).HasColumnName("businessID");

                entity.Property(e => e.CloseTime)
                    .HasColumnName("closeTime")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.CourseTypeIds)
                    .HasColumnName("courseTypeIds")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CourseTypeNames)
                    .HasColumnName("courseTypeNames")
                    .HasMaxLength(100);

                entity.Property(e => e.Cx)
                    .HasColumnName("CX")
                    .HasColumnType("decimal");

                entity.Property(e => e.Cy)
                    .HasColumnName("CY")
                    .HasColumnType("decimal");

                entity.Property(e => e.DeliverRemark).HasMaxLength(200);

                entity.Property(e => e.Discount)
                    .HasColumnName("discount")
                    .HasColumnType("decimal");

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.Employees).HasMaxLength(20);

                entity.Property(e => e.ExpressList).HasColumnType("varchar(500)");

                entity.Property(e => e.ForshopIds)
                    .HasColumnName("ForshopIDs")
                    .HasColumnType("varchar(500)");

                entity.Property(e => e.Groupid)
                    .HasColumnName("groupid")
                    .HasMaxLength(50);

                entity.Property(e => e.ImagePath)
                    .HasColumnName("imagePath")
                    .HasMaxLength(200);

                entity.Property(e => e.Introduce).HasColumnName("introduce");

                entity.Property(e => e.InvoiceTitles).HasMaxLength(200);

                entity.Property(e => e.IsAppUse).HasColumnName("isAppUse");

                entity.Property(e => e.IsDefault)
                    .HasColumnName("isDefault")
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsSpecialFunds).HasDefaultValueSql("0");

                entity.Property(e => e.IsWechatUse).HasColumnName("isWechatUse");

                entity.Property(e => e.LogoUrl)
                    .HasColumnName("logoUrl")
                    .HasMaxLength(200);

                entity.Property(e => e.MinOrderMoney).HasColumnType("decimal");

                entity.Property(e => e.OpenTime)
                    .HasColumnName("openTime")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.PayQrCodePath).HasColumnType("varchar(100)");

                entity.Property(e => e.QrcodePath)
                    .HasColumnName("QRCodePath")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Remark).HasMaxLength(200);

                entity.Property(e => e.ServiceDescription)
                    .HasColumnName("serviceDescription")
                    .HasMaxLength(500);

                entity.Property(e => e.ServiceLevel).HasColumnName("serviceLevel");

                entity.Property(e => e.ServiceUrl)
                    .HasColumnName("serviceUrl")
                    .HasMaxLength(200);

                entity.Property(e => e.ShopInviCode).HasColumnType("varchar(50)");

                entity.Property(e => e.ShopLeftMoney).HasColumnType("decimal");

                entity.Property(e => e.ShopLinkName)
                    .HasColumnName("shopLinkName")
                    .HasMaxLength(20);

                entity.Property(e => e.ShopLinkTel)
                    .HasColumnName("shopLinkTel")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.ShopName)
                    .HasColumnName("shopName")
                    .HasMaxLength(50);

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.ThumbnailPath)
                    .HasColumnName("thumbnailPath")
                    .HasMaxLength(200);

                entity.Property(e => e.Typeid).HasColumnName("typeid");
            });
        }
    }
}