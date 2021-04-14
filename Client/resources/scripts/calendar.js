  window.onload = function() {
    var day = document.getElementById("weekdays_short");
    var timeSel = document.getElementById("time");
    var addressSel = document.getElementById("address");
    loadTimes();
  
    // The manager login is below, working on taking it to the next page, the dashboard
    if (day === "S") {
        alert("You have successfully logged in.");
        window.location.href= "../resources/ManagerDashboard";
    } 
}

function loadTimes()
{
  var timeSel = document.getElementById("time");
  timeSel.innerHTML = `
  <option value="" selected="selected">Please select a day first</option>
  <option value="7:00 AM">7:00 AM</option>
  <option value="8:00 AM">8:00 AM</option>
  <option value="9:00 AM">9:00 AM</option>
  <option value="10:00 AM">10:00 AM</option>
  <option value="11:00 AM">11:00 AM</option>
  <option value="12:00 PM">12:00 PM</option>
  <option value="1:00 PM">1:00 PM</option>
  <option value="2:00 PM">2:00 PM</option>
  <option value="3:00 PM">3:00 PM</option>
  <option value="4:00 PM">4:00 PM</option>
  <option value="5:00 PM">5:00 PM</option>
  <option value="6:00 PM">6:00 PM</option>
  <option value="7:00 AM">7:00 PM</option>
  `;
}
