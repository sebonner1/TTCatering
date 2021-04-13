  window.onload = function() {
    var monthSel = document.getElementById("month");
    var daySel = document.getElementById("day");
    var timeSel = document.getElementById("time");
    for (var x in monthObject) {
      monthSel.options[monthSel.options.length] = new Option(x, x);
    }
    monthSel.onchange = function() {
      //empty Chapters- and Topics- dropdowns
      timeSel.length = 1;
      daySel.length = 1;
      //display correct values
      for (var y in monthObject[this.value]) {
        daySel.options[daySel.options.length] = new Option(y, y);
      }
    }
    daySel.onchange = function() {
      //empty Chapters dropdown
      timeSel.length = 1;
      //display correct values
      var z = monthObject[monthSel.value][this.value];
      for (var i = 0; i < z.length; i++) {
        timeSel.options[timeSel.options.length] = new Option(z[i], z[i]);
      }
    }
  }