---altering constriants

--1
ALTER TABLE Departments
ADD CONSTRAINT UQ_Departments_DepartmentName UNIQUE (DepartmentName);

--2
ALTER TABLE Students
ADD CONSTRAINT CK_Gender CHECK(GENDER IN ('M','F'));

--3
ALTER TABLE Courses
ADD CONSTRAINT CK_Credits_btw CHECK(credits between 1 and 5)

--4
ALTER TABLE marks
ADD CONSTRAINT CK_MARKS_btw CHECK(marks_obtained BETWEEN 0 AND 100)

--5
ALTER TABLE Teachers
ADD CONSTRAINT UQ_TEACHER_EMAIL UNIQUE (Email)

--6
ALTER TABLE Enrollments
ADD CONSTRAINT DF_ENROLL DEFAULT getdate()  for enrollmentDate


