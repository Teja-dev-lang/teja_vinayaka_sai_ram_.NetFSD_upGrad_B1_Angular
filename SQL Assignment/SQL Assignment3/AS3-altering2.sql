--altering 2
--1
ALTER TABLE Students
ADD  PhoneNumber varchar(10) check(len(PhoneNumber)=10)

--2
ALTER TABLE Teachers
ADD salary varchar(200)

--3
ALTER TABLE Teachers
ALTER COLUMN salary INT

--4
ALTER TABLE Teachers
ADD CONSTRAINT salary CHECK(salary > 20000)

--5
alter table Students
drop CK__Students__PhoneN__6383C8BA 

alter table Students
drop column PhoneNumber

--6
EXEC sp_rename 'Students.AdmissionDate', 'Admission_Date', 'COLUMN';
select * from Students
