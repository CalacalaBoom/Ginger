using System;
using System.Collections.Generic;
using System.Linq;
using SqlSugar;
namespace $ext_safeprojectname$.Core.Models
{
    /// <summary>
    /// 
    ///</summary>
    [SugarTable("testtb")]
    public class Testtb
    {
        /// <summary>
        ///  
        /// 默认值: 
        ///</summary>
         [SugarColumn(ColumnName="Id" ,IsPrimaryKey = true   )]
         public int Id { get; set; }
        /// <summary>
        ///  
        /// 默认值: 
        ///</summary>
         [SugarColumn(ColumnName="Name"    )]
         public string Name { get; set; }
        /// <summary>
        ///  
        /// 默认值: 
        ///</summary>
         [SugarColumn(ColumnName="Sex"    )]
         public string Sex { get; set; }
        /// <summary>
        ///  
        /// 默认值: 
        ///</summary>
         [SugarColumn(ColumnName="Telephone"    )]
         public string Telephone { get; set; }
    }
}
