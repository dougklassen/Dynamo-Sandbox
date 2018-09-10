using Autodesk.DesignScript.Runtime;

namespace DougKlassen.Dynamo.NodeModelSandbox.Functions
{
    [IsVisibleInDynamoLibrary(false)]
    public class HelloFunction
    {
        public static string HelloMessage()
        {
            string msg = string.Empty;
            msg += "Hello Dynamo!";
            return (msg);
        }
    }
}
