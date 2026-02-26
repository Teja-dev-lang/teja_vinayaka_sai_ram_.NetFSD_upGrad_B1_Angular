class Student {
    constructor(name) {
        this.name = name
        this.marks = []
    }

    addMarks(n_marks) {
        this.marks.push(n_marks)
    }

    getAverage() {
        if (this.marks.length === 0) {
            return 0;
        }
        console.log(this.marks.reduce((sum, mark) => { return sum + mark }, 0) / this.marks.length);
    }

    getGrade() {
        if (this.marks.length === 0) {
            return "No Grade";
        }

        const avg = this.getAverage();

        if (avg >= 90) {
            return "A"
        };
        if (avg >= 75) {
            return "B"
        };
        if (avg >= 60){ 
            return "C"
        };
        if (avg >= 40){
            return "D"
        };
        return "F";
    }
}

let s1 = new Student("teja");
s1.addMarks(20);
