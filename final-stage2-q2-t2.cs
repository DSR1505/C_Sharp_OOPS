using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Customer
{
Public string cid,cname,city;
Public int age;
}
class Shop 
{
	public string sid,sname;
	public List<Customer> Normal_Customers=new List<Customer>();
	public List<Customer> Premeium_Customers=new List<Customer>();
	//Constructors
	
	public void AddCustomer(Customer c, string type)
	{
	if(type==”Normal”)
		Normal_Customers.Add(c);
	else if(type==”Premium”)
		Premeium_Customers.Add(c);
	}
	
	public bool RemoveCustomer(string  id)
	{
		bool flag1=false,   flag2=false;
		Customer c1 = Normal_Customers.Find( x => x.cid == id);
		if(c1 != null)
		{
			Normal_Customers.Remove(c1) ;
			Flag1= true ;
		}
		Customer c2 = Premium_Customers.Find( x => x.cid == id);
		if(c2 != null)
		{
			Premium_Customers.Remove(c2) ;
			Flag2= true ;
		}	

		if( flag1 == true  | flag2 == true)
		{
			return true;
		}
		else 
			return false ;
	}
}
