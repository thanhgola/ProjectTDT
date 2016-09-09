﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace TDTUniversal.TDTServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TDTServices.AuthServiceSoap")]
    public interface AuthServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Authenticate", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityKeyMember[]))]
        System.Threading.Tasks.Task<TDTUniversal.TDTServices.SinhVien> AuthenticateAsync(string UserName, string Password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetUserByUniqueId", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityKeyMember[]))]
        System.Threading.Tasks.Task<TDTUniversal.TDTServices.SinhVien> GetUserByUniqueIdAsync(string UniqueId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetUserByToken", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityKeyMember[]))]
        System.Threading.Tasks.Task<TDTUniversal.TDTServices.SinhVien> GetUserByTokenAsync(string Token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsUserLoggedIn", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityKeyMember[]))]
        System.Threading.Tasks.Task<bool> IsUserLoggedInAsync(string Token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IsValidRequest", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityKeyMember[]))]
        System.Threading.Tasks.Task<bool> IsValidRequestAsync(string RedirectId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetUserStauts", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(StructuralObject))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(EntityKeyMember[]))]
        System.Threading.Tasks.Task<TDTUniversal.TDTServices.UserStatus> GetUserStautsAsync(string Token, string RequestId);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class SinhVien : EntityObject {
        
        private string mSSVField;
        
        private string matKhauField;
        
        private bool isQuaTienDoDaoTaoField;
        
        private string tokenField;
        
        private string passwordField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string MSSV {
            get {
                return this.mSSVField;
            }
            set {
                this.mSSVField = value;
                this.RaisePropertyChanged("MSSV");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string MatKhau {
            get {
                return this.matKhauField;
            }
            set {
                this.matKhauField = value;
                this.RaisePropertyChanged("MatKhau");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public bool IsQuaTienDoDaoTao {
            get {
                return this.isQuaTienDoDaoTaoField;
            }
            set {
                this.isQuaTienDoDaoTaoField = value;
                this.RaisePropertyChanged("IsQuaTienDoDaoTao");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string Token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
                this.RaisePropertyChanged("Token");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string Password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("Password");
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SinhVien))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class EntityObject : StructuralObject {
        
        private EntityKey entityKeyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public EntityKey EntityKey {
            get {
                return this.entityKeyField;
            }
            set {
                this.entityKeyField = value;
                this.RaisePropertyChanged("EntityKey");
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EntityKey : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string entitySetNameField;
        
        private string entityContainerNameField;
        
        private EntityKeyMember[] entityKeyValuesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string EntitySetName {
            get {
                return this.entitySetNameField;
            }
            set {
                this.entitySetNameField = value;
                this.RaisePropertyChanged("EntitySetName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string EntityContainerName {
            get {
                return this.entityContainerNameField;
            }
            set {
                this.entityContainerNameField = value;
                this.RaisePropertyChanged("EntityContainerName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Order=2)]
        public EntityKeyMember[] EntityKeyValues {
            get {
                return this.entityKeyValuesField;
            }
            set {
                this.entityKeyValuesField = value;
                this.RaisePropertyChanged("EntityKeyValues");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class EntityKeyMember : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string keyField;
        
        private object valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
                this.RaisePropertyChanged("Key");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public object Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("Value");
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
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class UserStatus : object, System.ComponentModel.INotifyPropertyChanged {
        
        private bool userLoggedInField;
        
        private bool requestIdValidField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public bool UserLoggedIn {
            get {
                return this.userLoggedInField;
            }
            set {
                this.userLoggedInField = value;
                this.RaisePropertyChanged("UserLoggedIn");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public bool RequestIdValid {
            get {
                return this.requestIdValidField;
            }
            set {
                this.requestIdValidField = value;
                this.RaisePropertyChanged("RequestIdValid");
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
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SinhVien))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public abstract partial class StructuralObject : object, System.ComponentModel.INotifyPropertyChanged {
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthServiceSoapChannel : TDTUniversal.TDTServices.AuthServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthServiceSoapClient : System.ServiceModel.ClientBase<TDTUniversal.TDTServices.AuthServiceSoap>, TDTUniversal.TDTServices.AuthServiceSoap {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public AuthServiceSoapClient() : 
                base(AuthServiceSoapClient.GetDefaultBinding(), AuthServiceSoapClient.GetDefaultEndpointAddress()) {
            this.Endpoint.Name = EndpointConfiguration.AuthServiceSoap.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthServiceSoapClient(EndpointConfiguration endpointConfiguration) : 
                base(AuthServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), AuthServiceSoapClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthServiceSoapClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(AuthServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthServiceSoapClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(AuthServiceSoapClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<TDTUniversal.TDTServices.SinhVien> AuthenticateAsync(string UserName, string Password) {
            return base.Channel.AuthenticateAsync(UserName, Password);
        }
        
        public System.Threading.Tasks.Task<TDTUniversal.TDTServices.SinhVien> GetUserByUniqueIdAsync(string UniqueId) {
            return base.Channel.GetUserByUniqueIdAsync(UniqueId);
        }
        
        public System.Threading.Tasks.Task<TDTUniversal.TDTServices.SinhVien> GetUserByTokenAsync(string Token) {
            return base.Channel.GetUserByTokenAsync(Token);
        }
        
        public System.Threading.Tasks.Task<bool> IsUserLoggedInAsync(string Token) {
            return base.Channel.IsUserLoggedInAsync(Token);
        }
        
        public System.Threading.Tasks.Task<bool> IsValidRequestAsync(string RedirectId) {
            return base.Channel.IsValidRequestAsync(RedirectId);
        }
        
        public System.Threading.Tasks.Task<TDTUniversal.TDTServices.UserStatus> GetUserStautsAsync(string Token, string RequestId) {
            return base.Channel.GetUserStautsAsync(Token, RequestId);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.AuthServiceSoap)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.AuthServiceSoap)) {
                return new System.ServiceModel.EndpointAddress("http://sso.tdt.edu.vn/AuthService.asmx");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding() {
            return AuthServiceSoapClient.GetBindingForEndpoint(EndpointConfiguration.AuthServiceSoap);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress() {
            return AuthServiceSoapClient.GetEndpointAddress(EndpointConfiguration.AuthServiceSoap);
        }
        
        public enum EndpointConfiguration {
            
            AuthServiceSoap,
        }
    }
}
