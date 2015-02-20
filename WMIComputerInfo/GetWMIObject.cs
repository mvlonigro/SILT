using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Text;
using System.Threading.Tasks;
using WMIComputerInfo.WMIDataModels;

namespace WMIComputerInfo
{
    public class GetWMIObject
    {
        private PowerShell _ps = PowerShell.Create();

        public IEnumerable<ComputerSystem> GetWin32_ComputerSystem()
        {
            var returnList = new List<ComputerSystem>();
            using (var runspace = RunspaceFactory.CreateRunspace()) {
                runspace.Open();
                this._ps.Runspace = runspace;
                IEnumerable<PSObject> psObjects = _ps.AddCommand("get-wmiobject")
                    .AddArgument("win32_computersystem")
                    .Invoke();

                returnList.AddRange(psObjects.Select(pso => new ComputerSystem(pso)));
            }

            return returnList;
        }


    }
}
