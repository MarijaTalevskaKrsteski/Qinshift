USE SEDCHome
GO

--Calculate the count of all grades per Teacher in the system
SELECT TeacherID, FirstName, LastName, COUNT(Grade) AS TotalGrades
FROM Teacher T
LEFT JOIN Grade G --left join because we need to check all teachers even if it's null
ON T.ID = G.TeacherID
GROUP BY TeacherID, FirstName, LastName
GO

--Calculate the count of all grades per Teacher in the system for first 100 Students (ID < 100)
SELECT TeacherID, FirstName, LastName, COUNT(Grade) AS TotalGrades
FROM Teacher T
LEFT JOIN Grade G
ON T.ID = G.TeacherID
WHERE StudentID < 100
GROUP BY TeacherID, FirstName, LastName
GO

--Find the Maximal Grade, and the Average Grade per Student on all grades in the system
SELECT StudentID, FirstName, LastName, MAX(Grade) AS MaximalGrade, AVG(Grade) AS AverageGrade
FROM Student S
INNER JOIN Grade G 
ON S.ID = StudentID
GROUP BY StudentID, FirstName, LastName
GO

--Calculate the count of all grades per Teacher in the system and filter only grade count greater then 200
SELECT TeacherID, FirstName, LastName, COUNT(Grade) AS TotalGrades
FROM Teacher T
LEFT JOIN Grade G
ON T.ID = G.TeacherID
GROUP BY TeacherID, FirstName, LastName
HAVING COUNT(Grade) > 200
GO

--Find the Grade Count, Maximal Grade, and the Average Grade per Student on all grades in the system. 
	--Filter only records where Maximal Grade is equal to Average Grade
SELECT StudentID, FirstName, LastName, MAX(Grade) AS MaximalGrade, AVG(Grade) AS AverageGrade
FROM Student S
INNER JOIN Grade G 
ON S.ID = StudentID
GROUP BY StudentID, FirstName, LastName
HAVING MAX(Grade) = AVG(Grade)
GO

--^List Student First Name and Last Name next to the other details from previous query

--Create new view (vv_StudentGrades) that will List all StudentIds and count of Grades per student
CREATE VIEW vv_StudentGrades
AS
SELECT StudentID, COUNT(Grade) AS TotalGrades
FROM Grade G
GROUP BY StudentID
GO

--Change the view to show Student First and Last Names instead of StudentID
ALTER VIEW vv_StudentGrades
AS
SELECT StudentID, FirstName, LastName, COUNT(Grade) AS TotalGrades
FROM Grade G
INNER JOIN Student S
ON StudentID = S.ID
GROUP BY StudentID, FirstName, LastName
GO

--List all rows from view ordered by biggest Grade Count
SELECT *
FROM vv_StudentGrades
ORDER BY TotalGrades DESC