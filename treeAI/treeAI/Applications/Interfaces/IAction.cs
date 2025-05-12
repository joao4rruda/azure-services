using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeAI.Applications.Interfaces
{
    internal interface IAction
    {
       string Name { get; }
       Task<string> ExecuteAsync(Dictionary<string, object> parameters);
    }
}
