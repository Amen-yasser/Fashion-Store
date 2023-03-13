




/* GO UP */
var goup = document.getElementById('goup');
window.onscroll = function () {
    console.log(window.scrollY);
    if (window.scrollY >= 1500) {
        goup.style.display = 'block';
        console.log('egegegege');
    }
    else {
        goup.style.display = 'none';
    }
};

goup.onclick = function () {
    window.scroll({
        top: 0,
        left: 0,
        behavior: 'smooth'

    });
}
/* End Of GO UP */


/*change color*/

// open and close option box
var gear = document.querySelector('.fa-gear');
gear.onclick = function () {
    this.classList.toggle('fa-spin');
    document.querySelector('.option-box').classList.toggle('open');
};


// change of the color
const colorlist = document.querySelectorAll('.color-list li');
colorlist.forEach(li => {

    li.addEventListener('click', function (e) {

        document.documentElement.style.setProperty('--main-color', e.target.dataset.color);
        localStorage.setItem('color-option', e.target.dataset.color);
        e.target.parentElement.querySelectorAll('.active').forEach(el => {

            el.classList.remove('active');
        });

        e.target.classList.add('active');
    });
});

/*End of change color*/
