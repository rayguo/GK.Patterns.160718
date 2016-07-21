using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            UseVisitor();
        }

        private static void UseVisitor()
        {
            var root = Blog.RootCategory;

            Console.WriteLine("Before Visitation:");
            PrintBlogComponents(root);

            // Perform visitation
            VisitBlogComponents(root);

            Console.WriteLine("\nAfter Visitation:");
            PrintBlogComponents(root);
        }

        private static void VisitBlogComponents(BlogCategory root)
        {
            var visitor = new BlogEntryVisitor();
            root.Accept(visitor);
        }

        private static void PrintBlogComponents(BlogCategory root)
        {
            foreach (var component in root.FindAll())
            {
                Console.WriteLine(component);
            }
        }
    }
}
