﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LW_18_2_PSD.ShoesService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShoesService.ShoesControllerSoap")]
    public interface ShoesControllerSoap {
        
        // CODEGEN: Generating message contract since element name shoeName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/doInsert", ReplyAction="*")]
        LW_18_2_PSD.ShoesService.doInsertResponse doInsert(LW_18_2_PSD.ShoesService.doInsertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/doInsert", ReplyAction="*")]
        System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doInsertResponse> doInsertAsync(LW_18_2_PSD.ShoesService.doInsertRequest request);
        
        // CODEGEN: Generating message contract since element name oldShoeName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/doUpdate", ReplyAction="*")]
        LW_18_2_PSD.ShoesService.doUpdateResponse doUpdate(LW_18_2_PSD.ShoesService.doUpdateRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/doUpdate", ReplyAction="*")]
        System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doUpdateResponse> doUpdateAsync(LW_18_2_PSD.ShoesService.doUpdateRequest request);
        
        // CODEGEN: Generating message contract since element name shoeName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/doDelete", ReplyAction="*")]
        LW_18_2_PSD.ShoesService.doDeleteResponse doDelete(LW_18_2_PSD.ShoesService.doDeleteRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/doDelete", ReplyAction="*")]
        System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doDeleteResponse> doDeleteAsync(LW_18_2_PSD.ShoesService.doDeleteRequest request);
        
        // CODEGEN: Generating message contract since element name doGetResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/doGet", ReplyAction="*")]
        LW_18_2_PSD.ShoesService.doGetResponse doGet(LW_18_2_PSD.ShoesService.doGetRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/doGet", ReplyAction="*")]
        System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doGetResponse> doGetAsync(LW_18_2_PSD.ShoesService.doGetRequest request);
        
        // CODEGEN: Generating message contract since element name doGetByIDResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/doGetByID", ReplyAction="*")]
        LW_18_2_PSD.ShoesService.doGetByIDResponse doGetByID(LW_18_2_PSD.ShoesService.doGetByIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/doGetByID", ReplyAction="*")]
        System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doGetByIDResponse> doGetByIDAsync(LW_18_2_PSD.ShoesService.doGetByIDRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class doInsertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="doInsert", Namespace="http://tempuri.org/", Order=0)]
        public LW_18_2_PSD.ShoesService.doInsertRequestBody Body;
        
        public doInsertRequest() {
        }
        
        public doInsertRequest(LW_18_2_PSD.ShoesService.doInsertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class doInsertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string shoeName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int price;
        
        public doInsertRequestBody() {
        }
        
        public doInsertRequestBody(string shoeName, int price) {
            this.shoeName = shoeName;
            this.price = price;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class doInsertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="doInsertResponse", Namespace="http://tempuri.org/", Order=0)]
        public LW_18_2_PSD.ShoesService.doInsertResponseBody Body;
        
        public doInsertResponse() {
        }
        
        public doInsertResponse(LW_18_2_PSD.ShoesService.doInsertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class doInsertResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string doInsertResult;
        
        public doInsertResponseBody() {
        }
        
        public doInsertResponseBody(string doInsertResult) {
            this.doInsertResult = doInsertResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class doUpdateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="doUpdate", Namespace="http://tempuri.org/", Order=0)]
        public LW_18_2_PSD.ShoesService.doUpdateRequestBody Body;
        
        public doUpdateRequest() {
        }
        
        public doUpdateRequest(LW_18_2_PSD.ShoesService.doUpdateRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class doUpdateRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string oldShoeName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int oldPrice;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string updateName;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=3)]
        public int updatePrice;
        
        public doUpdateRequestBody() {
        }
        
        public doUpdateRequestBody(string oldShoeName, int oldPrice, string updateName, int updatePrice) {
            this.oldShoeName = oldShoeName;
            this.oldPrice = oldPrice;
            this.updateName = updateName;
            this.updatePrice = updatePrice;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class doUpdateResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="doUpdateResponse", Namespace="http://tempuri.org/", Order=0)]
        public LW_18_2_PSD.ShoesService.doUpdateResponseBody Body;
        
        public doUpdateResponse() {
        }
        
        public doUpdateResponse(LW_18_2_PSD.ShoesService.doUpdateResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class doUpdateResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string doUpdateResult;
        
        public doUpdateResponseBody() {
        }
        
        public doUpdateResponseBody(string doUpdateResult) {
            this.doUpdateResult = doUpdateResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class doDeleteRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="doDelete", Namespace="http://tempuri.org/", Order=0)]
        public LW_18_2_PSD.ShoesService.doDeleteRequestBody Body;
        
        public doDeleteRequest() {
        }
        
        public doDeleteRequest(LW_18_2_PSD.ShoesService.doDeleteRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class doDeleteRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string shoeName;
        
        public doDeleteRequestBody() {
        }
        
        public doDeleteRequestBody(string shoeName) {
            this.shoeName = shoeName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class doDeleteResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="doDeleteResponse", Namespace="http://tempuri.org/", Order=0)]
        public LW_18_2_PSD.ShoesService.doDeleteResponseBody Body;
        
        public doDeleteResponse() {
        }
        
        public doDeleteResponse(LW_18_2_PSD.ShoesService.doDeleteResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class doDeleteResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string doDeleteResult;
        
        public doDeleteResponseBody() {
        }
        
        public doDeleteResponseBody(string doDeleteResult) {
            this.doDeleteResult = doDeleteResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class doGetRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="doGet", Namespace="http://tempuri.org/", Order=0)]
        public LW_18_2_PSD.ShoesService.doGetRequestBody Body;
        
        public doGetRequest() {
        }
        
        public doGetRequest(LW_18_2_PSD.ShoesService.doGetRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class doGetRequestBody {
        
        public doGetRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class doGetResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="doGetResponse", Namespace="http://tempuri.org/", Order=0)]
        public LW_18_2_PSD.ShoesService.doGetResponseBody Body;
        
        public doGetResponse() {
        }
        
        public doGetResponse(LW_18_2_PSD.ShoesService.doGetResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class doGetResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string doGetResult;
        
        public doGetResponseBody() {
        }
        
        public doGetResponseBody(string doGetResult) {
            this.doGetResult = doGetResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class doGetByIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="doGetByID", Namespace="http://tempuri.org/", Order=0)]
        public LW_18_2_PSD.ShoesService.doGetByIDRequestBody Body;
        
        public doGetByIDRequest() {
        }
        
        public doGetByIDRequest(LW_18_2_PSD.ShoesService.doGetByIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class doGetByIDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public doGetByIDRequestBody() {
        }
        
        public doGetByIDRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class doGetByIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="doGetByIDResponse", Namespace="http://tempuri.org/", Order=0)]
        public LW_18_2_PSD.ShoesService.doGetByIDResponseBody Body;
        
        public doGetByIDResponse() {
        }
        
        public doGetByIDResponse(LW_18_2_PSD.ShoesService.doGetByIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class doGetByIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string doGetByIDResult;
        
        public doGetByIDResponseBody() {
        }
        
        public doGetByIDResponseBody(string doGetByIDResult) {
            this.doGetByIDResult = doGetByIDResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ShoesControllerSoapChannel : LW_18_2_PSD.ShoesService.ShoesControllerSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShoesControllerSoapClient : System.ServiceModel.ClientBase<LW_18_2_PSD.ShoesService.ShoesControllerSoap>, LW_18_2_PSD.ShoesService.ShoesControllerSoap {
        
        public ShoesControllerSoapClient() {
        }
        
        public ShoesControllerSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShoesControllerSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShoesControllerSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShoesControllerSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LW_18_2_PSD.ShoesService.doInsertResponse LW_18_2_PSD.ShoesService.ShoesControllerSoap.doInsert(LW_18_2_PSD.ShoesService.doInsertRequest request) {
            return base.Channel.doInsert(request);
        }
        
        public string doInsert(string shoeName, int price) {
            LW_18_2_PSD.ShoesService.doInsertRequest inValue = new LW_18_2_PSD.ShoesService.doInsertRequest();
            inValue.Body = new LW_18_2_PSD.ShoesService.doInsertRequestBody();
            inValue.Body.shoeName = shoeName;
            inValue.Body.price = price;
            LW_18_2_PSD.ShoesService.doInsertResponse retVal = ((LW_18_2_PSD.ShoesService.ShoesControllerSoap)(this)).doInsert(inValue);
            return retVal.Body.doInsertResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doInsertResponse> LW_18_2_PSD.ShoesService.ShoesControllerSoap.doInsertAsync(LW_18_2_PSD.ShoesService.doInsertRequest request) {
            return base.Channel.doInsertAsync(request);
        }
        
        public System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doInsertResponse> doInsertAsync(string shoeName, int price) {
            LW_18_2_PSD.ShoesService.doInsertRequest inValue = new LW_18_2_PSD.ShoesService.doInsertRequest();
            inValue.Body = new LW_18_2_PSD.ShoesService.doInsertRequestBody();
            inValue.Body.shoeName = shoeName;
            inValue.Body.price = price;
            return ((LW_18_2_PSD.ShoesService.ShoesControllerSoap)(this)).doInsertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LW_18_2_PSD.ShoesService.doUpdateResponse LW_18_2_PSD.ShoesService.ShoesControllerSoap.doUpdate(LW_18_2_PSD.ShoesService.doUpdateRequest request) {
            return base.Channel.doUpdate(request);
        }
        
        public string doUpdate(string oldShoeName, int oldPrice, string updateName, int updatePrice) {
            LW_18_2_PSD.ShoesService.doUpdateRequest inValue = new LW_18_2_PSD.ShoesService.doUpdateRequest();
            inValue.Body = new LW_18_2_PSD.ShoesService.doUpdateRequestBody();
            inValue.Body.oldShoeName = oldShoeName;
            inValue.Body.oldPrice = oldPrice;
            inValue.Body.updateName = updateName;
            inValue.Body.updatePrice = updatePrice;
            LW_18_2_PSD.ShoesService.doUpdateResponse retVal = ((LW_18_2_PSD.ShoesService.ShoesControllerSoap)(this)).doUpdate(inValue);
            return retVal.Body.doUpdateResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doUpdateResponse> LW_18_2_PSD.ShoesService.ShoesControllerSoap.doUpdateAsync(LW_18_2_PSD.ShoesService.doUpdateRequest request) {
            return base.Channel.doUpdateAsync(request);
        }
        
        public System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doUpdateResponse> doUpdateAsync(string oldShoeName, int oldPrice, string updateName, int updatePrice) {
            LW_18_2_PSD.ShoesService.doUpdateRequest inValue = new LW_18_2_PSD.ShoesService.doUpdateRequest();
            inValue.Body = new LW_18_2_PSD.ShoesService.doUpdateRequestBody();
            inValue.Body.oldShoeName = oldShoeName;
            inValue.Body.oldPrice = oldPrice;
            inValue.Body.updateName = updateName;
            inValue.Body.updatePrice = updatePrice;
            return ((LW_18_2_PSD.ShoesService.ShoesControllerSoap)(this)).doUpdateAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LW_18_2_PSD.ShoesService.doDeleteResponse LW_18_2_PSD.ShoesService.ShoesControllerSoap.doDelete(LW_18_2_PSD.ShoesService.doDeleteRequest request) {
            return base.Channel.doDelete(request);
        }
        
        public string doDelete(string shoeName) {
            LW_18_2_PSD.ShoesService.doDeleteRequest inValue = new LW_18_2_PSD.ShoesService.doDeleteRequest();
            inValue.Body = new LW_18_2_PSD.ShoesService.doDeleteRequestBody();
            inValue.Body.shoeName = shoeName;
            LW_18_2_PSD.ShoesService.doDeleteResponse retVal = ((LW_18_2_PSD.ShoesService.ShoesControllerSoap)(this)).doDelete(inValue);
            return retVal.Body.doDeleteResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doDeleteResponse> LW_18_2_PSD.ShoesService.ShoesControllerSoap.doDeleteAsync(LW_18_2_PSD.ShoesService.doDeleteRequest request) {
            return base.Channel.doDeleteAsync(request);
        }
        
        public System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doDeleteResponse> doDeleteAsync(string shoeName) {
            LW_18_2_PSD.ShoesService.doDeleteRequest inValue = new LW_18_2_PSD.ShoesService.doDeleteRequest();
            inValue.Body = new LW_18_2_PSD.ShoesService.doDeleteRequestBody();
            inValue.Body.shoeName = shoeName;
            return ((LW_18_2_PSD.ShoesService.ShoesControllerSoap)(this)).doDeleteAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LW_18_2_PSD.ShoesService.doGetResponse LW_18_2_PSD.ShoesService.ShoesControllerSoap.doGet(LW_18_2_PSD.ShoesService.doGetRequest request) {
            return base.Channel.doGet(request);
        }
        
        public string doGet() {
            LW_18_2_PSD.ShoesService.doGetRequest inValue = new LW_18_2_PSD.ShoesService.doGetRequest();
            inValue.Body = new LW_18_2_PSD.ShoesService.doGetRequestBody();
            LW_18_2_PSD.ShoesService.doGetResponse retVal = ((LW_18_2_PSD.ShoesService.ShoesControllerSoap)(this)).doGet(inValue);
            return retVal.Body.doGetResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doGetResponse> LW_18_2_PSD.ShoesService.ShoesControllerSoap.doGetAsync(LW_18_2_PSD.ShoesService.doGetRequest request) {
            return base.Channel.doGetAsync(request);
        }
        
        public System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doGetResponse> doGetAsync() {
            LW_18_2_PSD.ShoesService.doGetRequest inValue = new LW_18_2_PSD.ShoesService.doGetRequest();
            inValue.Body = new LW_18_2_PSD.ShoesService.doGetRequestBody();
            return ((LW_18_2_PSD.ShoesService.ShoesControllerSoap)(this)).doGetAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        LW_18_2_PSD.ShoesService.doGetByIDResponse LW_18_2_PSD.ShoesService.ShoesControllerSoap.doGetByID(LW_18_2_PSD.ShoesService.doGetByIDRequest request) {
            return base.Channel.doGetByID(request);
        }
        
        public string doGetByID(int id) {
            LW_18_2_PSD.ShoesService.doGetByIDRequest inValue = new LW_18_2_PSD.ShoesService.doGetByIDRequest();
            inValue.Body = new LW_18_2_PSD.ShoesService.doGetByIDRequestBody();
            inValue.Body.id = id;
            LW_18_2_PSD.ShoesService.doGetByIDResponse retVal = ((LW_18_2_PSD.ShoesService.ShoesControllerSoap)(this)).doGetByID(inValue);
            return retVal.Body.doGetByIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doGetByIDResponse> LW_18_2_PSD.ShoesService.ShoesControllerSoap.doGetByIDAsync(LW_18_2_PSD.ShoesService.doGetByIDRequest request) {
            return base.Channel.doGetByIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<LW_18_2_PSD.ShoesService.doGetByIDResponse> doGetByIDAsync(int id) {
            LW_18_2_PSD.ShoesService.doGetByIDRequest inValue = new LW_18_2_PSD.ShoesService.doGetByIDRequest();
            inValue.Body = new LW_18_2_PSD.ShoesService.doGetByIDRequestBody();
            inValue.Body.id = id;
            return ((LW_18_2_PSD.ShoesService.ShoesControllerSoap)(this)).doGetByIDAsync(inValue);
        }
    }
}
