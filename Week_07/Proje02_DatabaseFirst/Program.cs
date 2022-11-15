using Proje02_DatabaseFirst;
using Proje02_DatabaseFirst.efcore;

var mt = new MultiTable();

// mt.MusteriSayisi();
// mt.SatisYapılanMusteriler();
// mt.SatisYapılanMusteriler();
mt.MusteriSatisListesi();





// NorthwindContext context = new NorthwindContext();

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

// var ordersOfNancy = context
// 	.Orders
// 	.Where(o => o.Employee.FirstName=="Nancy" && o.ShipCountry=="Brazil")
// 	.ToList();
// 	foreach (var o in ordersOfNancy)
// 	{
// 		System.Console.WriteLine(o.OrderId);
// 	}
// System.Console.WriteLine($"Toplam satış sayısı : {ordersOfNancy.Count()}");

// //Poductları ıd ye göre büyükten küçüğe göre sıralayalım

// var products = context
// 	.Products
// 	.OrderByDescending(p=>p.ProductId)
// 	.ToList();
// 	foreach (var p in products)
// 	{
// 		System.Console.WriteLine($"{p.ProductId} / {p.ProductName}");
// 	}

//En son satılan 5 ürünü listeleyelim

// var products = context
// 	.Products
// 	.OrderByDescending(p=>p.ProductId)
// 	.Take(5)
// 	.ToList();
// 	foreach (var p in products)
// 	{
// 		System.Console.WriteLine($"{p.ProductId} / {p.ProductName}");
// 	}


//Fiyatı 10 ile 20 arasında olan ürünlerin adını ve fiyatını getirip listeleyelim, Fiyata göre büyükten küçüğe sıralayalım.

// var products = context
// 	.Products
// 	.OrderBy(p=> p.UnitPrice)
// 	.Where(p=> p.UnitPrice>= 10 && p.UnitPrice<= 20)
// 	.Select(p=> new {
// 		p.ProductName,
// 		p.UnitPrice
// 	})
// 	.ToList();
// foreach (var p in products)
// {
// 	System.Console.WriteLine($"{p.ProductName} --> {p.UnitPrice}");
// }

//Beverages kategorisindeki ürünlerin ortalama fiyatını ekana yadıralım.

// var ortalama = context
// 	.Products
// 	.Where(p=> p.Category.CategoryName=="Beverages")
// 	.Average(p=>p.UnitPrice);

// System.Console.WriteLine($"Beverages Fiyat Ortalaması: {ortalama}");

// //Bevereages kategorisindeki ürün adedi

// var adet = context
// 	.Products
// 	// .Where(p=> p.Category.CategoryName=="Beverages")
// 	// .Count();
// 	.Count(p=> p.Category.CategoryName=="Beverages");
// System.Console.WriteLine($"Beverages Ürün Adedi: {adet}");


//Beverages ve Condiments Kategorilerinde toplam kaç tane ürün var.

// var toplam = context
// 	.Products
// 	.Count(p=> p.Category.CategoryName=="Beverages" || p.Category.CategoryName=="Condiments");

// System.Console.WriteLine($"Beverages Ürün Adedi: {toplam}");

//Adının içinde tofu geçen ürünleri listeleyelim.

// var products = context
// 	.Products
// 	.Where(p => p.ProductName.Contains("tofu"))
// 	.ToList();

// foreach (var p in products)
// {
// 	System.Console.WriteLine($"{p.ProductName}");
// }


//En ucu ve en pahalı ürünler hangileri.

// var minPrice = context
// 	.Products
// 	.Min(p=>p.UnitPrice);
// var maxPrice = context
// 	.Products
// 	.Max(p=> p.UnitPrice);

// var minProduct = context
// 	.Products
// 	.Where(p=> p.UnitPrice == minPrice)
// 	.Select(p => new{
// 		p.ProductName,
// 		p.UnitPrice
// 	}).FirstOrDefault();

// var maxProduct = context
// 	.Products
// 	.Where(alex => alex.UnitPrice == maxPrice)
// 	.Select(hooijdonk=> new {
// 		hooijdonk.ProductName,
// 		hooijdonk.UnitPrice
// 	}).FirstOrDefault();

// System.Console.WriteLine($"Min Price : {minPrice} --> Product : {minProduct.ProductName} - {minProduct.UnitPrice}");
// System.Console.WriteLine($"Min Price : {maxPrice} --> Product : {maxProduct.ProductName} - {maxProduct.UnitPrice}");
// System.Console.WriteLine(maxPrice);

//En ucuz ve  en pahalı ürünler listesi

// var minPrice = context
// 	.Products
// 	.Min(p=>p.UnitPrice);
// var maxPrice = context
// 	.Products
// 	.Max(p=> p.UnitPrice);

// var minProduct = context
// 	.Products
// 	.Where(p=> p.UnitPrice == minPrice)
// 	.Select(p => new{
// 		p.ProductName
// 	}).ToList();

// var maxProduct = context
// 	.Products
// 	.Where(alex => alex.UnitPrice == maxPrice)
// 	.Select(hooijdonk=> new {
// 		hooijdonk.ProductName
// 	}).ToList();

// System.Console.WriteLine($"En ucuz ({minPrice}) Fiyatlı ürünlerin listesi");
// foreach (var min in minProduct)
// {
// 	System.Console.WriteLine(min.ProductName);
// }
// System.Console.WriteLine($"En pahalı ({maxPrice}) Fiyatlı ürünlerin listesi");

// foreach (var max in maxProduct)
// {
// 	System.Console.WriteLine(max.ProductName);
// }
// System.Console.WriteLine(maxPrice);


// class CustomerModel
// {
// 	public string? CompanyName { get; set; }
// 	public string? ContactName { get; set; }
// 	public string? City { get; set; }

// }


