using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectWorks.AmrApp
{
    public interface IChangeConnectionString
    {
        string GetDBContext(int filialId);
    }
}
