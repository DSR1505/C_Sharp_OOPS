using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Product
    {
        public string ProductCode;
        public string Name;
        public double Price;
        public string Brand;
    }
class Shop
    {
        public string Name;
        public List<Product> ProdList=new List<Product>();
        public Shop() { }
        public Shop(string name, List<Product> productList)
        {
            Name = name;
           This. ProdList = productList;
        }
		public void AddProductToShop(Product p)
        {
            if (ProdList.Count == 0)
                ProdList.Add(p);
            else
            {
           Product obj = ProdList.Find(x => x.Name.ToLower() == p.Name.ToLower() && x.ProductCode == p.ProductCode);
                if ((ProdList.Contains(obj)) == false)
                    ProdList.Add(p);
                
            }
        }
		public bool RemoveProductFromShop(string productCode)
        {
            bool flag;
            Product obj = ProdList.Find(x =>  x.ProductCode == productCode);
            if ((ProdList.Contains(obj)) == true)
            {
                flag = true;
                ProdList.Remove(obj);
            }
            else
                flag = false;
            return flag;
        }
	
    }

class ProductBO
    {
        public List<Product> FindProduct(List<Product> productList, string brand)
	{
            var res = from p in productList
                      where p.Brand == brand
                      select p;
            return res.ToList();
	}
		
	public List<Product> FindProduct(List<Product> productList, double price)
        {
            var res = from p in productList
                      where p.Price == price
                      select p;
            return res.ToList();
        }
	
	public Hashtable BrandWiseCount(List<Product> productList )
        {       
           var res= from p in productList
                      group p by p.Brand into g
                      select new  { brand=g.Key,count=g.Count() };
            Hashtable ht1 = new Hashtable();
            foreach(var x in res)
            {
                ht1.Add(x.brand, x.count);
            }
            return ht1;
        }
	}
