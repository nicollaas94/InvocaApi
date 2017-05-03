using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoca.Core.Model
{
    public class QueryParameters
    {
        public string From { get; private set; }
        public string To { get; private set; }
        public int Limit { get; private set; }
        public string StartAfterTransactionId { get; private set; }
        public string IncludeColumns { get; private set; }
        public string ExcludeColumns { get; private set; }


        public void SetFrom(DateTime from) { this.From = from.ToString("yyyy-MM-dd"); }
        public void SetTo(DateTime to) { this.To = to.ToString("yyyy-MM-dd"); }
        public void SetLimit(int limit) { this.Limit = limit > 4000 ? 4000 : limit; }
        public void SetStartAfterTransactionId(string transactionId) { this.StartAfterTransactionId = transactionId; }
        public void SetIncludeColumns(params string[] includeColumns) { this.IncludeColumns = string.Join(",", includeColumns); }
        public void SetExcludeColumns(params string[] excludeColumns) { this.ExcludeColumns = string.Join(",", excludeColumns); }
    }
}
