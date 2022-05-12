let devices = document.querySelectorAll(".device");
let dragoverableAreas = document.querySelectorAll(".dragover");
let addBtns = document.querySelectorAll(".add-button");
let allDevices = document.querySelector(".all-devices");

let currentDevice;

addBtns.forEach(addBtn => {
    addBtn.addEventListener("click", (event) => {
        let device = event.target.parentNode;
        if (addBtn.innerHTML == '<i class="fa-solid fa-file-circle-plus"></i> Add to list') {
            dragoverableAreas.forEach(area => {
                if (device.getAttribute("data-id") == area.getAttribute("data-target")) {
                    area.appendChild(device);
                    addBtn.innerHTML = '<i class="fa-solid fa-x"></i> Remove';
                }
            });
        }
        else if (addBtn.innerHTML == '<i class="fa-solid fa-x"></i> Remove') {
            allDevices.appendChild(device);
            addBtn.innerHTML = '<i class="fa-solid fa-file-circle-plus"></i> Add to list'
        }

    });
});

devices.forEach(device => {
    device.addEventListener("dragstart", function () {
        currentDevice = this;
    });
});

allDevices.addEventListener("dragover", (event) => {
    event.preventDefault();
});

allDevices.addEventListener("drop", function (event) {
    allDevices.appendChild(currentDevice);
    currentDevice.children[1].innerHTML = '<i class="fa-solid fa-file-circle-plus"></i> Add to list';
});

dragoverableAreas.forEach(area => {
    area.addEventListener("dragover", (event) => {
        event.preventDefault();
    });
    area.addEventListener("drop", function (event) {
        if (area.getAttribute("data-target") == currentDevice.getAttribute("data-id")) {
            area.appendChild(currentDevice);
            currentDevice.children[1].innerHTML = '<i class="fa-solid fa-x"></i> Remove'    ;
        }
        else {
            alert("You can't add this product here!");
        }
    });
});