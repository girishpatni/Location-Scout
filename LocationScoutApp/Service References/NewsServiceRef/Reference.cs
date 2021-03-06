﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocationScoutApp.NewsServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="News", Namespace="http://schemas.datacontract.org/2004/07/LocationScout")]
    [System.SerializableAttribute()]
    public partial class News : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string news_ContentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string news_ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string news_PublishDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string news_PublisherField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string news_TitleField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string news_URLField;
        
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
        public string news_Content {
            get {
                return this.news_ContentField;
            }
            set {
                if ((object.ReferenceEquals(this.news_ContentField, value) != true)) {
                    this.news_ContentField = value;
                    this.RaisePropertyChanged("news_Content");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string news_Image {
            get {
                return this.news_ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.news_ImageField, value) != true)) {
                    this.news_ImageField = value;
                    this.RaisePropertyChanged("news_Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string news_PublishDate {
            get {
                return this.news_PublishDateField;
            }
            set {
                if ((object.ReferenceEquals(this.news_PublishDateField, value) != true)) {
                    this.news_PublishDateField = value;
                    this.RaisePropertyChanged("news_PublishDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string news_Publisher {
            get {
                return this.news_PublisherField;
            }
            set {
                if ((object.ReferenceEquals(this.news_PublisherField, value) != true)) {
                    this.news_PublisherField = value;
                    this.RaisePropertyChanged("news_Publisher");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string news_Title {
            get {
                return this.news_TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.news_TitleField, value) != true)) {
                    this.news_TitleField = value;
                    this.RaisePropertyChanged("news_Title");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string news_URL {
            get {
                return this.news_URLField;
            }
            set {
                if ((object.ReferenceEquals(this.news_URLField, value) != true)) {
                    this.news_URLField = value;
                    this.RaisePropertyChanged("news_URL");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NewsServiceRef.INewsDataService")]
    public interface INewsDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsDataService/getNewsDataXML", ReplyAction="http://tempuri.org/INewsDataService/getNewsDataXMLResponse")]
        LocationScoutApp.NewsServiceRef.News[] getNewsDataXML(string query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsDataService/getNewsDataXML", ReplyAction="http://tempuri.org/INewsDataService/getNewsDataXMLResponse")]
        System.Threading.Tasks.Task<LocationScoutApp.NewsServiceRef.News[]> getNewsDataXMLAsync(string query);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsDataService/getNewsDataJSON", ReplyAction="http://tempuri.org/INewsDataService/getNewsDataJSONResponse")]
        LocationScoutApp.NewsServiceRef.News[] getNewsDataJSON(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INewsDataService/getNewsDataJSON", ReplyAction="http://tempuri.org/INewsDataService/getNewsDataJSONResponse")]
        System.Threading.Tasks.Task<LocationScoutApp.NewsServiceRef.News[]> getNewsDataJSONAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INewsDataServiceChannel : LocationScoutApp.NewsServiceRef.INewsDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NewsDataServiceClient : System.ServiceModel.ClientBase<LocationScoutApp.NewsServiceRef.INewsDataService>, LocationScoutApp.NewsServiceRef.INewsDataService {
        
        public NewsDataServiceClient() {
        }
        
        public NewsDataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NewsDataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsDataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NewsDataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LocationScoutApp.NewsServiceRef.News[] getNewsDataXML(string query) {
            return base.Channel.getNewsDataXML(query);
        }
        
        public System.Threading.Tasks.Task<LocationScoutApp.NewsServiceRef.News[]> getNewsDataXMLAsync(string query) {
            return base.Channel.getNewsDataXMLAsync(query);
        }
        
        public LocationScoutApp.NewsServiceRef.News[] getNewsDataJSON(string username) {
            return base.Channel.getNewsDataJSON(username);
        }
        
        public System.Threading.Tasks.Task<LocationScoutApp.NewsServiceRef.News[]> getNewsDataJSONAsync(string username) {
            return base.Channel.getNewsDataJSONAsync(username);
        }
    }
}
