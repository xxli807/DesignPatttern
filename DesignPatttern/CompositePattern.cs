﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    /// <summary>
    /// Composte is main used for separate the local part and global section
    /// Sometimes the logic to deal with simple object and complex object is different
    /// </summary>
    public class CompositePattern
    {
        public void Run()
        {
            ComplexDirectory complexDirectory = new ComplexDirectory("complex directory");
            complexDirectory.Add(new Folder("new Folder"));

            ComplexDirectory complexFiles = new ComplexDirectory("complex files");
            complexFiles.Add(new File("add complex file"));
            complexDirectory.Add(new File("add a new file"));
            complexDirectory.Add(complexFiles);

            complexDirectory.Show();
        }

    }


    public abstract class Directory
    {
        public string name;
        public Directory(string name)
        {
            this.name = name;
        }
        public abstract void Add();
        public abstract void Remove();
        public abstract void Show();
    }

    public class Folder : Directory
    {
        public Folder(string name)
            : base(name)
        {
        }

        public override void Add()
        {
            Console.WriteLine("Add a new folder");
        }
        public override void Remove()
        {
            Console.WriteLine("Remove a folder");
        }

        public override void Show()
        {
            Console.WriteLine("A new folder created.");
        }
    }

    public class File : Directory
    {
        public File(string name)
            : base(name)
        {
        }

        public override void Add()
        {
            Console.WriteLine("Add a new File");
        }
        public override void Remove()
        {
            Console.WriteLine("Remove a File");
        }
        public override void Show()
        {
            Console.WriteLine("A new File created.");
        }
    }

    public class ComplexDirectory : Directory
    {
        private List<Directory> complexDirectory = new List<Directory>();

        public ComplexDirectory(string name)
            : base(name)
        {
        }

        public override void Add(Directory d)
        {
            complexDirectory.Add(d);
        }

        public override void Remove(Directory d)
        {
            complexDirectory.Remove(d);
        }

        public override void Show()
        {

            foreach (var item in complexDirectory)
            {
                item.Show();
            }
        }


    }





}





