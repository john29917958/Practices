using System;
using System.IO;
using Composite.Nodes;
using Composite.Visitors;
using Directory = Composite.Nodes.Directory;
using File = Composite.Nodes.File;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            string testDirPath = "Test";
            string testFilePath = Path.Combine("Test", "Test.txt");

            if (!System.IO.Directory.Exists(testDirPath))
                System.IO.Directory.CreateDirectory(testDirPath);

            if (!System.IO.File.Exists(testFilePath))
                System.IO.File.Create(testFilePath);

            Node root = new Directory(System.IO.Directory.GetCurrentDirectory());
            root.Add(new File("Composite.exe"));

            Node testDir = new Directory(testDirPath);
            root.Add(testDir);

            testDir.Add(new File(testFilePath));

            VisitorRunner.Run(root, new PrintVisitor());
            
            SearchVisitor searchVisitor = new SearchVisitor(testFilePath);
            VisitorRunner.Run(root, searchVisitor);

            foreach (Node node in searchVisitor.Results)
            {
                Console.WriteLine("Found node: " + node.Path);
            }

            Console.ReadLine();
        }
    }
}
