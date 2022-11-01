const display=document.querySelector('.calculator-input');
const keys = document.querySelector('.calculator-keys');

let displayValue='0';

function updateDisplay(){
    display.value=displayValue;
}

keys.addEventListener('click', function(event){
    const element = event.target;
    if(!element.matches('button')) return;
    if (element.classList.contains('operator')) {
        console.log('Bir operatöre tıklandı');
    }else if( element.classList.contains('decimal')){
        console.log('decimalll');
    }
    else if(element.classList.contains('clear')){
        console.log('clearrrr');
    }else{
        console.log('Bir rakama tıklandı');
    }
    // console.log(element.value);
})