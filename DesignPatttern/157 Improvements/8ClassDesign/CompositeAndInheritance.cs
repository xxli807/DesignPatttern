using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern._157_Improvements._8ClassDesign
{
    class CompositeAndInheritance
    {
    }


    #region inheritance
    public abstract class stream{

    }

    public class fileStream : stream
    {

    }
    public class DBStream : stream
    {

    }


    #endregion


#region  composite

    class Culture
    {

    }

    class Context
    {

    }

    public class thread
    {
        private Culture _culture;
        private Context _context;
    }


#endregion 




}
 