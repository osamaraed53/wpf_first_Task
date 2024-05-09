namespace WpfFirstApp.Model;

internal class Item
{
    private static int IndexOfId = 0; 
    public int Id { get; set; } = ++IndexOfId;
    public string Name { get; set; }
    public string SerialNumber { get; set; }
    public int Quantity { get; set; }
}
