using System;

namespace ops_workshop.Models
{
    public class SalesResult
    {
        public SalesResult(int orderqty, string name, string listprice){
            this.OrderQty = orderqty;
            this.Name = name;
            this.ListPrice = listprice;
        }
        public int OrderQty { get; set; }
        public string Name { get; set; }
        public string ListPrice { get; set; }
    }
}
