﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSPingPongClient.CSharpPingPongService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CSharpPingPongService.IPingPongService")]
    public interface IPingPongService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPingPongService/Ball_In", ReplyAction="http://tempuri.org/IPingPongService/Ball_InResponse")]
        void Ball_In(string ball);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPingPongService/Ball_In", ReplyAction="http://tempuri.org/IPingPongService/Ball_InResponse")]
        System.Threading.Tasks.Task Ball_InAsync(string ball);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPingPongService/Ball_Out", ReplyAction="http://tempuri.org/IPingPongService/Ball_OutResponse")]
        string Ball_Out();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPingPongService/Ball_Out", ReplyAction="http://tempuri.org/IPingPongService/Ball_OutResponse")]
        System.Threading.Tasks.Task<string> Ball_OutAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPingPongServiceChannel : WSPingPongClient.CSharpPingPongService.IPingPongService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PingPongServiceClient : System.ServiceModel.ClientBase<WSPingPongClient.CSharpPingPongService.IPingPongService>, WSPingPongClient.CSharpPingPongService.IPingPongService {
        
        public PingPongServiceClient() {
        }
        
        public PingPongServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PingPongServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PingPongServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PingPongServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Ball_In(string ball) {
            base.Channel.Ball_In(ball);
        }
        
        public System.Threading.Tasks.Task Ball_InAsync(string ball) {
            return base.Channel.Ball_InAsync(ball);
        }
        
        public string Ball_Out() {
            return base.Channel.Ball_Out();
        }
        
        public System.Threading.Tasks.Task<string> Ball_OutAsync() {
            return base.Channel.Ball_OutAsync();
        }
    }
}