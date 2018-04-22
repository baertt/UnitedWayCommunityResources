function myFunction() {
    document.getElementById("myDropdown").classList.toggle("show");
}



function funct() {
            var date = $("#datepicker").datepicker({dateFormat: "yy-mm-dd" }).onSelect();
            document.getElementById("date").value = str;
}
    

window.onclick = function (event) {
    if (!event.target.matches('.dropbtn')) {

        var dropdowns = document.getElementsByClassName("dropdown-content");
        var i;
        for (i = 0; i < dropdowns.length; i++) {
            var openDropdown = dropdowns[i];
            if (openDropdown.classList.contains('show')) {
                openDropdown.classList.remove('show');
            }
        }
    }
};
