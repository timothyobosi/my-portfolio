public class PortfolioContext : DbContext
{
    public PortfolioContext(DbContextOptions<PortfolioContext> options): base(options){}

    public DbSet<Experience> Experiences{
        get;
        set;
    }
    public DbSet<Education> Educations{
        get;
        set;
    }
    public DbSet<Skill> Skills{
        get;
        set;
    }
    public DbSet<Award> Awards{
        get;
        set;
    }
}