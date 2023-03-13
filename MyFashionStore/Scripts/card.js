var plus = document.querySelectorAll("#plus");

var minous = document.querySelectorAll("#minous");

var total_price = document.querySelector(".Total_price span:nth-child(2)");

var intialPrice =document.querySelectorAll(".price_hidden");

var cartItems = document.querySelectorAll(".cartItem");

var s = 0;

intialPrice.forEach(IP => {
    s = s + parseInt(IP.textContent);
});
total_price.textContent = s;
console.log(s);
plus.forEach(p => {
    p.addEventListener("click", function (e) {
        var quantity = e.target.parentElement.children[1].textContent++ + 1;
        var itemPrice = e.target.parentElement.nextElementSibling.children[1].textContent; // hidden
        var itemP = e.target.parentElement.nextElementSibling.children[2];
        //itemP.textContent = '';
        itemP.textContent = itemPrice * quantity;
        s += parseInt(itemPrice);
        total_price.textContent = s;
        console.log(s);
    });
});


minous.forEach(p => {
    p.addEventListener("click", function (e) {
       var quantity = e.target.parentElement.children[1];
        if (quantity.innerHTML != 1) {
            var quantity = e.target.parentElement.children[1].textContent-- -1;
            var itemPrice = e.target.parentElement.nextElementSibling.children[1].textContent; // hidden
            var itemP = e.target.parentElement.nextElementSibling.children[2];
            //itemP.textContent = '';
            itemP.textContent = itemPrice * quantity;
            s -= parseInt(itemPrice);
            total_price.textContent = s;
            console.log(s);
        }
        else
        {
            e.preventDefault();
        }
    });
});


var c = document.querySelector("#checkOut");
c.onclick = function () {
    Swal.fire({
        position: 'top-end',
        icon: 'success',
        title: 'Your work has been saved',
        showConfirmButton: false,
        timer: 1500
    })
}

