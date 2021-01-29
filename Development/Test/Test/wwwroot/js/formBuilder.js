function section1() {
    document.getElementById('builder0').style.display = 'none';
    document.getElementById('builder1').style.display = 'block';
}

document.forms[0].onsubmit = () => {
    //var xhttp = new XMLHttpRequest();
    //var data = new FormData(document.forms[0]);
    ////var data = "author=AUTHOR&title=TITLE";
    ////data = data.replace("AUTHOR", document.getElementById("qAuthor").value)
    ////data = data.replace("TITLE", document.getElementById("qTitle").value)
    //xhttp.onreadystatechange = function () {
    //    if (this.readyState == 4 && this.status == 200) {
    //        console.log(this.status)
    //    }
    //    else if (this.status != 200) {
    //        console.log(this.status)
    //        document.getElementById('error').innerHTML = this.status;
    //    }
    //};
    //xhttp.open("post", "/FormBuilder", true);
    //xhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    //xhttp.send(new URLSearchParams(data));

    //document.getElementById('builder1').style.display = 'none';
    //document.getElementById('builder2').style.display = 'block';
    //return false;

    let formData = new FormData(document.forms[0]);
    //console.log(new URLSearchParams(formData).toString());
    fetch('/FormBuilder', {
        method: 'post',
        body: new URLSearchParams(formData)
    })
        .then(() => {
            console.log(this.status)
            document.getElementById('builder1').style.display = 'none';
            document.getElementById('builder2').style.display = 'block';
        });
    return false;
};

