INSERT INTO Departments VALUES
(1,'Computer Science','Block A'),
(2,'Mechanical','Block B'),
(3,'Electrical','Block C'),
(4,'Civil','Block D'),
(5,'Electronics','Block E');

INSERT INTO Teachers
(TeacherID,TeacherName,Email,DepartmentID,Hiredate)
VALUES
(12,'Dr Meera','meera@uni.com',2,'2022-01-10'),
(13,'Dr Arjun','arjun@uni.com',3,'2020-09-01'),
(14,'Dr Ramesh','ramesh@uni.com',4,'2018-06-12'),
(15,'Dr Kavitha','kavitha@uni.com',5,'2019-03-25'),
(16,'Dr Sandeep','sandeep@uni.com',1,'2021-11-05'),
(17,'Dr Lakshmi','lakshmi@uni.com',2,'2017-07-19'),
(18,'Dr Varun','varun@uni.com',3,'2020-02-14'),
(19,'Dr Nisha','nisha@uni.com',4,'2023-01-08'),
(20,'Dr Karthik','karthik@uni.com',5,'2019-10-30');

select * from Students

INSERT INTO Students VALUES
(101,'Teja','Kumar','2003-04-10','M',1,'2023-07-01'),
(102,'Rahul','Varma','2002-05-12','M',2,'2023-07-01'),
(103,'Anitha','Rao','2003-03-15','F',3,'2023-07-01'),
(104,'Priya','Reddy','2002-08-21','F',4,'2023-07-01'),
(105,'Arjun','Naidu','2003-09-09','M',5,'2023-07-01'),
(106,'Sneha','Patel','2002-11-11','F',1,'2023-07-01'),
(107,'Vikram','Das','2003-01-19','M',2,'2023-07-01'),
(108,'Pooja','Shah','2002-06-25','F',3,'2023-07-01'),
(109,'Kiran','Yadav','2003-02-18','M',4,'2023-07-01'),
(110,'Neha','Gupta','2002-12-05','F',5,'2023-07-01'),
(111,'Rohit','Singh','2003-03-11','M',1,'2023-07-01'),
(112,'Asha','Nair','2002-07-14','F',2,'2023-07-01'),
(113,'Varun','Reddy','2003-05-22','M',3,'2023-07-01'),
(114,'Divya','Khan','2002-10-10','F',4,'2023-07-01'),
(115,'Surya','Pillai','2003-09-01','M',5,'2023-07-01'),
(116,'Megha','Seth','2002-04-03','F',1,'2023-07-01'),
(117,'Nikhil','Roy','2003-06-17','M',2,'2023-07-01'),
(118,'Kavitha','Rao','2002-01-28','F',3,'2023-07-01'),
(119,'Ajay','Verma','2003-08-15','M',4,'2023-07-01'),
(120,'Riya','Kapoor','2002-02-02','F',5,'2023-07-01');


INSERT INTO Courses
(course_id,courseName,credits,DepartmentID,TeacherID)
VALUES
(1,'Database Systems',4,1,12),
(2,'Operating Systems',4,1,13),
(3,'Thermodynamics',3,2,14),
(4,'Fluid Mechanics',3,2,15),
(5,'Circuit Analysis',4,3,16);

INSERT INTO Enrollments
(enrollment_id,student_id,course_id)
VALUES
(1,101,1),
(2,102,2),
(3,103,3),
(4,104,4),
(5,105,5),
(6,106,1),
(7,107,2),
(8,108,3),
(9,109,4),
(10,110,5),
(11,111,1),
(12,112,2),
(13,113,3),
(14,114,4),
(15,115,5),
(16,116,1),
(17,117,2),
(18,118,3),
(19,119,4),
(20,120,5),
(21,101,2),
(22,102,3),
(23,103,4),
(24,104,5),
(25,105,1),
(26,106,2),
(27,107,3),
(28,108,4),
(29,109,5),
(30,110,1);

INSERT INTO Exams
(exam_id,course_id,exam_date,exam_type)
VALUES
(1,1,'2024-11-10','Midterm'),
(2,2,'2024-11-12','Midterm'),
(3,3,'2024-11-15','Midterm'),
(4,4,'2024-11-18','Final'),
(5,5,'2024-11-20','Final');

INSERT INTO Marks VALUES
(1,101,1,85),
(2,102,2,78),
(3,103,3,90),
(4,104,4,67),
(5,105,5,88),
(6,106,1,75),
(7,107,2,82),
(8,108,3,91),
(9,109,4,69),
(10,110,5,80),
(11,111,1,84),
(12,112,2,76),
(13,113,3,89),
(14,114,4,70),
(15,115,5,92),
(16,116,1,73),
(17,117,2,85),
(18,118,3,88),
(19,119,4,74),
(20,120,5,90),
(21,101,2,79),
(22,102,3,81),
(23,103,4,86),
(24,104,5,77),
(25,105,1,83),
(26,106,2,72),
(27,107,3,87),
(28,108,4,68),
(29,109,5,91),
(30,110,1,76);

