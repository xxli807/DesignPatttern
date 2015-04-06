using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatttern
{
    /// <summary>
    /// define a global interface (high level) and let child system can interact with it
    /// each desend system can invoke the "Facade" only
    /// 
    /// </summary>
    public class FacadePattern
    {
        public void Run()
        {
            EnrollNotifyFacade facede = new EnrollNotifyFacade();
            if (facede.Register("math", "jone"))
            {
                Console.WriteLine("successful");
            }
            else
            {
                Console.WriteLine("error");
            }
        }


    }


    // we can use the student enroll course as an example
    // a sub system will include register a course and notify a course in registered.
    public class EnrollNotifyFacade
    {
        public EnrollCourse enroll;
        public NotifyStudent notify;
        public EnrollNotifyFacade()
        {
            enroll = new EnrollCourse();
            notify = new NotifyStudent();
        }

        public bool Register(string courseName, string studentName)
        {
            if (!enroll.CheckAvailable(courseName))
            {
                return false;
            }

            return notify.Notify(studentName);
        }

    }




    //sub system enroll a course
    public class EnrollCourse
    {
        public bool CheckAvailable(string course)
        {
            Console.WriteLine("{0} couse is not full", course);
            return true;
        }
    }

    //sub system notify a student
    public class NotifyStudent
    {
        public bool Notify(string studentName)
        {
            Console.WriteLine("student {0} is notified", studentName);
            return true;
        }
    }


}
