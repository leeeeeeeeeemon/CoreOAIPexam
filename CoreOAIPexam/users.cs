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
    
    public partial class users
    {
        public users()
        {
            this.Employee = new HashSet<Employee>();
            this.Sale_Auto = new HashSet<Sale_Auto>();
        }
    
        public int id_user { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string mail { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public Nullable<decimal> balance { get; set; }
    
        public virtual ICollection<Employee> Employee { get; set; }
        public virtual ICollection<Sale_Auto> Sale_Auto { get; set; }
    }
}