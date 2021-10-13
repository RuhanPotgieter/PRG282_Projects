using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282_Project.Data_Access_Layer;
using PRG282_Project.Presentation_Layer;

namespace PRG282_Project.BusinessLogic_layer
{
    class customException : Exception
    {

       public customException()
        {
            
        }
        [Serializable]
        class InvalidStudentNumberException : Exception
        {
            public InvalidStudentNumberException() { }

            public InvalidStudentNumberException(int studentnum)
                : base(String.Format("Invalid Student Number: {0}", studentnum))
            {

            }
        }
        [Serializable]
        class InvalidCapturerLoginInfoException : Exception
        {
            public InvalidCapturerLoginInfoException() { }
            public InvalidCapturerLoginInfoException(string username): base(String.Format("Sorry "+username+" already Exists try a different please regsiter as user"))
            {

            }
        }
        [Serializable]
        class InvalidStudentAddException : Exception
        {
            public InvalidStudentAddException() { }
            public InvalidStudentAddException(string studentnum, string Firstname) : base(String.Format("Sorry " + studentnum + Firstname+" already Exists try a different please regsiter as new Student"))
            {

            }
        }

    }
}
