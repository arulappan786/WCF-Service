using QTMWcfDealService.Contracts;
using System.ServiceModel;

namespace QTMWcfDealService
{
    [ServiceContract]
    public interface ISwapDealService
    {
        [OperationContract]
        QTMSession LogOn(string Username, string Password, string SiteName);

        [OperationContract]
        Result InitializeSwapDeal(QTMSession objQTMSession, SwapDeal objSwapDeal);

        [OperationContract]
        Result CustomizeSwapDeal(QTMSession objQTMSession, Customize objCustomize);

        [OperationContract]
        Result UnwindSwapDeal(QTMSession objQTMSession, Unwind objUnwind);
        
    }
}
