// 2) Kullanıcıya her defasında 100'den büyük bir sayı girmesi için prompt ile veri girmesini isteyin. Eğer farklı bir değer girerse tekrardan değer girmesi talebinde bulunun.
// Kullanıcı 100 den büyük bir sayı veya boş satıra onay verene kadar döngüye devam edilmelidir.
// Burada kullanıcının sadece sayısal değerler gireceğini farzedin. Ayrıca sayısal değerleri kontrol için bir kod yazmak ile uğraşmayın.


let sayi=0;
while(sayi<100 || sayi==NaN) {
    sayi=parseInt(prompt('100 den büyük bir sayı giriniz.'));
    console.log(sayi, typeof sayi);
}
console.log(sayi);

