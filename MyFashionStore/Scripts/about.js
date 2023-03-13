/* about us ( Clints )*/ 
var happy=0,pranches=0,partner=0,awards=0;
var numbers = document.querySelectorAll('.numbers .col h1');
var section = document.querySelector('.clints');
var faade = document.querySelector('.numbers');
var flag = false;
window.onscroll=function()
{
    console.log(window.scrollY);
    if(window.scrollY>=section.offsetTop-200)
    {
        if(!flag)
        {
            faade.classList.toggle('active');
            var happy_interval = setInterval(function(){
                happy++;
                if(happy===1500)
                {
                    clearInterval(happy_interval);
                }
                numbers[0].textContent=happy;
            },1000/1500);
            
            var pranches_interval = setInterval(function(){
                pranches++;
                if(pranches===1000)
                {
                    clearInterval(pranches_interval);
                }
                numbers[1].textContent=pranches;
            },1000/1000);
            
            
            var partner_interval = setInterval(function(){
                partner++;
                if(partner===100 )
                {
                    clearInterval(partner_interval);
                }
                numbers[2].textContent=partner;
            },1000/100);
            
            var awards_interval = setInterval(function(){
                awards++;
                if(awards===300)
                {
                    clearInterval(awards_interval);
                }
                numbers[3].textContent=awards;
            },1000/300);
        }
       flag=true;
    }
    
}

/* End of about us ( Clints )*/ 

