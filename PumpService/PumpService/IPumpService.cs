using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace PumpService
{
    [ServiceContract]
    public interface IPumpService
    {
        [OperationContract]
        void RunScript();

        [OperationContract]
        void UpdateAndCompileScript(string fileName);
    }
}
