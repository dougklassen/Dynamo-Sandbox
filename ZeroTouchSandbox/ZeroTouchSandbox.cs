using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Autodesk.DesignScript.Runtime;

public class ZeroTouchSandbox
{
    /// <summary>
    /// Using the inputs, return the result of arithmetic calculations 
    /// </summary>
    /// <param name="val1">The first value</param>
    /// <param name="val2">The second value</param>
    /// <returns></returns>
    [MultiReturn(new[] { "add", "multiply", "subtract", "divide" })]
    public static Dictionary<String, Object> ArithmeticNode(Double val1, Double val2)
    {
        var resultDict = new Dictionary<String, Object>();
        resultDict.Add("add", val1 + val2);
        resultDict.Add("multiply", val1 * val2);
        resultDict.Add("subtract", val1 - val2);
        resultDict.Add("divide", val1 / val2);
        return resultDict;
    }
}

