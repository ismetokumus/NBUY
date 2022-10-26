let sonuc;

sonuc=Number('10.6');
sonuc=parseInt('10.6');
sonuc=parseInt('10abc');//en baştan bakar.
sonuc=parseInt('adc10');//Nan
sonuc=parseInt('10.abcd');//10
sonuc=parseFloat('10.6abcd');//10.6

let sayi=15.468756;

sonuc=sayi.toFixed(4);//15.4688
sonuc=sayi.toPrecision(4);//15.47
sonuc=Math.round(2.4);//2.4
sonuc=Math.round(2.5);//3
sonuc=Math.ceil(2.2);//3
sonuc=Math.floor(2.2);//2
sonuc=Math.pow(2,3);//8
sonuc=Math.pow(5,2);//25
sonuc=Math.sqrt(25)//5
sonuc=Math.abs(-5);//5
sonuc=Math.min(45,78,1,6);//1
sonuc=Math.max(45,78,1,6);//78
sonuc=Math.random();
sonuc=parseInt(Math.random()*100)+1;//+1 yüz dahil olsun diye


console.log(sonuc,typeof sonuc );