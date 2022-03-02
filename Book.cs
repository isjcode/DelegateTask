namespace Delegate
{
    public class Book
    {
        public string Name;
        public string AuthorName;
        public int PageCount;
        public string Code;
        public static int count = 0;

        public Book(string name, string author_name, int page_count)
        {
            count++;
            Name = name;
            AuthorName = author_name;
            PageCount = page_count;
            Code = Name.Substring(0, 2).ToUpper() + count.ToString();
        }
    }
}