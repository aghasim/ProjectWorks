using ProjectWorks.AmrApp;
using ProjectWorks.AmrApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWorks.Task.Services
{
    public class AmrAppRepository
    {
        private readonly IChangeConnectionString connString;
        private readonly AmrAmmContextFactory amrAmmContextFactory;

        public aspnetsmrContext context;

        public AmrAppRepository(IChangeConnectionString connString, AmrAmmContextFactory amrAmmContextFactory)
        {
            this.connString = connString;
            this.amrAmmContextFactory = amrAmmContextFactory;
        }

        public void SetConnString(int filialId)
        {
           this.context = this.amrAmmContextFactory.GetDbContext(this.connString.GetDBContext(filialId));
        }
    }
}
