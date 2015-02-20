using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;

namespace WMIComputerInfo.WMIDataModels
{
    public class ComputerSystem
    {
        public string Domain { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string PrimaryOwnerName { get; set; }
        public string TotalPhysicalMemory { get; set; }

        public ComputerSystem(PSObject psObject)
        {
            this.Domain = psObject.Members["Domain"].Value.ToString();
            this.Manufacturer = psObject.Members["Manufacturer"].Value.ToString();
            this.Model = psObject.Members["Model"].Value.ToString();
            this.Name = psObject.Members["Name"].Value.ToString();
            this.PrimaryOwnerName = psObject.Members["PrimaryOwnerName"].Value.ToString();
            this.TotalPhysicalMemory = psObject.Members["TotalPhysicalMemory"].Value.ToString();
        }
    }
}
