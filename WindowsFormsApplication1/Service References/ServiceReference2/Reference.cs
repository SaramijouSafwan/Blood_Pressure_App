﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.IBLOOD_PRESSURE")]
    public interface IBLOOD_PRESSURE {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBLOOD_PRESSURE/measureBloodPressure", ReplyAction="http://tempuri.org/IBLOOD_PRESSURE/measureBloodPressureResponse")]
        string measureBloodPressure(string _ssn, float _upper, float _lower);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBLOOD_PRESSURE/measureBloodPressure", ReplyAction="http://tempuri.org/IBLOOD_PRESSURE/measureBloodPressureResponse")]
        System.Threading.Tasks.Task<string> measureBloodPressureAsync(string _ssn, float _upper, float _lower);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBLOOD_PRESSURE/trackBloodPressure", ReplyAction="http://tempuri.org/IBLOOD_PRESSURE/trackBloodPressureResponse")]
        string[] trackBloodPressure(string _ssn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBLOOD_PRESSURE/trackBloodPressure", ReplyAction="http://tempuri.org/IBLOOD_PRESSURE/trackBloodPressureResponse")]
        System.Threading.Tasks.Task<string[]> trackBloodPressureAsync(string _ssn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBLOOD_PRESSURE/getDietPlan", ReplyAction="http://tempuri.org/IBLOOD_PRESSURE/getDietPlanResponse")]
        string[] getDietPlan(string _bloodPressureStatus);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBLOOD_PRESSURE/getDietPlan", ReplyAction="http://tempuri.org/IBLOOD_PRESSURE/getDietPlanResponse")]
        System.Threading.Tasks.Task<string[]> getDietPlanAsync(string _bloodPressureStatus);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBLOOD_PRESSURE/notifyUser")]
        void notifyUser(bool notify, int timeHour);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBLOOD_PRESSURE/notifyUser")]
        System.Threading.Tasks.Task notifyUserAsync(bool notify, int timeHour);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBLOOD_PRESSURE/cheakMail", ReplyAction="http://tempuri.org/IBLOOD_PRESSURE/cheakMailResponse")]
        string cheakMail();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBLOOD_PRESSURE/cheakMail", ReplyAction="http://tempuri.org/IBLOOD_PRESSURE/cheakMailResponse")]
        System.Threading.Tasks.Task<string> cheakMailAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBLOOD_PRESSUREChannel : WindowsFormsApplication1.ServiceReference2.IBLOOD_PRESSURE, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BLOOD_PRESSUREClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference2.IBLOOD_PRESSURE>, WindowsFormsApplication1.ServiceReference2.IBLOOD_PRESSURE {
        
        public BLOOD_PRESSUREClient() {
        }
        
        public BLOOD_PRESSUREClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BLOOD_PRESSUREClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BLOOD_PRESSUREClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BLOOD_PRESSUREClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string measureBloodPressure(string _ssn, float _upper, float _lower) {
            return base.Channel.measureBloodPressure(_ssn, _upper, _lower);
        }
        
        public System.Threading.Tasks.Task<string> measureBloodPressureAsync(string _ssn, float _upper, float _lower) {
            return base.Channel.measureBloodPressureAsync(_ssn, _upper, _lower);
        }
        
        public string[] trackBloodPressure(string _ssn) {
            return base.Channel.trackBloodPressure(_ssn);
        }
        
        public System.Threading.Tasks.Task<string[]> trackBloodPressureAsync(string _ssn) {
            return base.Channel.trackBloodPressureAsync(_ssn);
        }
        
        public string[] getDietPlan(string _bloodPressureStatus) {
            return base.Channel.getDietPlan(_bloodPressureStatus);
        }
        
        public System.Threading.Tasks.Task<string[]> getDietPlanAsync(string _bloodPressureStatus) {
            return base.Channel.getDietPlanAsync(_bloodPressureStatus);
        }
        
        public void notifyUser(bool notify, int timeHour) {
            base.Channel.notifyUser(notify, timeHour);
        }
        
        public System.Threading.Tasks.Task notifyUserAsync(bool notify, int timeHour) {
            return base.Channel.notifyUserAsync(notify, timeHour);
        }
        
        public string cheakMail() {
            return base.Channel.cheakMail();
        }
        
        public System.Threading.Tasks.Task<string> cheakMailAsync() {
            return base.Channel.cheakMailAsync();
        }
    }
}
