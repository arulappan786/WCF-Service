using System;
using System.Runtime.Serialization;

namespace QTMWcfDealService.Contracts
{
    [DataContract]
    public class SwapDeal
    {
        [DataMember]
        public string TickerNumber;

        [DataMember]
        public string Counterparty;

        [DataMember]
        public string Entity;

        [DataMember]
        public DateTime DealDate;

        [DataMember]
        public DateTime StartDate;

        [DataMember]
        public DateTime MaturityDate;

    }
}