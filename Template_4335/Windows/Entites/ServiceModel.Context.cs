﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Template_4335.Windows.Entites
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WordExcelDatabaseEntities : DbContext
    {
        public WordExcelDatabaseEntities()
            : base("name=WordExcelDatabaseEntities")
        {
        }
        private static WordExcelDatabaseEntities _context = new WordExcelDatabaseEntities();
        public static WordExcelDatabaseEntities GetContext()
        {
            if (_context == null)
                _context = new WordExcelDatabaseEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Services> Services { get; set; }
    }
}
