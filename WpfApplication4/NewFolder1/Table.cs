using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication4
{
    [DataContract]
    class Table
    {
        [DataMember]
        public int id_Table { get; set; }
        [DataMember]
        public string location_Table { get; set; }
        [DataMember]
        public int label_Table { get; set; }
        [DataMember]
        public int places_Table { get; set; }
    }
}
