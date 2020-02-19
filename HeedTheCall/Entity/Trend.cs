using System;
using System.Collections.Generic;
using System.Text;

namespace HeedTheCall.Entity
{
    public partial class Trend
    {
       /* public Trend()
        {
            InverseInReplyToStatus = new HashSet<Trend>();
        }*/

        public long Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string PromotedContent { get; set; }
        public long? Query { get; set; }
        public long? TweetVolume { get; set; }
    }
}
