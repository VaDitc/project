//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCSC
{
    using System;
    using System.Collections.Generic;
    
    public partial class DataByHours
    {
        public int ID { get; set; }
        public Nullable<int> ScalesNumberID { get; set; }
        public Nullable<double> Weight { get; set; }
        public Nullable<System.TimeSpan> Time { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual ScalesInformation ScalesInformation { get; set; }
    }
}
