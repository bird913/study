﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:2.0.50727.3053
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 3.0.40818.0
// 
namespace SilverlightMenu.MenuDemoService {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Nodes", Namespace="http://schemas.datacontract.org/2004/07/SilverlightMenu.Web.Dao")]
    public partial class Nodes : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int IdField;
        
        private string NodeNameField;
        
        private int ParentIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NodeName {
            get {
                return this.NodeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.NodeNameField, value) != true)) {
                    this.NodeNameField = value;
                    this.RaisePropertyChanged("NodeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ParentId {
            get {
                return this.ParentIdField;
            }
            set {
                if ((this.ParentIdField.Equals(value) != true)) {
                    this.ParentIdField = value;
                    this.RaisePropertyChanged("ParentId");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="MenuDemoService.MenuDemo")]
    public interface MenuDemo {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:MenuDemo/GetAllMenuNodes", ReplyAction="urn:MenuDemo/GetAllMenuNodesResponse")]
        System.IAsyncResult BeginGetAllMenuNodes(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<SilverlightMenu.MenuDemoService.Nodes> EndGetAllMenuNodes(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface MenuDemoChannel : SilverlightMenu.MenuDemoService.MenuDemo, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class GetAllMenuNodesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllMenuNodesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<SilverlightMenu.MenuDemoService.Nodes> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<SilverlightMenu.MenuDemoService.Nodes>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class MenuDemoClient : System.ServiceModel.ClientBase<SilverlightMenu.MenuDemoService.MenuDemo>, SilverlightMenu.MenuDemoService.MenuDemo {
        
        private BeginOperationDelegate onBeginGetAllMenuNodesDelegate;
        
        private EndOperationDelegate onEndGetAllMenuNodesDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllMenuNodesCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public MenuDemoClient() {
        }
        
        public MenuDemoClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MenuDemoClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MenuDemoClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MenuDemoClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetAllMenuNodesCompletedEventArgs> GetAllMenuNodesCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SilverlightMenu.MenuDemoService.MenuDemo.BeginGetAllMenuNodes(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllMenuNodes(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<SilverlightMenu.MenuDemoService.Nodes> SilverlightMenu.MenuDemoService.MenuDemo.EndGetAllMenuNodes(System.IAsyncResult result) {
            return base.Channel.EndGetAllMenuNodes(result);
        }
        
        private System.IAsyncResult OnBeginGetAllMenuNodes(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((SilverlightMenu.MenuDemoService.MenuDemo)(this)).BeginGetAllMenuNodes(callback, asyncState);
        }
        
        private object[] OnEndGetAllMenuNodes(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<SilverlightMenu.MenuDemoService.Nodes> retVal = ((SilverlightMenu.MenuDemoService.MenuDemo)(this)).EndGetAllMenuNodes(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllMenuNodesCompleted(object state) {
            if ((this.GetAllMenuNodesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllMenuNodesCompleted(this, new GetAllMenuNodesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllMenuNodesAsync() {
            this.GetAllMenuNodesAsync(null);
        }
        
        public void GetAllMenuNodesAsync(object userState) {
            if ((this.onBeginGetAllMenuNodesDelegate == null)) {
                this.onBeginGetAllMenuNodesDelegate = new BeginOperationDelegate(this.OnBeginGetAllMenuNodes);
            }
            if ((this.onEndGetAllMenuNodesDelegate == null)) {
                this.onEndGetAllMenuNodesDelegate = new EndOperationDelegate(this.OnEndGetAllMenuNodes);
            }
            if ((this.onGetAllMenuNodesCompletedDelegate == null)) {
                this.onGetAllMenuNodesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllMenuNodesCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllMenuNodesDelegate, null, this.onEndGetAllMenuNodesDelegate, this.onGetAllMenuNodesCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SilverlightMenu.MenuDemoService.MenuDemo CreateChannel() {
            return new MenuDemoClientChannel(this);
        }
        
        private class MenuDemoClientChannel : ChannelBase<SilverlightMenu.MenuDemoService.MenuDemo>, SilverlightMenu.MenuDemoService.MenuDemo {
            
            public MenuDemoClientChannel(System.ServiceModel.ClientBase<SilverlightMenu.MenuDemoService.MenuDemo> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetAllMenuNodes(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetAllMenuNodes", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<SilverlightMenu.MenuDemoService.Nodes> EndGetAllMenuNodes(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<SilverlightMenu.MenuDemoService.Nodes> _result = ((System.Collections.ObjectModel.ObservableCollection<SilverlightMenu.MenuDemoService.Nodes>)(base.EndInvoke("GetAllMenuNodes", _args, result)));
                return _result;
            }
        }
    }
}