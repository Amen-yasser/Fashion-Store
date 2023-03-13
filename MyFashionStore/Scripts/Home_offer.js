
/*Count down offer */

var Seconds = 1000000;
var count_down_div = document.getElementById('count-down');
var disc = document.createElement('h3');
disc.textContent = '\u00a0\u00a0\u00a0D\u00a0\u00a0\u00a0\u00a0\u00a0H'
+'\u00a0\u00a0\u00a0\u00a0\u00a0\u00a0\u00a0M\u00a0\u00a0\u00a0\u00a0\u00a0\u00a0 S';
var count_down_content = document.createElement('h1');
count_down_div.append(count_down_content);
count_down_div.append(disc);
count_down_content.setAttribute('class','count-down-content');
var myInterval = setInterval(function(){
    'use strict';
    var Days = Math.floor(Seconds/86400);
    var Hours = Math.floor(Seconds/(60*60));
    var Minutes = Math.floor(Seconds/60);
    var TheSecond = Seconds%60;
    if(Days<10)
    {
        Days='0'+Days;
    }
    if(Hours<10)
    {
        Hours='0'+Hours;
    }
    if(Minutes<10)
    {
        Minutes='0'+Minutes;
    }
    if(TheSecond<10)
    {
        TheSecond='0'+TheSecond;
    }
    count_down_content.textContent=' - '+Days+' : '+Hours+' : '+Minutes+' : '+TheSecond;
    if(Seconds>0)
    {
        Seconds-=1;
    }
    else
    {
        clearInterval(myInterval);
        count_down_content.textContent="Offer is over..."
    }

},1000);

/* ُEnd ofCount down offer */