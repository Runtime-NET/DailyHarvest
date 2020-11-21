﻿using vino.EntityFramework;
using EntityFramework.DynamicFilters;

namespace vino.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly vinoDbContext _context;

        public InitialHostDbBuilder(vinoDbContext context)
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
