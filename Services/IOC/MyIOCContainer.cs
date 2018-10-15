using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;

namespace Services.IOC
{
    public class MyIOCContainer : IInstanceProvider
    {
        public MyIOCContainer(Type serviceType)
        {

        }
        public object GetInstance(InstanceContext instanceContext)
        {
            
            throw new NotImplementedException();
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            throw new NotImplementedException();
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {

        }
    }
}
