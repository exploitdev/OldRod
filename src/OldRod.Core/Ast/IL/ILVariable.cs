using System.Collections;
using System.Collections.Generic;
using OldRod.Core.Architecture;

namespace OldRod.Core.Ast.IL
{
    public class ILVariable
    {
        public ILVariable(string name)
        {
            Name = name;
        }
        
        public string Name
        {
            get;
            set;
        }

        public VMType VariableType
        {
            get;
            set;
        }

        public IList<ILAssignmentStatement> AssignedBy
        {
            get;
        } = new List<ILAssignmentStatement>();
        
        public IList<ILVariableExpression> UsedBy
        {
            get;
        } = new List<ILVariableExpression>();

        public override string ToString()
        {
            return Name;
        }
    }
}