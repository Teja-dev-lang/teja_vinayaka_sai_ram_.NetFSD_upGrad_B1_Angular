CREATE DATABASE Pratice_db
use Pratice_db

ALTER DATABASE Pratice_db
MODIFY NAME = school_manage;

CREATE TABLE Departments(
DepartmentID int primary key,
DepartmentName varchar(50) not null,
Location varchar(50)
)

CREATE TABLE Teachers(
TeacherID int primary key,
TeacherName varchar(30),
Email varchar(20),
DepartmentID INT,
foreign key (DepartmentID) references Departments(DepartmentID),
Hiredate date
)

CREATE TABLE Students(
student_id int primary key,
First_Name varchar(30),
Last_name varchar(30),
DateOfBirth date,
Gender varchar(10),
DepartmentID INT,
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
AdmissionDate date
)

CREATE table Courses (
course_id int primary key,
courseName varchar(30),
credits int,
DepartmentID int,
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID),
TeacherID int 
FOREIGN KEY (TeacherID) REFERENCES Teachers(TeacherID)
)

CREATE table Enrollments(
enrollment_id int primary key,
student_id int,
FOREIGN KEY (student_id) REFERENCES Students(student_id),
course_id int,
FOREIGN KEY (course_id) REFERENCES Courses(course_id),
enrollmentDate date
)

CREATE table Exams(
exam_id int primary key,
course_id int,
FOREIGN KEY (course_id) REFERENCES Courses(course_id),
exam_date date,
exam_type varchar(20),
) 

CREATE table Marks(
mark_id int primary key,
student_id int,
FOREIGN KEY (student_id) REFERENCES Students(student_id),
exam_id int,
FOREIGN KEY (exam_id) REFERENCES Exams(exam_id),
marks_obtained int
)
