function Toggle() {
        //Toggle password:
    const togglePassword = document.querySelector("#togglePassword");
    const password = document.querySelector("#pass");
    togglePassword.addEventListener("click", function () {
        // toggle the type attribute
    const type = password.getAttribute("type") === "password" ? "text" : "password";
    password.setAttribute("type", type);
        // toggle the eye / eye slash icon
    this.classList.toggle("bi-eye");
},

function validication() {
    

        var username = document.getElementById("user").value;
        var nickn = document.getElementById("nickname").value;
        var psw = document.getElementById("password").value;
        let user = document.getElementById('user');
        let pass = document.getElementById('password');
        let user_records = new Array();
        user_records = JSON.parse(localStorage.getItem("users")) ? JSON.parse(localStorage.getItem("users")) : []

        if (user.value.length <= 8 && user.value.length >= 2) { } else {
            alert("Username has to be between 2-8 characters.")
        }

        if (pass.value.length <= 8 && pass.value.length >= 2) { } else {
            alert("Password has to be between 2-8 characters.")
            return false;
        }
        let pattern = /[A-Za-z]+[0-9]\w{1,9}$/;
        if (!pass.value.match(pattern)) {
            alert("Password has to include characters and numbers")
            return false;
        }

        var confirmpass = document.getElementById('confirm').value;

        if (pass.value != confirmpass) {
            alert("Password didn't match, try again.");

        }
        if (user_records.some((v) => { return v.user == user.value })) {
            alert('The user already exist')
            return false;
        }

        else if ((user.value != "") || (pass.value != "")) {
            user_records.push({
                "user": username,
                "nickname": nickn,
                "password": psw

            })
            localStorage.setItem("users", JSON.stringify(user_records));
            alert('Registered successfully')
            window.location.href = "http://localhost:12327/login";

        }

    }

