using System;

namespace ops_workshop.Models
{
    public class SalesResult
    {
        public SalesResult(short orderqty, string name, decimal listprice){
            this.OrderQty = orderqty;
            this.Name = name;
            this.ListPrice = listprice;
        }
        public short OrderQty { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }
    }
}
