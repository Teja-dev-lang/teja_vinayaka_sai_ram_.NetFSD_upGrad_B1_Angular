let students = [

    { name: "Akhil", marks: 85 },

    { name: "Priya", marks: 72 },

    { name: "Ravi", marks: 90 },

    { name: "Meena", marks: 45 },

    { name: "Karan", marks: 30 }

];


let stud_passed = students.filter((data) => {
    return data.marks >= 45
})
console.log(stud_passed)

let stud_distinction = students.filter((data) => {
    return data.marks >= 85
})
console.log(stud_distinction)

let studs_avg_marks = students.reduce((acc, curr) => {
    return acc + curr.marks
}, 0) / (students.length)
console.log(studs_avg_marks)

let studs_topper = students.reduce((acc, curr) => {
    return acc.marks < curr.marks ? curr : acc
})
console.log(studs_topper)

let stud_failed = students.filter((data) => {
    return data.marks < 45
})
console.log(stud_failed)

let studentsWithGrades = students.map(student => {
    let grade;

    if (student.marks >= 85) grade = "A";
    else if (student.marks >= 60) grade = "B";
    else if (student.marks >= 40) grade = "C";
    else grade = "Fail";

    return {
        ...student,grade: grade
    };
});

console.log(studentsWithGrades);
