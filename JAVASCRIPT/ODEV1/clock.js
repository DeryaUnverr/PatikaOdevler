// adım1:
let fullName = prompt("Adınız Nedir? ")

let myName = document.querySelector("#myName")

myName.innerHTML = `${fullName}`

//adım2:

function Times(items) {
let dateNow = document.querySelector("#myClock")

let gunler= ["Pazar","Pazartesi","Salı","Çarşamba","Perşembe","Cuma","Cumartesi"];
    let clock = new Date()
    let hours = clock.getHours()
    let minutes = clock.getMinutes()
    let seconds = clock.getSeconds()
    let days = gunler[clock.getDay()]
    dateNow.innerHTML=`${hours}:${minutes}:${seconds} ${days}`
}
setInterval(Times,1000)