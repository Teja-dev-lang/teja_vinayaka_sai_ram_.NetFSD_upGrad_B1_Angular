use CompanyDataBase

CREATE TABLE Worker (

WORKER_ID INT PRIMARY KEY IDENTITY(1,1),

FIRST_NAME VARCHAR(25),

LAST_NAME VARCHAR(25),

SALARY INT,

JOINING_DATE DATETIME,

DEPARTMENT CHAR(25)

);

CREATE TABLE Bonus (

WORKER_REF_ID INT,

BONUS_AMOUNT INT,

BONUS_DATE DATETIME,

FOREIGN KEY (WORKER_REF_ID)

REFERENCES Worker(WORKER_ID)

ON DELETE CASCADE

);

CREATE TABLE Title (

WORKER_REF_ID INT,

WORKER_TITLE CHAR(25),

AFFECTED_FROM DATETIME,

FOREIGN KEY (WORKER_REF_ID)

REFERENCES Worker(WORKER_ID)

ON DELETE CASCADE

);


INSERT INTO Worker (FIRST_NAME, LAST_NAME, SALARY, JOINING_DATE, DEPARTMENT)
VALUES
('Monika','Arora',100000,'2014-02-20 09:00:00','HR'),
('Niharika','Verma',80000,'2014-06-11 09:00:00','Admin'),
('Vishal','Singhal',300000,'2014-02-20 09:00:00','HR'),
('Amitabh','Singh',500000,'2014-02-20 09:00:00','Admin'),
('Vivek','Bhati',500000,'2014-06-11 09:00:00','Admin'),
('Vipul','Diwan',200000,'2014-06-11 09:00:00','Account'),
('Satish','Kumar',75000,'2014-01-20 09:00:00','Account'),
('Geetika','Chauhan',90000,'2014-04-11 09:00:00','Admin');


INSERT INTO Bonus (WORKER_REF_ID, BONUS_AMOUNT, BONUS_DATE)
VALUES
(1,5000,'2016-02-20'),
(2,3000,'2016-06-11'),
(3,4000,'2016-02-20'),
(1,4500,'2016-02-20'),
(2,3500,'2016-06-11');


INSERT INTO Title (WORKER_REF_ID, WORKER_TITLE, AFFECTED_FROM)
VALUES
(1,'Manager','2016-02-20'),
(2,'Executive','2016-06-11'),
(8,'Executive','2016-06-11'),
(5,'Manager','2016-06-11'),
(4,'Asst. Manager','2016-06-11'),
(7,'Executive','2016-06-11'),
(6,'Lead','2016-06-11'),
(3,'Lead','2016-06-11');



--Write an SQL query to fetch “FIRST_NAME” from Worker table using the alias name as <WORKER_NAME>

SELECT FIRST_NAME AS WORKER_NAME
FROM worker;

--2. Write an SQL query to fetch “FIRST_NAME” from Worker table in upper case.

SELECT upper(FIRST_NAME) AS WORKER_NAME
FROM worker;

--3. Write an SQL query to fetch unique values of DEPARTMENT from Worker table.

SELECT DISTINCT DEPARTMENT 
FROM worker;

--4. Write an SQL query to print the first three characters of FIRST_NAME from Worker table.

SELECT SUBSTRING(FIRST_NAME,1,3) AS FIRST_THREE
FROM worker;

--5. Write an SQL query to find the position of the alphabet (‘a’) in the first name column ‘Amitabh’ from Worker table.

SELECT CHARINDEX('a', FIRST_NAME) AS position_of_a
FROM Worker
WHERE FIRST_NAME = 'Amitabh';

--6. Write an SQL query to print the FIRST_NAME from Worker table after removing white spaces from the right side.

SELECT RTRIM(FIRST_NAME) AS Name
FROM WORKER;

--7. Write an SQL query to print the DEPARTMENT from Worker table after removing white spaces from the left side.

SELECT LTRIM(DEPARTMENT) AS dept
FROM WORKER;

--8. Write an SQL query that fetches the unique values of DEPARTMENT from Worker table and prints its length.

SELECT DISTINCT DEPARTMENT ,LEN(DEPARTMENT) AS Length_Depart
FROM worker;

--9. Write an SQL query to print the FIRST_NAME from Worker table after replacing ‘a’ with ‘A’

SELECT REPLACE(FIRST_NAME,'a','A')
FROM Worker;

--10. Write an SQL query to print the FIRST_NAME and LAST_NAME from Worker table into a single column COMPLETE_NAME. A space char should separate them.

SELECT FIRST_NAME + ' ' + LAST_NAME AS FullName
FROM worker;


--11. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending.

SELECT *
FROM worker
order by FIRST_NAME;

--12. Write an SQL query to print all Worker details from the Worker table order by FIRST_NAME Ascending and DEPARTMENT Descending.

SELECT * 
FROM Worker
ORDER BY FIRST_NAME ASC, DEPARTMENT DESC;

--13. Write an SQL query to print details for Workers with the first name as “Vipul” and “Satish” from Worker table.

SELECT *
FROM worker
WHERE FIRST_NAME = 'Vipul' or FIRST_NAME = 'Satish';

--14. Write an SQL query to print details of workers excluding first names, “Vipul” and “Satish” from Worker table.

SELECT *
FROM worker
WHERE FIRST_NAME not in ('Vipul','Satish');

--15. Write an SQL query to print details of Workers with DEPARTMENT name as “Admin”.

SELECT *
FROM worker
WHERE department = 'Admin';

--16. Write an SQL query to print details of the Workers whose FIRST_NAME contains ‘a’.

SELECT *
FROM worker
WHERE FIRST_NAME LIKE '%a%';

--17. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘a’

SELECT *
FROM worker
WHERE FIRST_NAME LIKE '%a';

--18. Write an SQL query to print details of the Workers whose FIRST_NAME ends with ‘h’ and contains six alphabets

SELECT *
FROM worker
WHERE FIRST_NAME LIKE '%h' and len(FIRST_NAME) = 6;


--19. Write an SQL query to print details of the Workers whose SALARY lies between 100000 and 500000.

SELECT *
FROM worker
where SALARY BETWEEN 10000 AND 500000;

--20. Write an SQL query to print details of the Workers who have joined in Feb’2014.

SELECT *
FROM Worker
WHERE JOINING_DATE >= '2014-02-01' AND JOINING_DATE < '2014-03-01';

--21. Write an SQL query to fetch worker names with salaries >= 50000 and <= 100000

SELECT FIRST_NAME+' '+LAST_NAME AS Name
FROM Worker
WHERE SALARY >= 50000 and SALARY<= 100000;

--22. Write an SQL query to fetch the no. of workers for each department in the descending order.

SELECT DEPARTMENT ,count(*)
from Worker
group by DEPARTMENT
order by DEPARTMENT desc;



--24.Write an SQL query to show the current date and time.

select GETDATE() AS DATETIME;


--25.Write an SQL query to show the top n (say 10) records of a table.

SELECT TOP 10 *
FROM worker;