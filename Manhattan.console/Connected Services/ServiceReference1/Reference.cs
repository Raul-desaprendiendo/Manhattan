﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Manhattan.console.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateManhattanDistanceByCoords", ReplyAction="http://tempuri.org/IService/CalculateManhattanDistanceByCoordsResponse")]
        int CalculateManhattanDistanceByCoords(int p1x, int p1y, int p2x, int p2y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateManhattanDistanceByCoords", ReplyAction="http://tempuri.org/IService/CalculateManhattanDistanceByCoordsResponse")]
        System.Threading.Tasks.Task<int> CalculateManhattanDistanceByCoordsAsync(int p1x, int p1y, int p2x, int p2y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        Manhattan.console.ServiceReference1.CompositeType GetDataUsingDataContract(Manhattan.console.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<Manhattan.console.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Manhattan.console.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateSubtraction", ReplyAction="http://tempuri.org/IService/CalculateSubtractionResponse")]
        int CalculateSubtraction(int value1, int value2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CalculateSubtraction", ReplyAction="http://tempuri.org/IService/CalculateSubtractionResponse")]
        System.Threading.Tasks.Task<int> CalculateSubtractionAsync(int value1, int value2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Manhattan.console.ServiceReference1.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Manhattan.console.ServiceReference1.IService>, Manhattan.console.ServiceReference1.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CalculateManhattanDistanceByCoords(int p1x, int p1y, int p2x, int p2y) {
            return base.Channel.CalculateManhattanDistanceByCoords(p1x, p1y, p2x, p2y);
        }
        
        public System.Threading.Tasks.Task<int> CalculateManhattanDistanceByCoordsAsync(int p1x, int p1y, int p2x, int p2y) {
            return base.Channel.CalculateManhattanDistanceByCoordsAsync(p1x, p1y, p2x, p2y);
        }
        
        public Manhattan.console.ServiceReference1.CompositeType GetDataUsingDataContract(Manhattan.console.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<Manhattan.console.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(Manhattan.console.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int CalculateSubtraction(int value1, int value2) {
            return base.Channel.CalculateSubtraction(value1, value2);
        }
        
        public System.Threading.Tasks.Task<int> CalculateSubtractionAsync(int value1, int value2) {
            return base.Channel.CalculateSubtractionAsync(value1, value2);
        }
    }
}
