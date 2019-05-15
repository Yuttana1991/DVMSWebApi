using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DVMSWebApi.Models
{
    public class DVMSContext : DbContext
    {
        public DVMSContext()
        {
        }
        public DVMSContext(DbContextOptions<DVMSContext> options) 
            : base(options)
        {
        }

        //public virtual DbSet<visitorCarType> visitorCarType { get; set; }

        public virtual DbSet<vtran> Vtrans { set; get; }
        //public virtual DbSet<vtran> vtran { set; get; }
        //public virtual DbSet<View_TransAuto> View_TransAuto { get; set; }
        
    }
}
