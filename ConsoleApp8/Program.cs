
using ConsoleApp8.classes_ques2;
using ConsoleApp8.question2_interface;
using System.Security.Cryptography;

namespace ConsoleApp8
{
    internal class Program
    {
        #region question_1
        public static string test_shape(Ishape s)
        {
            if (s is not null)
            {
                return s.shapeinfo();
            }
            return "obj is null";
        }
        #endregion
        static void Main(string[] args)
        {
            #region mcq_answers
            /*
              What is the primary purpose of an interface in C#?
            a) To provide a way to implement multiple inheritance
            b) To define a blueprint for a class
            c) To declare abstract methods and properties
            ========================================================================================
         
              Which of the following is NOT a valid access modifier for interface members in C#?
                    a) private
                    b) protected
            ========================================================================================
            Can an interface contain fields in C#?

                b) No
            =========================================================================================
            In C#, can an interface inherit from another interface?

            b) Yes, interfaces can inherit from multiple interfac
            ========================================================================
            Which keyword is used to implement an interface in a class in C#?

               correct is --> :
            =======================================================================================
            Can an interface contain static methods in C#?
                a) Yes
            =======================================================================================
            In C#, can an interface have explicit access modifiers for its members?
                    b) No, all members are implicitly public
            =====================================================================================
            What is the purpose of an explicit interface implementation in C#?
                a) To hide the interface members from outside access
            ===================================================================================
            In C#, can an interface have a constructor?
                b) No, interfaces cannot have constructors
            ================================================================================
            How can a C# class implement multiple interfaces?

               c) By separating interface names with commas
              */

            #endregion

            //part 2


            #region question_1
            //Ishape s = new circle();
            //s.Area= 15;
            //Console.WriteLine(test_shape(s));
            //Ishape r = new rectangle();
            //r.Area = 15.5;
            //Console.WriteLine(test_shape(r));
            #endregion


            #region Question_02
            //Authentication_Service s = new Authentication_Service();
            //s.Username = "mohamed";
            //s.Password = "password";
            //s.Role = "user";
            //Console.WriteLine(s.AuthenticateUser(s.Username, s.Password));
            //Console.WriteLine(s.Authorize(s.Username,s.Role));
            #endregion


        }
    }
}
