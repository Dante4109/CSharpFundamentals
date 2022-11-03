using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleFundies.DesignPatterns.SOLID
{
    public abstract class Course
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }

        public abstract void Subscribe(Student std);
    }

    public class OnlineCourse : Course
    {
        public override void Subscribe(Student std)
        {
            //write code to subscribe to an online course

            Logger.Log("Starting Subscribe()");

            //apply business rules based on the course type live, online, offline, if any 
            if (this.Type == "online")
            {
                //subscribe to online course 
            }
            else if (this.Type == "live")
            {
                //subscribe to offline course 
            }

            // payment processing
            PaymentManager.ProcessPayment();

            //create CourseRepository class to save student and course into StudentCourse table  

            // send confirmation email
            EmailManager.SendEmail();

            Logger.Log("End Subscribe()");

        }

        public class OfflineCourse : Course
        {
            public override void Subscribe(Student std)
            {
                //write code to subscribe to a offline course
            }
        }

        public class EmailManager
        {
            public static void SendEmail()
            {
                // smtp code here
            }
        }

        public class PaymentManager
        {
            public static void ProcessPayment()
            {
                //payment processing code here
            }
        }
    }
}
