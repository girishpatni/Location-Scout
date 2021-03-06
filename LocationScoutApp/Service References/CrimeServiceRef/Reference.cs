﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocationScoutApp.CrimeServiceRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CrimeServiceRef.ICrimeDataService")]
    public interface ICrimeDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrimeDataService/getCrimeData", ReplyAction="http://tempuri.org/ICrimeDataService/getCrimeDataResponse")]
        System.Collections.Generic.Dictionary<string, int> getCrimeData(string zipcode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrimeDataService/getCrimeData", ReplyAction="http://tempuri.org/ICrimeDataService/getCrimeDataResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> getCrimeDataAsync(string zipcode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICrimeDataServiceChannel : LocationScoutApp.CrimeServiceRef.ICrimeDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CrimeDataServiceClient : System.ServiceModel.ClientBase<LocationScoutApp.CrimeServiceRef.ICrimeDataService>, LocationScoutApp.CrimeServiceRef.ICrimeDataService {
        
        public CrimeDataServiceClient() {
        }
        
        public CrimeDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CrimeDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrimeDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CrimeDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Collections.Generic.Dictionary<string, int> getCrimeData(string zipcode) {
            return base.Channel.getCrimeData(zipcode);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> getCrimeDataAsync(string zipcode) {
            return base.Channel.getCrimeDataAsync(zipcode);
        }
    }
}
