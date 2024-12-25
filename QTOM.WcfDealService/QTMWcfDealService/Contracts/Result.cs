using QTMWcfDealService.Enums;
using System.Runtime.Serialization;

namespace QTMWcfDealService.Contracts
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public ResultStatus Status;

        [DataMember]
        public string StatusMessage;
        
    }
}