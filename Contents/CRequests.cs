namespace Contents
{
    public class CRequests
    {
        public static List<CRequests> requests = new List<CRequests>();
        public string Subject { get; set; }
        public string Requester { get; set; }
        public string Style { get; set; }
        public bool Ai { get; set; }
        public string Notes { get; set; }
        public CRequests(string requester, string subject, string style, bool ai, string notes)
        {
            Subject = subject;
            Requester = requester;
            Style = style;
            Ai = ai;
            Notes = notes;
            requests.Add(this);
        }
    }
}
