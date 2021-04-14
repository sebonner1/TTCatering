console.log("javascript loaded");
function getCart(){
    const allCartAPIURL = "https://localhost:5000/api/MenuItems";

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
    const addCartAPIURL = "https://localhost:5000/api/cartAPI" + cartid;
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
    const delCartAPIURL = "https://localhost:5000/api/cartAPI" + cartid;
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
function chickenparmfunction(){
    const addPostsAPIURL = "https://localhost:5000/api/cartAPI";
    const itemPost = "chickenparm";
    console.log(itemPost);
    fetch(addPostsAPIURL, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify({
          itemName: itemPost
        })
    }).then((response)=>{
        console.log(response);
        getCart();
    })
}