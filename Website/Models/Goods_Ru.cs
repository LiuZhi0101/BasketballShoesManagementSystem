//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Goods_Ru
    {
        public int Ru_ID { get; set; }
        public string Ru_Uid { get; set; }
        public string Ru_Name { get; set; }
        public string Ru_Brand { get; set; }
        public string Ru_Spec { get; set; }
        public string Ru_Type { get; set; }
        public int Ru_Number { get; set; }
        public System.DateTime Ru_Time { get; set; }
        public int Ru_state { get; set; }
        public Nullable<int> Ru_Place { get; set; }
    
        public virtual Room Room { get; set; }
    }
}
