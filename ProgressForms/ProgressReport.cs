using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgressForms
{
    public class ProgressReport
    {
        // 進捗状況が示す。仕事のタイトル
        public string WorkTitle { get; set; }
        public string MainMessage { get; set; }
        public string SubMessage { get; set; }
        public int Percent { get; set; }
    }
}
