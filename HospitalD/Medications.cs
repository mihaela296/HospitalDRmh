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
    
    public partial class Medications
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Medications()
        {
            this.PatientMedicalRecord = new HashSet<PatientMedicalRecord>();
        }
    
        public int ID_Medication { get; set; }
        public string Name { get; set; }
        public int DailyDosage { get; set; }
        public int Duration { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientMedicalRecord> PatientMedicalRecord { get; set; }
    }
}
