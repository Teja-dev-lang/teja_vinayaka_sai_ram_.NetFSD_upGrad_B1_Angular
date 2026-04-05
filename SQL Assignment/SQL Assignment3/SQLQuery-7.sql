SELECT s.First_Name, s.Last_name, d.DepartmentName
FROM Students s
JOIN Departments d
ON s.DepartmentID = d.DepartmentID;

SELECT c.courseName, t.TeacherName
FROM Courses c
JOIN Teachers t
ON c.TeacherID = t.TeacherID;

SELECT s.First_Name, c.courseName
FROM Students s
JOIN Enrollments e ON s.student_id = e.student_id
JOIN Courses c ON e.course_id = c.course_id;

SELECT s.First_Name, m.marks_obtained, e.exam_type
FROM Students s
JOIN Marks m ON s.student_id = m.student_id
JOIN Exams e ON m.exam_id = e.exam_id;

SELECT c.courseName, t.TeacherName
FROM Courses c
LEFT JOIN Teachers t
ON c.TeacherID = t.TeacherID;

SELECT *
FROM Teachers
WHERE TeacherID NOT IN
(
    SELECT TeacherID
    FROM Courses
);

