using Microsoft.AspNetCore.Identity;
using SignalRChatApplicationDemo.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace SignalRChatApplicationDemo.DAL

{
    public class UserDbContext : System.Data.Entity.DbContext
    {
        protected UserDbContext(DbCompiledModel model) : base(model)
        {
        }
        public DbSet<UserModel> Users { get; set; }
    }
}
