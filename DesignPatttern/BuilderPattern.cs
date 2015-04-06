using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    /// <summary>
    /// BuilderPattern means separate the complex object builder and presention. Made the same bulder process 
    /// can be used for different presentation. This can be used for client/ detail product coupling loose
    /// </summary>

    public class BuilderPattern
    {
        public void Run()
        {
            Builder tom = new ConcreteBuilderTom();
            Builder lee = new ConcreteBuilderLee();

            Boss boss = new Boss();
            boss.Construct(tom);
            tom.GetTable();

            boss.Construct(lee);
            lee.GetTable();

        
        }
         
    }

    /// <summary>
    /// In the builder pattern, there must be a boss who direct the other people to do some works
    /// </summary>
    public class Boss
    {
        public void Construct(Builder builder)
        {
            builder.BuildTableBoard();
            builder.BuildTableLegs();
        }


    }

    public class Table
    {
        private IList<string> parts = new List<string>();
        
        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("starting assemble");
            foreach (string part in parts)
            {
                Console.WriteLine("part: " + part + " is already installed");
            }
        }
       

    }



    public abstract class Builder
    {
        //assemble table legs

        public abstract void BuildTableLegs();
        public abstract void BuildTableBoard();
        public abstract Table GetTable();

    }


    public class ConcreteBuilderTom : Builder
    {
        Table table = new Table();
        public override void BuildTableLegs()
        {
            //throw new NotImplementedException();
            table.Add("Legs");
        }

        public override void BuildTableBoard()
        {
            //throw new NotImplementedException();
            table.Add("Borard");
        }

        public override Table GetTable()
        {
            //throw new NotImplementedException();
            return this.table;
        }

    }


    public class ConcreteBuilderLee : Builder
    {
        Table table = new Table();
        public override void BuildTableLegs()
        {
            //throw new NotImplementedException();
            table.Add("Legs2");
        }

        public override void BuildTableBoard()
        {
            //throw new NotImplementedException();
            table.Add("Borard2");
        }

        public override Table GetTable()
        {
            //throw new NotImplementedException();
            return this.table;
        }

    }









}
