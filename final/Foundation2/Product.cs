public class Product
{
    private string _name;
    private string _productId;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _pricePerUnit = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _pricePerUnit * _quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _productId;
    }
}
