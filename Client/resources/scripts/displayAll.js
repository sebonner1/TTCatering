function getAllReports()
{
    const allReportsAPIURL = "https://localhost:5000/api/reports";

    fetch(allReportsAPIURL).then(function(response){
        console.log(response);
        return response.json();
    }).then(function(json){
        let html = "<ul>";
        json.forEach((CartTotal)=>{
            html += "<li>" +CartTotal.orderID, 
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += "$" + CartTotal.totalprice,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CartTotal.qckparm,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CartTotal.qccc,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CartTotal.qvegb,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CartTotal.qcss,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CartTotal.qturk,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CartTotal.qhouse,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CartTotal.pckparm,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CartTotal.pccc,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CartTotal.pvegb,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CartTotal.pcss,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CartTotal.pturk,
            html += "&nbsp",
            html += "&nbsp",
            html += "&nbsp",
            html += CartTotal.phouse,
            "</li>"
        })
        html += "</ul>";
        document.getElementById("carttotals").innerHTML = html;
    }).catch(function(error){
        console.log(error);
    })
}

// add to the if statement here
const selectmenu = document.querySelector("select");
selectmenu.addEventListener("input", (e) => {
    //getAllReports();
    console.log(e.target.value);
    if(e.target.value = "viewall")
    {
        getAllReports();
    }
    else{
        if(e.target.value = "Orderspermonth")
        {
            // insert the method here
        }
        if(e.target.value = "Mostpopularitems")
        {
            // insert the method here
        }
        if(e.target.value = "Mostprofitableitems")
        {
            // insert the method here
        }
        if(e.target.value = "Percentpickupvsdelivered")
        {
            // insert the method here
        }
        if(e.target.value = "Mostpopularhours")
        {
            // insert the method here
        }
        if(e.target.value = "Leastpopularitem")
        {
            // insert the method here
        }
    }
})