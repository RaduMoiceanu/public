﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace iCodeSystems.ShoppingCart.CartServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cart", Namespace="http://schemas.datacontract.org/2004/07/iCodeSystems.ShoppingCart.Communication")]
    [System.SerializableAttribute()]
    public partial class Cart : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private iCodeSystems.ShoppingCart.CartServiceReference.CartItem[] ItemsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string[] PromotionCodesField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public iCodeSystems.ShoppingCart.CartServiceReference.CartItem[] Items {
            get {
                return this.ItemsField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemsField, value) != true)) {
                    this.ItemsField = value;
                    this.RaisePropertyChanged("Items");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string[] PromotionCodes {
            get {
                return this.PromotionCodesField;
            }
            set {
                if ((object.ReferenceEquals(this.PromotionCodesField, value) != true)) {
                    this.PromotionCodesField = value;
                    this.RaisePropertyChanged("PromotionCodes");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CartItem", Namespace="http://schemas.datacontract.org/2004/07/iCodeSystems.ShoppingCart.Communication")]
    [System.SerializableAttribute()]
    public partial class CartItem : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SkuField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantity {
            get {
                return this.QuantityField;
            }
            set {
                if ((this.QuantityField.Equals(value) != true)) {
                    this.QuantityField = value;
                    this.RaisePropertyChanged("Quantity");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sku {
            get {
                return this.SkuField;
            }
            set {
                if ((object.ReferenceEquals(this.SkuField, value) != true)) {
                    this.SkuField = value;
                    this.RaisePropertyChanged("Sku");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CartServiceReference.ICartService")]
    public interface ICartService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/GetCart", ReplyAction="http://tempuri.org/ICartService/GetCartResponse")]
        iCodeSystems.ShoppingCart.CartServiceReference.Cart GetCart(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/GetCart", ReplyAction="http://tempuri.org/ICartService/GetCartResponse")]
        System.Threading.Tasks.Task<iCodeSystems.ShoppingCart.CartServiceReference.Cart> GetCartAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/SaveCart", ReplyAction="http://tempuri.org/ICartService/SaveCartResponse")]
        void SaveCart(iCodeSystems.ShoppingCart.CartServiceReference.Cart cart);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICartService/SaveCart", ReplyAction="http://tempuri.org/ICartService/SaveCartResponse")]
        System.Threading.Tasks.Task SaveCartAsync(iCodeSystems.ShoppingCart.CartServiceReference.Cart cart);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICartServiceChannel : iCodeSystems.ShoppingCart.CartServiceReference.ICartService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CartServiceClient : System.ServiceModel.ClientBase<iCodeSystems.ShoppingCart.CartServiceReference.ICartService>, iCodeSystems.ShoppingCart.CartServiceReference.ICartService {
        
        public CartServiceClient() {
        }
        
        public CartServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CartServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CartServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CartServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public iCodeSystems.ShoppingCart.CartServiceReference.Cart GetCart(string id) {
            return base.Channel.GetCart(id);
        }
        
        public System.Threading.Tasks.Task<iCodeSystems.ShoppingCart.CartServiceReference.Cart> GetCartAsync(string id) {
            return base.Channel.GetCartAsync(id);
        }
        
        public void SaveCart(iCodeSystems.ShoppingCart.CartServiceReference.Cart cart) {
            base.Channel.SaveCart(cart);
        }
        
        public System.Threading.Tasks.Task SaveCartAsync(iCodeSystems.ShoppingCart.CartServiceReference.Cart cart) {
            return base.Channel.SaveCartAsync(cart);
        }
    }
}
