using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{

    /// <summary>
    /// to save the new object consumer....as we know everytime when we create a 
    /// object, CPU, MEMORY wil be comsumed 
    /// </summary>
    public class PrototypePattern
    {
        public void Run()
        {
            TablePrototype tableProtople = new ConcreateTable("ComputerTable");
            TablePrototype tableClone = tableProtople.Clone() as ConcreateTable;


        }

    }

    public abstract class TablePrototype
    {
        public string TableId { get; set; }

        public TablePrototype(string id)
        {
            this.TableId = id;
        }

        public abstract TablePrototype Clone();
    }


    public class ConcreateTable : TablePrototype
    {
        //inherite the constructor from the partent class
        public ConcreateTable(string id)
            : base(id)
        {
        }

        public override TablePrototype Clone()
        {
            return (TablePrototype)this.MemberwiseClone();
        }


    }

}
