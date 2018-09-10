using System;
using System.Collections.Generic;

using ProtoCore.AST.AssociativeAST;
using Dynamo.Graph.Nodes;

using DougKlassen.Dynamo.NodeModelSandbox.Functions;

namespace DougKlassen.Dynamo.NodeModelSandbox
{
    [IsDesignScriptCompatible]
    [NodeName("Hello Node")]
    [NodeCategory("DougKlassen")]
    [NodeDescription("Generates a hello world message")]
    [NodeSearchTags(new String[] {
        "Doug Klassen",
        "Sandbox",
        "Hello World"
    })]
    [OutPortNames("message")]
    [OutPortTypes("string")]
    [OutPortDescriptions("The generated message")]
    public class HelloNodeModel : NodeModel
    {
        public HelloNodeModel()
        {
            RegisterAllPorts();
        }

        public override IEnumerable<AssociativeNode> BuildOutputAst(List<AssociativeNode> inputAstNodes)
        {
            var functionCall =
                AstFactory.BuildFunctionCall(
                    new Func<string>(HelloFunction.HelloMessage),
                    new List<AssociativeNode>());

            return new AssociativeNode[] {
                AstFactory.BuildAssignment(GetAstIdentifierForOutputIndex(0),
                functionCall)};
        }
    }
}
