
var users = [{
    usr: 'tinkiwinki',
    nickn: 'tiwi',
    pas: 'tinki12',

}, {
    usr: 'depsi',
    nickn: 'depsipo',
    pas: 'depsi34',
}, {
    usr: 'lalapo',
    nickn: 'lapo',
    pas: 'lala789',
}];

console.log("Checking");
const form = document.querySelector("form");
username = form.querySelector(".user"),
    eInput = username.querySelector("input"),
    pass = form.querySelector(".password"),
    pInput = pass.querySelector("input");
//function ready(){
form.onsubmit = (e) => {
    e.preventDefault(); //preventing from form submitting
    //if user/pass are not valid -> do the shake and error message
    (eInput.value == "") ? username.classList.add("shake", "error") : user_func();
    (pInput.value == "") ? pass.classList.add("shake", "error") : pass_func();

    setTimeout(() => { //remove shake class after 500ms
        username.classList.remove("shake");
        pass.classList.remove("shake");
    }, 500);

    eInput.onkeyup = () => { user_func(); } //calling function
    pInput.onkeyup = () => { pass_func(); } //calling function


    // for (var index in users) {
    var user0 = users[0];
    var user1 = users[1];
    var user2 = users[2];
    if (eInput.value != "") {
        if ((eInput.value === user0.usr && pInput.value === user0.pas) || (eInput.value === user1.usr && pInput.value === user1.pas) ||
            (eInput.value === user2.usr && pInput.value === user2.pas)) {
            window.location.href = "http://localhost:40179/Chat";
        }
        else {
            alert("User does not exist !.")
        }
    }

    function user_func() {

        if (eInput.length > 8 || eInput.length < 2) {
            username.classList.add("error");
            username.classList.remove("valid");
            let errorTxt = username.querySelector(".error-txt");
            //if user value is not empty then show please enter valid user else show user is not valid
            (eInput.value != "") ? errorTxt.innerText = "Enter a valid username" : errorTxt.innerText = "User is not valid";
        } else { //if pattern matched then remove error and add valid class
            username.classList.remove("error");
            username.classList.add("valid");
        }

    }

    function pass_func() {
        let pattern = /^[A-Za-z]\w{1,9}$/;

        if (!pInput.value.match(pattern)) { //if pattern not matched then add error 
            pass.classList.add("error");
            pass.classList.remove("valid");
            let errorTxt = pass.querySelector(".error-txt");
            (pInput.value != "") ? errorTxt.innerText = "Enter a valid password" : errorTxt.innerText = "pass is not valid";
        }
        else if (pInput.value == "") { //if pass is empty then add error and remove valid class
            pass.classList.add("error");
            pass.classList.remove("valid");
        } else { //if pass is empty then remove error and add valid class
            pass.classList.remove("error");
            pass.classList.add("valid");
        }
    }

}
