﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassicConsoleApp1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name HelloWorldResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        ClassicConsoleApp1.ServiceReference1.HelloWorldResponse HelloWorld(ClassicConsoleApp1.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<ClassicConsoleApp1.ServiceReference1.HelloWorldResponse> HelloWorldAsync(ClassicConsoleApp1.ServiceReference1.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddNumbers", ReplyAction="*")]
        int AddNumbers(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddNumbers", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddNumbersAsync(int num1, int num2);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public ClassicConsoleApp1.ServiceReference1.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(ClassicConsoleApp1.ServiceReference1.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClassicConsoleApp1.ServiceReference1.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(ClassicConsoleApp1.ServiceReference1.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : ClassicConsoleApp1.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<ClassicConsoleApp1.ServiceReference1.WebService1Soap>, ClassicConsoleApp1.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClassicConsoleApp1.ServiceReference1.HelloWorldResponse ClassicConsoleApp1.ServiceReference1.WebService1Soap.HelloWorld(ClassicConsoleApp1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            ClassicConsoleApp1.ServiceReference1.HelloWorldRequest inValue = new ClassicConsoleApp1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ClassicConsoleApp1.ServiceReference1.HelloWorldRequestBody();
            ClassicConsoleApp1.ServiceReference1.HelloWorldResponse retVal = ((ClassicConsoleApp1.ServiceReference1.WebService1Soap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClassicConsoleApp1.ServiceReference1.HelloWorldResponse> ClassicConsoleApp1.ServiceReference1.WebService1Soap.HelloWorldAsync(ClassicConsoleApp1.ServiceReference1.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClassicConsoleApp1.ServiceReference1.HelloWorldResponse> HelloWorldAsync() {
            ClassicConsoleApp1.ServiceReference1.HelloWorldRequest inValue = new ClassicConsoleApp1.ServiceReference1.HelloWorldRequest();
            inValue.Body = new ClassicConsoleApp1.ServiceReference1.HelloWorldRequestBody();
            return ((ClassicConsoleApp1.ServiceReference1.WebService1Soap)(this)).HelloWorldAsync(inValue);
        }
        
        public int AddNumbers(int num1, int num2) {
            return base.Channel.AddNumbers(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> AddNumbersAsync(int num1, int num2) {
            return base.Channel.AddNumbersAsync(num1, num2);
        }
    }
}
