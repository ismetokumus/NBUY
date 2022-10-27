// 3) 1 den büyük olup 1 veya kendisi haricinde hiçbir sayıya kalansız bölünemeyen sayılara asal sayı denir.
// Örneğin 5 bir asal sayıdır. Çünkü 2,3 ve 4 e kalansız bölünemez.
// 2 den n'e kadar olan asal sayıları bulan kodu yazınız.
// Örneğin n = 10 için sonuç 2,3,5,7 olacaktır.
// NOT: Kod her türlü n değeri için çalışmalıdır, sabit bir sayı değildir.

//  bu benim çözümk

let deger;
let n = prompt(" Bir sayı giriniz.");
console.log(n, typeof n);
let asal = [];
for (let i = 1; i <=n; i++) {
  deger = n  % i;
  while (deger == 0 || deger == n) {
    // asal.push(i);
    console.log(deger);
  }
}
// console.log(asal);

/*
let n =parseInt( prompt('Bir sayı giriniz: '));
let asalMi;
for (let i = 2; i <= n; i++) {
    
    asalMi=true;
    for (let j = 2; j < i; j++) {
        if(i%j==0){
            asalMi=false;
        }
        
    }
    if (asalMi===true) {
        console.log(i);
    }
}

*/
