//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hackathon.Adapters
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChallengeMultipleChoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChallengeMultipleChoice()
        {
            this.ChallengeMultipleChoiceItems = new HashSet<ChallengeMultipleChoiceItem>();
            this.Challenges = new HashSet<Challenge>();
        }
    
        public System.Guid Id { get; set; }
        public string ExpectedAnswer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChallengeMultipleChoiceItem> ChallengeMultipleChoiceItems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Challenge> Challenges { get; set; }
    }
}