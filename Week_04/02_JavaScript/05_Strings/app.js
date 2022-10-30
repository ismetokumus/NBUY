let ders='Bahçeşehir Üniversitesi Wissen Akademie Iğdır';
let sonuc;

sonuc=ders.toLowerCase();
sonuc=ders.toLocaleLowerCase();
sonuc=ders.toUpperCase();
sonuc=ders.toLocaleUpperCase();


sonuc=ders.length;
sonuc=ders[0];
sonuc=ders[44];


sonuc=ders.slice(0,10);
sonuc=ders.slice(20,25);
sonuc=ders.slice(10);


sonuc=ders.substring(0,10);
sonuc=ders.substring(20,5);
sonuc=ders.substring(20,25);
sonuc=ders.substring(25,20);


sonuc=ders.replace('Iğdır','İstanbul');
sonuc=ders.replace(' ','-');

sonuc=ders.trim();//Strin ifadenin başındaki ve sonundaki boşluğu kaldırırır
sonuc=ders.trimStart();
sonuc=ders.trimEnd();

sonuc=ders.indexOf('A');
// sonuc=ders.toLocaleUpperCase().indexOf('A');

// sonuc=ders.split(' ');


// sonuc=ders.includes('a');
// sonuc=ders.startsWith('H');
// sonuc=ders.

console.log(ders);
console.log(sonuc);


// let kul=prompt('Lütfen bir cümle giriniz:');
// sonuc=kul.split(' ');
// console.log(sonuc.length);
