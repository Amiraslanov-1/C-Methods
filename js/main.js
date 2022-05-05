// class Student {
//     constructor(name, surname, age, point) {
//         this.Name = name,
//             this.Surname = surname,
//             this.Age = age,
//             this.Point = point
//     }
// }

// let std1 = new Student('Salam', 'Salamov', 18, 76)
// let std2 = new Student('Salam1', 'Salamov1', 18, 56)
// let std3 = new Student('Salam2', 'Salamov2', 18, 46)

// let arr = [std1, std2, std3]

// function Exam(arr) {

//     let newArr = [];
//     for (let i = 0; i < arr.length; i++) {
//         if (arr[i].Point > 50) {
//             newArr[newArr.length] = arr[i]
//         }
//     }
//     return newArr;


// }
// //console.log(Exam(arr))

// function Repeat(word, count = 1) {
//     let arr = "";
//     for (let index = 0; index < count; index++) {

//         arr += word;

//     }
//     return arr;
// }

// console.log(Repeat("ha!", 3))


// function isEven(nums) {
//     let count = 0;
//     for (let i = 0; i < nums.length; i++) {
//         if (!isNaN(nums[i])) {
//             if (nums[i] % 2 == 0) {
//                 count++;
//             }
//         }

//     }
//     return count;
// }
// console.log(isEven([1, 2, 3, "sass", true]))


// const fruits = ["Banana", "Orange", "Apple", "Mango"];
// let fruit = fruits.join(1)


// console.log(fruit);
// const fruits1 = ["Banana", "Orange", "Apple", "Mango"];


// console.log(fruits1.pop())
// const fruits2 = ["Banana", "Orange", "Apple", "Mango"];
// let length = fruits.push("Kiwi");
// console.log(length)






// function SumArrayElement(nums, num) {

//     if (nums.length <= num) {
//         return 0;
//     }
//     return nums[num] + Sum(nums, num + 1)

// }
// console.log(Sum([1, 2, 3, 4, 5], 8))




class Person {
    constructor(name, surname, age) {
        this.Name = name,
            this.Surname = surname,
            this.Age = age

    }
    GetInfo() {
        return `Name:${this.Name} Surname :${this.surname} Age ${this.Age}`
    }
}
class Employe extends Person {
    constructor(name, surname, age, salary) {

        super(name, surname, age)
        this.Salary = salary;
    }



}

class Department {
    constructor(name) {
        this.Name = name

    }
    Employees = [];
    Add(employee1) {
        this.Employees.push(employee1)
    }
    SearchEmployeByName(search) {
        return this.Employees.forEach(el => el.Name.includes(search))
    }
    GetEmployeeSalaryAvg() {
        total = 0;

        this.Employees.forEach(x => total += x.Salary)
        return total / this.Employees.length

    }

}
let deparmentName = prompt("Dp Name :")
let department = new Department(deparmentName)
check = true;

do {
    let empName = prompt("Emp Name :")
    let empSurname = prompt("Emp Surname :")
    let age = prompt("Age Daxil Edin :")
    while (isNaN(age)) {
        age = prompt("Duzgun Daxil Edin :")
    }
    let salary = prompt("Salary Daxil Edin :")
    while (isNaN(salary)) {
        salary = prompt("Duzgun Daxil Edin :")
    }
    let emp = new Employe(empName, empSurname, age, salary)
    department.Add(emp);

    let com = confirm("Quit ?")
    if (com == "q") {
        check = false;
    }

} while (check);
console.log(department.Employees)