// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
// Write your Javascript code.

var responseIndex = 1;
var responses = document.getElementsByClassName("response");

showResponse();

function changeResponse(increment)
{
    responses = document.getElementsByClassName("response");
    
    if (responseIndex == responses.length && increment > 0) {
        responseIndex = 1;
    }
    else if (responseIndex == 1 && increment < 0) {
        responseIndex = responses.length;
    }
    else {
        responseIndex += increment;
    }

    showResponse(responseIndex);
}

function showResponse(response)
{
    var i;

    for (i = 0; i < responses.length; i++) {
        responses[i].style.display = "none";
    }

    if (responses.length > 1) {
        responses[responseIndex - 1].style.display = "block";
    }

    else {
        responseIndex = 0
    }

    document.getElementById("indicator").innerHTML = ("Current Response: " + responseIndex);
}