//While

// let i=0;
// while (i<10) {
//     i++;
//     console.log(i+'.JavaScript');
    
// }

//do While
// let i=0;
// do {
//     i++;
//     console.log(i + '.Js');
// } while (i<10);

//FOR

// for (let i = 0; i < 10; i++) {
//     console.log(i+1+'.Java Script');
    
// }

//1-10 sayıları arasındaki sayıları topla yazdır.
// let toplam=0;
// let i=1;
// while(i<=10){
//     toplam +=i;
//     i++;
// }

// console.log('While ile : '+ toplam);

// let toplam2=0;
// for (let i = 1; i <= 10; i++) {
//     toplam2+=i;
    
// }
// console.log('For ile: '+ toplam2);

//Kullanıcının gireceği 3 sayıyı toplatan kodları for kullanarak yazınız.
// let dizi=[];
// let toplam=0;
// for (let i = 0; i < 3; i++) {
    
//     let sayi=parseInt( prompt('Lütfen '+i+'. bir sayı giriniz: '));
    
//     dizi.push(sayi);
//     toplam+=dizi[i];

// }
// // toplam=dizi[0]+dizi[1]+dizi[2];
// console.log(dizi);
// console.log(toplam);

//Kullanıcının gireceği 0 girene kadar sayıyı toplatan kodları for kullanarak yazınız.
// let toplam=0;
// let girilenSayi;
// let i=1;
// do {
//     girilenSayi=Number(prompt(i+'. sayı: '));
//     toplam+=girilenSayi;
//     i++;
// } while (girilenSayi!=0);
// console.log('Toplam: '+ toplam);

//Son örnekteki girilen sayıları da sonuçta yazdıralım
/*
let toplam=0;
let girilenSayi;
let i=1;
let dizi=[];
do {
    girilenSayi=Number(prompt(i+'. sayı: '));
    dizi.push(girilenSayi);
    toplam+=girilenSayi;
    i++;
} while (girilenSayi!=0);
console.log(dizi);
console.log( '1. Sayı:'+dizi[0]);
console.log( '2. Sayı:'+dizi[1]);
console.log( '3. Sayı:'+dizi[2]);

console.log('Toplam: '+ toplam);
*/
/*
let toplam=0;
let girilenSayilar =[];
let i=0;
do {
    girilenSayilar[i]=Number(prompt(i+1 +'. sayı: '));
    toplam+=girilenSayilar[i];
    i++;
} while (girilenSayilar[i-1]!=0);
girilenSayilar.pop();
for (let i = 0; i < girilenSayilar.length; i++) {
    console.log(i+1+'.Sayi:\t'+ girilenSayilar[i]);
    
}0
console.log('Toplam: '+ toplam);
*/
//2. örnek

let sayilar=[];
let i=0;
do {
    sayilar[i]=Number(prompt(i+1+'.Sayı: '));
    i++;
} while (sayilar[i-1]!=0);
sayilar.pop();
let sonucDizi=[];
let toplam=0;
let tur;
let cevap=prompt('Tek mi çift mi?');
console.log('Cevap:'+ cevap);
if (cevap.toLocaleLowerCase()=='çift') {
    tur='çift';
    console.log('Çift dedin');
    for (let i = 0; i < sayilar.length; i++) {
        if (sayilar[i]%2===0) {
            sonucDizi.push(sayilar[i]);
            toplam+=sayilar[i];
        } 
        
    }
} 
else if(cevap.toLocaleLowerCase()=='tek') {
    tur='tek'
    console.log('Tek dedin');
    for (let i = 0; i < sayilar.length; i++) {
        if (sayilar[i]%2===1) {
            sonucDizi.push(sayilar[i])
            toplam+=sayilar[i];

        } 
        
    }

}
else{
    console.log('Lütfen "Tek" ya da "Çift" yaz!');
}
console.log(sayilar);
console.log(tur+' Sayılar :'+ sonucDizi);
console.log(tur+' Sayıların toplamı:'+toplam);
