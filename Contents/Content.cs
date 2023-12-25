namespace Contents
{
    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Ups { get; set; }

        public Content(int id, string title, string author, int ups)
        {
            Id = id;
            Title = title;
            Author = author;
            Ups = ups;
        }
    }

    public class ContentDictionary
    {
        public static Dictionary<int, Content> contents = new Dictionary<int, Content>();

        public void AddContent(Content content)
        {
            contents[content.Id] = content;
        }
        //currently not required
        //public Content GetContentById(int id)
        //{
        //    if (contents.ContainsKey(id))
        //    {
        //        return contents[id];
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        //public static int GetContentCount()
        //{
        //    return contents.Count;
        //}
    }
}