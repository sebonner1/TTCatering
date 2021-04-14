console.log("javascript loaded");
function getCart(){
    const allCartAPIURL = "https://localhost:5000/api/cartAPI";

    fetch(allCartAPIURL).then(function(response){
        return response.json();
    }).then(function(json){
        let html = "<ul>";
        json.forEach((CartItem)=>{
            html += "<li>" +"<button onclick=\"addCart("+CartItem.cartid+")\">+</button>",
            html += CartItem.itemName,
            html += "<button onclick=\"delCart("+CartItem.cartid+")\">-</button>" + "</li>"
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
    const postCartAPIURL = "https://localhost:5000/api/cartAPI";
    var itemPost = "chicken parmesan";
    itemPost = itemPost.toString();
    var item = {
        cartid: 2,
        itemName: "chicken parmesan",
        price: 1,
        quantity: 2
    }
    console.log(itemPost);
    fetch(postCartAPIURL, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(item)
    }).then((response)=>{
        console.log(response);
        getCart();
    })
}
function chocchipfunction(){
    const postCartAPIURL = "https://localhost:5000/api/cartAPI";
    var itemPost = "chocolate chip cookie";
    itemPost = itemPost.toString();
    var item = {
        cartid: 2,
        itemName: "chocolate chip cookie(s)",
        price: 1,
        quantity: 2
    }
    console.log(itemPost);
    fetch(postCartAPIURL, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(item)
    }).then((response)=>{
        console.log(response);
        getCart();
    })
}
function vegburgfunction(){
    const postCartAPIURL = "https://localhost:5000/api/cartAPI";
    var itemPost = "veggie burger";
    itemPost = itemPost.toString();
    var item = {
        cartid: 2,
        itemName: "Veggie Burger",
        price: 1,
        quantity: 2
    }
    console.log(itemPost);
    fetch(postCartAPIURL, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(item)
    }).then((response)=>{
        console.log(response);
        getCart();
    })
}
function chicksaladfunction(){
    const postCartAPIURL = "https://localhost:5000/api/cartAPI";
    var itemPost = "chicken salad sandwich";
    itemPost = itemPost.toString();
    var item = {
        cartid: 2,
        itemName: "chicken salad sandwich",
        price: 1,
        quantity: 2
    }
    console.log(itemPost);
    fetch(postCartAPIURL, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(item)
    }).then((response)=>{
        console.log(response);
        getCart();
    })
}
function turkfunction(){
    const postCartAPIURL = "https://localhost:5000/api/cartAPI";
    var itemPost = "turkey melt";
    itemPost = itemPost.toString();
    var item = {
        cartid: 2,
        itemName: "Turkey Melt",
        price: 1,
        quantity: 2
    }
    console.log(itemPost);
    fetch(postCartAPIURL, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(item)
    }).then((response)=>{
        console.log(response);
        getCart();
    })
}
function housesaladfunction(){
    const postCartAPIURL = "https://localhost:5000/api/cartAPI";
    var itemPost = "house salad";
    itemPost = itemPost.toString();
    var item = {
        cartid: 2,
        itemName: "house salad",
        price: 1,
        quantity: 2
    }
    console.log(itemPost);
    fetch(postCartAPIURL, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(item)
    }).then((response)=>{
        console.log(response);
        getCart();
    })
}