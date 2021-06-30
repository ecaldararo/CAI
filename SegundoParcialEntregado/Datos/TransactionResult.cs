using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    [DataContract]
    public class TransactionResult
    {
        [DataMember(Name="isOk")]
        public bool IsOk { get; set; }
        [DataMember(Name = "id")]
        public int Id { get; set; }
        [DataMember(Name = "error")]
        public string Error { get; set; }
    }
}
