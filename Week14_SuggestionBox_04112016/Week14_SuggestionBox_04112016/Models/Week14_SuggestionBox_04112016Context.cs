using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Week14_SuggestionBox_04112016.Models
{
    public class Week14_SuggestionBox_04112016Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Week14_SuggestionBox_04112016Context() : base("name=Week14_SuggestionBox_04112016Context")
        {
        }

        public System.Data.Entity.DbSet<Week14_SuggestionBox_04112016.Models.SuggestionModel> SuggestionModels { get; set; }
    }
}
