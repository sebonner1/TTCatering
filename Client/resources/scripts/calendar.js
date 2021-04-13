function onChange() {
    kendoConsole.log("Book: " + kendo.toString(this.value(), 'd'));
}

function onNavigate() {
    kendoConsole.log("Navigate");
}

$("#calendar").kendoCalendar({
    change: onChange,
    navigate: onNavigate
});