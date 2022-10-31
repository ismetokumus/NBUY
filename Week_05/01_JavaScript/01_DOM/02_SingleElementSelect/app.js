let sonuc;
//getElementById

sonuc=document.getElementById('title');
sonuc=document.getElementById('title').id;
sonuc=document.getElementById('title').className;//string olarak çıktı verir.
sonuc=document.getElementById('title').classList;//dizi şeklinde çıktı veriyor.
document.getElementById('title').style.fontSize='50px';
document.getElementById('title').style.color='red';
// document.getElementById('title').style.display='none';


//quarySelecter
sonuc=document.querySelector('#title');
sonuc=document.querySelector('div');
sonuc=document.querySelector('.h1');

sonuc=document.querySelector('li');
sonuc=document.querySelector('li:first-child');//ilki seçmek için
sonuc=document.querySelector('li:last-child');//sonuncuyu seçmek için
sonuc=document.querySelector('li:nth-child(2)').innerText;

console.log(sonuc);