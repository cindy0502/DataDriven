using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestSurvay.Model
{
    public class Question
    {
        public int id { get; set; }
        public string text { get; set; }
        public string type { get; set; }
        public int? nextQId { get; set; }
    }
}