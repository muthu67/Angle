namespace Angle
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<APILog> APILogs { get; set; }
        public virtual DbSet<APIUser> APIUsers { get; set; }
        public virtual DbSet<App> Apps { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<AppUserClaim> AppUserClaims { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<DocumentDetail> DocumentDetails { get; set; }
        public virtual DbSet<DocumentModule> DocumentModules { get; set; }
        public virtual DbSet<DocumentType> DocumentTypes { get; set; }
        public virtual DbSet<EmployeePassport> EmployeePassports { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ServiceAuth> ServiceAuths { get; set; }
        public virtual DbSet<ServiceAuthLog> ServiceAuthLogs { get; set; }
        public virtual DbSet<ServiceTypeSearch> ServiceTypeSearches { get; set; }
        public virtual DbSet<tblStudent> tblStudents { get; set; }
        public virtual DbSet<TravelClassMaster> TravelClassMasters { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<User1> Users1 { get; set; }
        public virtual DbSet<crud> cruds { get; set; }
        public virtual DbSet<crud1> crud1 { get; set; }
        public virtual DbSet<CT> CTs { get; set; }
        public virtual DbSet<Cust> Custs { get; set; }
        public virtual DbSet<Employees1> Employees1 { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Token> Tokens { get; set; }
        public virtual DbSet<User_> User_ { get; set; }
        public virtual DbSet<Employee1> Employees2 { get; set; }
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public virtual DbSet<FileMergeRequest> FileMergeRequests { get; set; }
        public virtual DbSet<FileMergeRequest_Logs> FileMergeRequest_Logs { get; set; }
        public virtual DbSet<legalCategory> legalCategories { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<ULogin> ULogins { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<APIUser>()
                .Property(e => e.Remarks)
                .IsUnicode(false);

            modelBuilder.Entity<APIUser>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<APIUser>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<App>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<App>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<App>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<AppUser>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<AppUserClaim>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Mobileno)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.EmailID)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentDetail>()
                .Property(e => e.DocumentDetailID)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentDetail>()
                .Property(e => e.FileType)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentDetail>()
                .Property(e => e.DirectoryName)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentDetail>()
                .Property(e => e.MimeType)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentDetail>()
                .Property(e => e.UploadedBy)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentModule>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ServiceAuth>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceAuth>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceAuth>()
                .Property(e => e.Salt)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceAuthLog>()
                .Property(e => e.AccountName)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceAuthLog>()
                .Property(e => e.IPAddress)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceAuthLog>()
                .Property(e => e.RequestHeader)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceAuthLog>()
                .Property(e => e.WebMethodName)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceAuthLog>()
                .Property(e => e.ErrorDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceTypeSearch>()
                .Property(e => e.SourceCountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceTypeSearch>()
                .Property(e => e.SourceCountryName)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceTypeSearch>()
                .Property(e => e.DestinationCountryCode)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceTypeSearch>()
                .Property(e => e.DestinationCountryName)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceTypeSearch>()
                .Property(e => e.ServiceCode)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceTypeSearch>()
                .Property(e => e.ServiceCodeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceTypeSearch>()
                .Property(e => e.TypeCode)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceTypeSearch>()
                .Property(e => e.TypeCodeDescription)
                .IsUnicode(false);

            modelBuilder.Entity<ServiceTypeSearch>()
                .Property(e => e.SearchCriteria)
                .IsUnicode(false);

            modelBuilder.Entity<tblStudent>()
                .Property(e => e.StudentName)
                .IsUnicode(false);

            modelBuilder.Entity<TravelClassMaster>()
                .Property(e => e.AirlineCode)
                .IsUnicode(false);

            modelBuilder.Entity<TravelClassMaster>()
                .Property(e => e.Class)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.CreatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.UpdatedBy)
                .IsUnicode(false);

            modelBuilder.Entity<User1>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<crud>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<crud>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<crud>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<crud1>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<crud1>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<crud1>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<CT>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<CT>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<CT>()
                .Property(e => e.Mobileno)
                .IsUnicode(false);

            modelBuilder.Entity<CT>()
                .Property(e => e.EmailID)
                .IsUnicode(false);

            modelBuilder.Entity<Cust>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Cust>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Cust>()
                .Property(e => e.Mobileno)
                .IsUnicode(false);

            modelBuilder.Entity<Cust>()
                .Property(e => e.EmailID)
                .IsUnicode(false);

            modelBuilder.Entity<Employees1>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Employees1>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Employees1>()
                .Property(e => e.Gender)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<User_>()
                .HasMany(e => e.Tokens)
                .WithOptional(e => e.User_)
                .HasForeignKey(e => e.UserID_);

            modelBuilder.Entity<User_>()
                .HasMany(e => e.Tokens1)
                .WithOptional(e => e.User_1)
                .HasForeignKey(e => e.UserID_);

            modelBuilder.Entity<Employee1>()
                .Property(e => e.employeeName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee1>()
                .Property(e => e.employeeLocation)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.Pincode)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.State)
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeDetail>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest>()
                .Property(e => e.DocumentList)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest>()
                .Property(e => e.FileAction)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest>()
                .Property(e => e.FileOutputType)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest>()
                .Property(e => e.FileConversionType)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest>()
                .Property(e => e.MergedFile)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest_Logs>()
                .Property(e => e.DocumentList)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest_Logs>()
                .Property(e => e.FileAction)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest_Logs>()
                .Property(e => e.FileOutputType)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest_Logs>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest_Logs>()
                .Property(e => e.FileConversionType)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest_Logs>()
                .Property(e => e.MergedFile)
                .IsUnicode(false);

            modelBuilder.Entity<FileMergeRequest_Logs>()
                .Property(e => e.DetailedStatus)
                .IsUnicode(false);

            modelBuilder.Entity<legalCategory>()
                .Property(e => e.categoryName)
                .IsUnicode(false);

            modelBuilder.Entity<legalCategory>()
                .Property(e => e.categorytype)
                .IsUnicode(false);

            modelBuilder.Entity<legalCategory>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.studentName)
                .IsUnicode(false);

            modelBuilder.Entity<Student>()
                .Property(e => e.studentLocation)
                .IsUnicode(false);

            modelBuilder.Entity<ULogin>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ULogin>()
                .Property(e => e.pass)
                .IsUnicode(false);
        }
    }
}
