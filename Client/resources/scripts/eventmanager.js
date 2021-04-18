console.log("javascript loaded");
function getEvents(){
    const allCartAPIURL = "https://localhost:5000/api/cartAPI";

    fetch(allCartAPIURL).then(function(response){
        return response.json();
    }).then(function(json){
        let html = "<ul>";
        json.forEach((CateringEvent)=>{
            html += "<li id = event" + CateringEvent.orderID+ " descriptiona = "+ CateringEvent.orderDescription+ ">" +CartItem.quantity,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CateringEvent.orderEventMethod,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CateringEvent.orderDate,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += "<button onclick=\"addEvent("+CateringEvent.orderID+")\">+</button>",
            html += "<button onclick=\"delCart("+CateringEvent.orderID+")\">-</button>" + "</li>"
        })
        html += "</ul>";
        document.getElementById("cateringevents").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    })
}
function addEvent(orderID){
    const addCartAPIURL = "https://localhost:5000/api/cartAPI/" + orderID;
    console.log(orderID);
    var event = {
        description: document.getElementById("event"+orderID).getAttribute("descriptiona"),
    }
    fetch(addCartAPIURL, {
        method: "PUT",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json'
        },
        body: JSON.stringify(event)
    }).then((response)=>{
        console.log(response);
        getCart();
    })
}
function delCart(orderID){
    const delCartAPIURL = "https://localhost:5000/api/cartAPI/" + orderID;
    console.log(orderID);
    
    fetch(delCartAPIURL, {
        method: "DELETE",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json'
        }
    }).then((response)=>{
        console.log(response);
        getEvents();
    })
}