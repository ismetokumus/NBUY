let simdi=new Date();

sonuc=simdi;
//26.10.2022 17:15 çarşamba
sonuc=simdi.getDate();//26
sonuc=simdi.getDay();//3
sonuc=simdi.getFullYear();//2022
sonuc=simdi.getHours();17
sonuc=simdi.getTime();/*???*/

simdi.setFullYear(2015);
simdi.setMonth(0);
sonuc=simdi
let suAn=new Date();
sonuc=suAn;
let kacYilSonra=5;
sonuc=new Date( suAn.setFullYear(suAn.getFullYear()+kacYilSonra));


simdi=new Date();
sonuc=simdi;

let dogumTarihi= new Date(1995,7,10)
sonuc=simdi.getFullYear()-dogumTarihi.getFullYear();
let milisecond=simdi-dogumTarihi;

let second=milisecond/1000;
let minute=second/60;
let hour=minute/60;
let day=hour/24;

sonuc=parseInt(day);

console.log(dogumTarihi);
console.log(sonuc);