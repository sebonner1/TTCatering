  window.onload = function() {
    var day = document.getElementById("weekdays_short");
    var timeSel = document.getElementById("time");
    var addressSel = document.getElementById("address");
  
    // The manager login is below, working on taking it to the next page, the dashboard
    if (day === "S") {
        alert("You have successfully logged in.");
        window.location.href= "../resources/ManagerDashboard";
    } 
}
