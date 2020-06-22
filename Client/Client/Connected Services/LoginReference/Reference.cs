﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client.LoginReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/Server")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AcountField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AvartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int GradeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> RoomField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ScoreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SignField;
        
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
        public string Acount {
            get {
                return this.AcountField;
            }
            set {
                if ((object.ReferenceEquals(this.AcountField, value) != true)) {
                    this.AcountField = value;
                    this.RaisePropertyChanged("Acount");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Avart {
            get {
                return this.AvartField;
            }
            set {
                if ((object.ReferenceEquals(this.AvartField, value) != true)) {
                    this.AvartField = value;
                    this.RaisePropertyChanged("Avart");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Grade {
            get {
                return this.GradeField;
            }
            set {
                if ((this.GradeField.Equals(value) != true)) {
                    this.GradeField = value;
                    this.RaisePropertyChanged("Grade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Room {
            get {
                return this.RoomField;
            }
            set {
                if ((this.RoomField.Equals(value) != true)) {
                    this.RoomField = value;
                    this.RaisePropertyChanged("Room");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Score {
            get {
                return this.ScoreField;
            }
            set {
                if ((this.ScoreField.Equals(value) != true)) {
                    this.ScoreField = value;
                    this.RaisePropertyChanged("Score");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sign {
            get {
                return this.SignField;
            }
            set {
                if ((object.ReferenceEquals(this.SignField, value) != true)) {
                    this.SignField = value;
                    this.RaisePropertyChanged("Sign");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginReference.ILoginService")]
    public interface ILoginService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Login", ReplyAction="http://tempuri.org/ILoginService/LoginResponse")]
        bool Login(string id, string pw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Login", ReplyAction="http://tempuri.org/ILoginService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string id, string pw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Registered", ReplyAction="http://tempuri.org/ILoginService/RegisteredResponse")]
        bool Registered(string id, string pw, string sn, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Registered", ReplyAction="http://tempuri.org/ILoginService/RegisteredResponse")]
        System.Threading.Tasks.Task<bool> RegisteredAsync(string id, string pw, string sn, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/ForgetPassword", ReplyAction="http://tempuri.org/ILoginService/ForgetPasswordResponse")]
        bool ForgetPassword(string id, string ps);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/ForgetPassword", ReplyAction="http://tempuri.org/ILoginService/ForgetPasswordResponse")]
        System.Threading.Tasks.Task<bool> ForgetPasswordAsync(string id, string ps);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Userinfo", ReplyAction="http://tempuri.org/ILoginService/UserinfoResponse")]
        Client.LoginReference.User Userinfo(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Userinfo", ReplyAction="http://tempuri.org/ILoginService/UserinfoResponse")]
        System.Threading.Tasks.Task<Client.LoginReference.User> UserinfoAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginServiceChannel : Client.LoginReference.ILoginService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginServiceClient : System.ServiceModel.ClientBase<Client.LoginReference.ILoginService>, Client.LoginReference.ILoginService {
        
        public LoginServiceClient() {
        }
        
        public LoginServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Login(string id, string pw) {
            return base.Channel.Login(id, pw);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string id, string pw) {
            return base.Channel.LoginAsync(id, pw);
        }
        
        public bool Registered(string id, string pw, string sn, string name) {
            return base.Channel.Registered(id, pw, sn, name);
        }
        
        public System.Threading.Tasks.Task<bool> RegisteredAsync(string id, string pw, string sn, string name) {
            return base.Channel.RegisteredAsync(id, pw, sn, name);
        }
        
        public bool ForgetPassword(string id, string ps) {
            return base.Channel.ForgetPassword(id, ps);
        }
        
        public System.Threading.Tasks.Task<bool> ForgetPasswordAsync(string id, string ps) {
            return base.Channel.ForgetPasswordAsync(id, ps);
        }
        
        public Client.LoginReference.User Userinfo(string id) {
            return base.Channel.Userinfo(id);
        }
        
        public System.Threading.Tasks.Task<Client.LoginReference.User> UserinfoAsync(string id) {
            return base.Channel.UserinfoAsync(id);
        }
    }
}
