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
    
    public partial class Auto
    {
        public Auto()
        {
            this.Sale_Auto = new HashSet<Sale_Auto>();
        }
    
        public int id_auto { get; set; }
        public string model { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public Nullable<int> engine_power { get; set; }
        public string acceleration_from_0_to_100_sec____ { get; set; }
        public Nullable<decimal> price { get; set; }
        public string characteristic { get; set; }
    
        public virtual ICollection<Sale_Auto> Sale_Auto { get; set; }
    }
}
