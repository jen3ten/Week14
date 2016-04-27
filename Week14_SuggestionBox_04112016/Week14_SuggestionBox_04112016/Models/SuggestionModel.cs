using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Week14_SuggestionBox_04112016.Models
{
    public class SuggestionModel
    {
        /*Variables*/
        private string topic;
        private string suggestion;

        /*Properties*/
        public string Topic { get; set; }
        public string Suggestion { get; set; }

        [Key]
        public int RecordNum { get; set; }
    }
}