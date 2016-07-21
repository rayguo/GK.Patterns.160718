namespace Visitor
{
    class BlogEntryVisitor : BlogComponentVisitor
    {
        public override void VisitEntry(BlogEntry entry)
        {
            // Add a day to blog entry date
            entry.Date = entry.Date.AddDays(1);
        }
    }
}
