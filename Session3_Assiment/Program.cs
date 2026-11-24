using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;

namespace Session3_Assiment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Quession 1
            // 1-Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print
            //both title and upperTitle to show that title did not change
            //string title = "clean code";
            //string upperTitle = title.ToUpper();
            //Console.WriteLine(upperTitle);
            //Console.WriteLine(title);

            #endregion

            #region Question2
            //2-Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals()
            // to check if they point to the same object in memory.

            //string v1 = "Clean Code";
            //string v2 = "Clean Code";
            //Console.WriteLine(object.ReferenceEquals(v1, v2));

            //Console.WriteLine(v1.GetHashCode());
            //Console.WriteLine(v2.GetHashCode());
            #endregion
            #region Question3
            //3-Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same
            //object.Print the final result.
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            //Console.WriteLine(sb);

            #endregion
            #region Question4
            //4-Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library".
            //Print the result.
            sb.Replace  ("Book List", "Library");
            Console.WriteLine(sb);


            #endregion

        }
    }
}
