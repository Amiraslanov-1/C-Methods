let form = document.querySelector('form');
let welcome = document.getElementById('welcome')
let student = {
    username: "Ibrahim",
    password: "teacher",
    isLogin: false
}
if (!localStorage.getItem('user')) {
    localStorage.setItem('user', JSON.stringify(student))

}
var user = JSON.parse(localStorage.getItem('user'))
if (user.isLogin == true) {
    form.style.display = 'none'
    welcome.style.display = 'block'
}
Login();

function Login() {
    form.addEventListener('submit', function() {
        let inpUsername = document.getElementById('emailInput');
        let InpPassword = document.getElementById('passwordInput');
        var user = JSON.parse(localStorage.getItem('user'));
        if (user.username == inpUsername.value && user.password == InpPassword.value) {
            student.isLogin = true;
            localStorage.setItem('user', JSON.stringify(student))
            form.style.display = 'none';
            welcome.style.display = 'block';
        }
    })
}
let clearBtn = document.getElementById('logOut');


function LogOut() {
    clearBtn.addEventListener('click', function() {
        localStorage.clear();
        form.style.display = 'block';
        welcome.style.display = 'none'
    })
}
LogOut();