//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OXo.Repositories
{
    using System;
    using System.Collections.Generic;
    
    public partial class QuestionAnswer
    {
        public int id { get; set; }
        public Nullable<int> QuestionNo { get; set; }
        public string Question { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string Answer { get; set; }
        public string Level { get; set; }
        public string Theme { get; set; }
        public Nullable<int> Bonus { get; set; }
        public Nullable<int> ResponseTime { get; set; }
    }
}