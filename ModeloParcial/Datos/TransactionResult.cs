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
        [DataMember(Name ="isOk")]
        public bool isok { get; set; }
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string error { get; set; }
    }
}
