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
    
    public partial class Employee
    {
        public int id_employee { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public Nullable<int> id_position { get; set; }
        public string adress { get; set; }
        public string number { get; set; }
        public int id_user { get; set; }
    
        public virtual Position Position { get; set; }
        public virtual users users { get; set; }
    }
}