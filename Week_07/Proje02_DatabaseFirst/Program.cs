using Proje02_DatabaseFirst.efcore;

NorthwindContext context = new NorthwindContext();

//Customer listesi alıyor.
// List<Customer> customers = context.Customers.ToList();

// foreach (var customer in customers)
// 	{
// 		Console.WriteLine(customer.CompanyName + "-" + customer.ContactName);
// 	}

// London da yaşayan customerlerin listesi

// List<Customer> customers = context.Customers.Where(c=>c.City=="London").ToList();

// foreach (var customer in customers)
// {
// 	System.Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Phone: {customer.Phone}");
// }

// System.Console.WriteLine("Btti.........");



// // Londonda yaşayan cutomerlerin conmpany name ve ContactName'lerini getirelim.

// var customers = context
// 	.Customers
// 	.Select(c=>new {c.CompanyName,c.ContactName,c.City})
// 	.Where(c=>c.City=="London")
// 	.ToList();

// foreach (var customer in customers)
// {
// 	System.Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }

// System.Console.WriteLine("Btti.........");

// Londonda yaşayan cutomerlerin conmpany name ve ContactName'lerini getirelim.
// Nesne kullanarak yapımı.



// List<CustomerModel> customers = context
// 	.Customers
// 	.Select(c=>new CustomerModel() {
// 		CompanyName=c.CompanyName,
// 		ContactName=c.ContactName,
// 		City= c.City})
// 	.Where(c=>c.City=="London")
// 	.ToList();

// foreach (var customer in customers)
// {
// 	System.Console.WriteLine($"Company Name: {customer.CompanyName} - City: {customer.City} - Contact Name: {customer.ContactName}");
// }

// System.Console.WriteLine("Btti.........");

//Beverages kategorisindeki ürünlerin listesi.

// var beveragesProducts = context
// 	.Products
// 	.Where(p => p.Category.CategoryName=="Beverages")
// 	.ToList();

// 	foreach (var p in beveragesProducts)
// 	{
// 		System.Console.WriteLine(p.ProductName);
// 	}

//Suppliers Tablosundak Germany de yaşayanları listeleyin.

// var germany = context
// 	.Suppliers
// 	.Where(s=> s.Country=="Germany")
// 	.ToList();

// 	foreach (var s in germany)
// 	{
// 		System.Console.WriteLine(s.ContactName);
// 	}

//Nancy adlı çalışanın yaptığı satışlar.

var ordersOfNancy = context
	.Orders
	.Where(o => o.Employee.FirstName=="Nancy" && o.ShipCountry=="Brazil")
	.ToList();
	foreach (var o in ordersOfNancy)
	{
		System.Console.WriteLine(o.OrderId);
	}
System.Console.WriteLine($"Toplam satış sayısı : {ordersOfNancy.Count()}");

class CustomerModel
{
	public string? CompanyName { get; set; }
	public string? ContactName { get; set; }
	public string? City { get; set; }

}


