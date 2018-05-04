﻿

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

$(document).ready(function () {


    for (var i = 700; i <= 1700; i += 15) {
        var mins = i % 100;
        var hours = parseInt(i / 100);

        if (mins > 45) {
            mins = 0;
            hours += 1;
            i = hours * 100;
        }

        //Logic that converts hours to standard time am/pm
        var standardTime = ' AM';

        if (hours > 12) {
            standardTime = ' PM';
            hours %= 13;
            hours++;
        } else {
            hours %= 13;
        }

        $('#stime').append('<option value="' + i + '">' + ('0' + (hours)).slice(-2) + ':' + ('0' + mins).slice(-2) + standardTime + '</option>');
    }

    $('#stime').on('change', function () {
        console.log("just is just a test");
        var meetingLength = 30;
        var selectedTime = Number($('#stime').val());
        var sum = meetingLength + selectedTime;

        $("#etime").html("<option value=\"\">--Select end time--</option>");

        for (var i = sum; i <= 1700; i += meetingLength) {
            var mins = i % 100;
            var hours = parseInt(i / 100);

            if (mins > 59) {
                mins = 0;
                hours += 1;
                i = hours * 100;
            }

            //Logic that converts hours to standard time am/pm
            var standardTime = ' AM';

            if (hours > 12) {
                standardTime = ' PM';
                hours %= 13;
                hours++;
            } else {
                hours %= 13;
            }
            console.log("we are trying to add more times i =" + i + "");
            $('#etime').append('<option value="' + i + '">' + ('0' + (hours)).slice(-2) + ':' + ('0' + mins).slice(-2) + standardTime + '</option>');
        }
    });

});













