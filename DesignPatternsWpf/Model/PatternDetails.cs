using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsWpf.Model
{
    public class PatternDetails
    {
        public PatternDetails()
        {
            Patterns = new List<PatternDetails>();

        }
        public string Name { get; set; }

        public string Header { get; set; }

        public Action Method { get; set; }

        public bool IsGofPattern { get; set; }

        public string Url { get; set; }

        public string OutPut { get; set; }

        public List<PatternDetails> Patterns { get; set; }
    }
}
