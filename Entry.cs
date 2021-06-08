using System;

namespace expensee
{
    public class Entry
    {
        public string category { get; set; }
        public string title { get; set; }
        public string notes { get; set; }
        public Int32 expense { get; set; }
        public DateTime date { get; set; }
    }
}
