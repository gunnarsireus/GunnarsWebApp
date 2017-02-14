using GunnarsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Globalization;
using System.IO;
using System.Text;

namespace GunnarsWebApp.DAL
{
    public class GunnarsWebAppInitilizer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GunnarsWebAppContext>
    {
        protected override void Seed(GunnarsWebAppContext context)
        {
            var sqlFiles = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + Path.DirectorySeparatorChar + "DAL", "*.sql").ToList();
            foreach (string file in sqlFiles)
            {
                context.Database.ExecuteSqlCommand(File.ReadAllText(file, Encoding.Default));
            }
            base.Seed(context);
        }
    }
}