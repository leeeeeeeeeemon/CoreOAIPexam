//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CoreOAIPexam
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale_Auto
    {
        public int id_Sale_Auto { get; set; }
        public int id_user { get; set; }
        public int id_auto { get; set; }
        public Nullable<int> id_discounts { get; set; }
        public string passport { get; set; }
        public string tlephon_number { get; set; }
    
        public virtual Auto Auto { get; set; }
        public virtual Discounts Discounts { get; set; }
        public virtual users users { get; set; }
    }
}
