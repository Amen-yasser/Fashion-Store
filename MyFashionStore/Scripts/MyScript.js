var local_color = localStorage.getItem('color-option');
if(local_color!==null)
{
    document.documentElement.style.setProperty('--main-color',local_color);
}
else
{
    console.log('nooooooooo')
}









//var Accesoreies_filter = document.querySelector('#mix2 .Accesoreies-filter');
//var kids_filter = document.querySelector('#mix2 .kids-filter');
//var mix1 = document.querySelectorAll('#mix1 li');
//var inner_filter = document.querySelector('.inner-filter');
//mix1.forEach(li=>{
//    li.addEventListener('click',function(e){
//        inner_filter.classList.add('open1');
//        if(e.target.dataset.filter===".Accesoreies")
//        {
//            Accesoreies_filter.style.display="block";
//            kids_filter.style.display="none";
//        }
//        else if(e.target.dataset.filter===".Kids")
//        {
//            kids_filter.style.display="block";
//            Accesoreies_filter.style.display="none";
//        }
//        else if(e.target.dataset.filter==="all")
//        {
//            inner_filter.classList.remove('open1');
//        }
//        else
//        {
//            Accesoreies_filter.style.display="none";
//            kids_filter.style.display="none";
//        }
        
//    });
   
//});
/*End of  Mix it up*/



