namespace DAY3.Model{
public class  Inventory
{

        public Inventory(int ITEMID, string ITEMNAME, string ITEMDESCRIPTION, string ITEMCODE, int QUANTITY, string CREATEDATE)
    {
    this.ItemID = ITEMID;
    this.ItemName = ITEMNAME;
    this.ItemDescription = ITEMDESCRIPTION;
    this.ItemCode = ITEMCODE;
    this.Quantity = QUANTITY;
    this.CreateDate = CREATEDATE; 
    }
        
    public int? ItemID {get; set;}
    public string? ItemName {get; set;}
    public string? ItemDescription {get; set;}
    public string? ItemCode {get; set;}
    public int? Quantity{get; set;}
    public string? CreateDate {get; set;}
  }
}
