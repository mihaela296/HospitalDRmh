//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HospitalD
{
    using System;
    using System.Collections.Generic;
    
    public partial class PatientProcedures
    {
        public int ID_PatientProcedure { get; set; }
        public int ID_Patient { get; set; }
        public int ID_Procedure { get; set; }
    
        public virtual MedicalProcedures MedicalProcedures { get; set; }
        public virtual Patients Patients { get; set; }
    }
}
