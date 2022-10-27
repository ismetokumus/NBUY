// selamVer();// Çıktısı 'Merhaba JavaScript'

// function selamVer(){
//     console.log('Merhaba JavaScript');
// }
// selamVer();// Çıktısı 'Merhaba JavaScript'


// function selamVer(isim='Dünya') {
//     console.log('Merhaba '+ isim);
// }
// selamVer('İsmet');//Çıktısı  Merhaba İsmet
// selamVer('Engin');
// selamVer();// Çıktısı merhaba
// selamVer();// Merhaba Dünya sebebi yukarda isim ekledik.



// function yasHesapla(dogumYili) {
//     return new Date().getFullYear()-dogumYili;
// }
// console.log(yasHesapla(1975));
// let yas=yasHesapla(1989);
// if (yas<30) {
//     console.log('Yaşınız uygun değildir!');
// }else{
//     console.log('Kabul edildiniz.');
// }

//Bir tutar bilgisi alıp, bu tutarın kdv sini hesaplayıp geri döndüren function

// function kdvHesaplama(tutar) {
//     let sonuc=(tutar*0.18);
//     sonuc=sonuc.toFixed(2);
//     return sonuc;
// }
// console.log(kdvHesaplama(4875));



// function kdvHesapla() {
//     for (let i = 0; i < arguments.length; i++) {
        
//         console.log(arguments[i]*0.18);
//     }
// }

// kdvHesapla(100,200,1000);

//Kendisine gönderilecek tutar bilgilerini kullanarak kdv leri hesaplayıp, geriye hesaplanmış kdv leri içinde barındıran bir dizi döndüren function

function kdvHesapla() {
    let sonuc=[];
    let kdv=0;
    for (let i = 0; i < arguments.length; i++) {
        kdv=arguments[i]*0.18;
        kdv = kdv.toFixed(2);
        sonuc.push(kdv)
        
    }
    return sonuc;
}

console.log(kdvHesapla(100,450,1000));