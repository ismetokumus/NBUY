// let obje1 = {
//   urunAd: "Iphone 13",
//   urunFiyat: 78_000,
//   urunRenk: "Gri",
//   onayli: true,
// };

// let obje2 = {
//   urunAd: "Iphone 13",
//   urunFiyat: 78_000,
//   urunRenk: "Gri",
// };
// obje2.onayli=false;
// if (obje2.onayli == undefined) {
//   console.log("Lütfen admin ile iletişime geçiniz!");
// } else {
//   if (obje1.onayli === true) {
//     console.log("Bu ürün satışta!");
//   } else {
//     console.log("Gelince haber ver!");
//   }
// }

// console.log(obje1);
// console.log(obje1.urunFiyat);
// obje1.urunFiyat=45_000;
// console.log(obje1.urunFiyat);
// obje1.urunAdet=15;
// console.log(obje1);


// let ogrenci1={
//     'ogrenciNo':144,
//     'ogrenciAd':'Ali',
//     'ogrenciSoyad':'Babahan',
//     'ogrenciYas':18,
//     'ogrenciAktif':true
// }
// ogrenci1.cinsiyet='Erkek'
// if ('cinsiyet' in ogrenci1) {
//     console.log(ogrenci1.cinsiyet);
// }else{
//     console.log('Böyle bir özellik tanımlı değil!');
// }

// let kisi1={
//     'Ad Soyad':'Serhan Cankuş',
//     'Doğum Tarihi':'11.5.1999',
//     'kidemYili':27
// };
// console.log(kisi1['Ad Soyad']);
// console.log(kisi1.kidemYili);

// let product1={
//     productId:12,
//     productName:'Samsung S21',
//     productPrice:27_000
// };
// let product2={
//     productId:13,
//     productName:'Iphone 14',
//     productPrice:21_000
// };
// let product3={
//     productId:14,
//     productName:'Xaomi Note 10',
//     productPrice:17_000
// };

// let products=[product1,product2,product3];
// console.log(products);

// let products=[
//     {
//         id:13,
//         name:'Iphone',
//         price:19_000
//     },
//     {
//         id:14,
//         name:'Samsung',
//         price:21_000
//     },
//     {
//         id:15,
//         name:'Xaomi',
//         price:12_500
//     }
// ];
// console.log(products);

// console.log(products[2].price+ ' '+products[2].name);


let category1={};
category1.name='Telefon';
let category2={};
category2.name='Bilgisayar';
let categories=[category1,category2];
console.log(categories);