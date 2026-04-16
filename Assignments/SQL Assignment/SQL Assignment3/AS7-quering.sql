SELECT *
FROM Courses
WHERE TeacherID <> 3;

SELECT exam_id, AVG(marks_obtained) AS AverageMarks
FROM Marks
GROUP BY exam_id;

SELECT course_id, COUNT(student_id) AS TotalStudents
FROM Enrollments
GROUP BY course_id;

SELECT exam_id, MAX(marks_obtained) AS HighestMarks
FROM Marks
GROUP BY exam_id;

SELECT e.course_id, MIN(m.marks_obtained) AS MinMarks
FROM Marks m
JOIN Exams e ON m.exam_id = e.exam_id
GROUP BY e.course_id;

SELECT DepartmentID, COUNT(*) AS StudentCount
FROM Students
GROUP BY DepartmentID
HAVING COUNT(*) > 5;


