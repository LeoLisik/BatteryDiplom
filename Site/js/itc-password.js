window.onload = () => {
    var buttons = document.getElementsByClassName("btn");
    if (buttons.length > 0) {
        for (var i = 0; i < buttons.length; i++) {
            buttons[i].onclick = receiver(buttons[i]);
        }
    }
};

function receiver(val) {
    return function(){
        if(val.id =="show"){
            var input = document.getElementById("password");
            var img = document.getElementById("show-img");
            if(input.getAttribute('type') == 'password') {
                input.removeAttribute('type');
                input.setAttribute('type', 'text');
                img.src = "../images/authorization/openEye.png";
            }
            else {
                input.removeAttribute('type');
                input.setAttribute('type', 'password');
                img.src = "../images/authorization/closeEye.png";
        }
        }
        else if(val.id =="show1"){
            var input = document.getElementById("password1");
            var img = document.getElementById("show-img1");
            if(input.getAttribute('type') == 'password') {
                input.removeAttribute('type');
                input.setAttribute('type', 'text');
                img.src = "../images/authorization/openEye.png";
            }
            else {
                input.removeAttribute('type');
                input.setAttribute('type', 'password');
                img.src = "../images/authorization/closeEye.png";   
        }
        }
        else{
            var input = document.getElementById("password2");
            var img = document.getElementById("show-img2");
            if(input.getAttribute('type') == 'password') {
                input.removeAttribute('type');
                input.setAttribute('type', 'text');
                img.src = "../images/authorization/openEye.png";
            }
            else {
                input.removeAttribute('type');
                input.setAttribute('type', 'password');
                img.src = "../images/authorization/closeEye.png";   
        }
        }
        return false;
    }
    };