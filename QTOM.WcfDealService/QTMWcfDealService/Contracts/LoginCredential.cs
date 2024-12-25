using System;
using System.Runtime.Serialization;

namespace QTMWcfDealService.Contracts
{
    [DataContract]
    public class LoginCredential
    {
        [DataMember]
        public string Username;

        [DataMember]
        public string Passowrd;

        [DataMember]
        public string Server;
    }
}