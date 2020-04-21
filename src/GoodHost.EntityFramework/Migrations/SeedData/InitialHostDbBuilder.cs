using GoodHost.EntityFramework;
using EntityFramework.DynamicFilters;

namespace GoodHost.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly GoodHostDbContext _context;

        public InitialHostDbBuilder(GoodHostDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
