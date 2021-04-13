function getCart(){
    const allCartAPIURL = "https://localhost:5001/api/cartAPI";

    fetch(allCartAPIURL).then(function(response){
        return response.json();
    }).then(function(json){
        let html = "<ul>";
        json.forEach((CartItem)=>{
            html += "<li>" +"<button onclick=\"addCart("+cart.cartid+")\">+</button>",
            html += cart.itemName,
            html += "<button onclick=\"delCart("+cart.cartid+")\">-</button>" + "</li>"
        })
        html += "</ul>";
        document.getElementById("cartitems").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    })
}
function addCart(cartid){
    const addCartAPIURL = "https://localhost:5001/api/cartAPI" + cartid;
    console.log(cartid);
    
    fetch(addCartAPIURL, {
        method: "PUT",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json'
        }
    }).then((response)=>{
        console.log(response);
        getCart();
    })
}
function delCart(cartid){
    const delCartAPIURL = "https://localhost:5001/api/cartAPI" + cartid;
    console.log(cartid);
    
    fetch(delCartAPIURL, {
        method: "DELETE",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json'
        }
    }).then((response)=>{
        console.log(response);
        getCart();
    })
}