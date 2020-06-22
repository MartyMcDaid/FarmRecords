using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmRecords
{
    class Sheep
    {
        public int SheepId { get; set; }
        public string HerdNumber { get; set; }
        public string TagNumber { get; set; }
        public string Breed { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public string PurchaseDocumentNumber { get; set; }
        public char Sex { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
    }
}
