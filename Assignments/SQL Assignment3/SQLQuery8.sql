SELECT *
FROM Marks
WHERE marks_obtained >
(
    SELECT AVG(marks_obtained)
    FROM Marks
);

SELECT *
FROM Courses
WHERE credits =
(
    SELECT MAX(credits)
    FROM Courses
);

SELECT student_id
FROM Enrollments
GROUP BY student_id
HAVING COUNT(course_id) > 2;

SELECT *
FROM Teachers
WHERE DepartmentID =
(
    SELECT DepartmentID
    FROM Teachers
    WHERE TeacherName = 'John'
);

SELECT *
FROM Marks
WHERE marks_obtained =
(
    SELECT MAX(marks_obtained)
    FROM Marks
);

SELECT DepartmentID
FROM Students
GROUP BY DepartmentID
HAVING COUNT(*) =
(
    SELECT MAX(StudentCount)
    FROM
    (
        SELECT COUNT(*) AS StudentCount
        FROM Students
        GROUP BY DepartmentID
    ) AS DeptCounts
);