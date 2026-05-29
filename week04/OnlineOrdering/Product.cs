using System;

namespace OnlineOrdering
{
    public class Product
    {
        private string _productName;
        private string _productId;
        private double _unitPrice;
        private int _quantity;


        public Product(string name, string productId, double price, int quantity)
        {
            _productName = name;
            _productId = productId;
            _unitPrice = price;
            _quantity = quantity;
        }

        public double GetTotalCost()
        {
            return _unitPrice * _quantity;
        }

        public void IncreaseQuantity(int amount)
        {
            if (amount <= 0) return;
            _quantity += amount;
        }

        public string getProductName()
        {
            return _productName;
        }

        public string getProductId()
        {
            return _productId;
        }

        public int getQuantity()
        {
            return _quantity;
        }

        public double getUnitPrice()
        {
            return _unitPrice;
        }

        public string GetProductInfo()
        {
            return $"{_productName} (ID: {_productId}) ";
        }


    }
}
