using QTMWcfDealService.Contracts;
using System;

namespace QTMWcfDealService
{
    public class SwapDealService : ISwapDealService
    {
            
        public Result CustomizeSwapDeal(QTMSession objQTMSession, Customize objCustomize)
        {
            throw new NotImplementedException();
        }

        public Result InitializeSwapDeal(QTMSession objQTMSession, SwapDeal objSwapDeal)
        {
            throw new NotImplementedException();
        }

        public QTMSession LogOn(string Username, string Password, string SiteName)
        {
            throw new NotImplementedException();
        }

        public Result UnwindSwapDeal(QTMSession objQTMSession, Unwind objUnwind)
        {
            throw new NotImplementedException();

        }
    }
}

