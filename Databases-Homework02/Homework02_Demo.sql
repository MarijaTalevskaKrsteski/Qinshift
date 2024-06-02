CREATE DATABASE SEDCHome;

USE SEDCHome;

CREATE TABLE GradeDetails(
ID int IDENTITY(0, 1) NOT NULL, 
GradeID int NOT NULL, 
AchievementTypeID int NOT NULL, 
AchievementPoints int NOT NULL, 
AchievementMaxPoints int NOT NULL, 
AchievementDate date NOT NULL
)

CREATE TABLE Grade(
ID int IDENTITY(0, 1) NOT NULL, 
StudentID int NOT NULL, 
CourseID int NOT NULL, 
TeacherID int NOT NULL, 
Grade int NOT NULL, 
Comment nvarchar(MAX) NOT NULL, 
CreatedDate date NOT NULL
)

CREATE TABLE AchievementType(
ID int IDENTITY(0, 1) NOT NULL,
[Name] nvarchar(100) NOT NULL, 
[Description] nvarchar(MAX) NULL, 
ParticipationRate int NOT NULL
)

CREATE TABLE Course(
ID int IDENTITY(0, 1) NOT NULL, 
[Name] nvarchar(100) NOT NULL, 
Credit int NOT NULL, 
AcademicYear int NOT NULL, 
Semester int NOT NULL
)

CREATE TABLE Student(
ID int IDENTITY(0, 1) NOT NULL, 
FirstName nvarchar(100) NOT NULL, 
LastName nvarchar(100) NOT NULL, 
DateOfBirth date NOT NULL, 
EnrolledDate date NOT NULL, 
Gender nchar(1) NOT NULL, 
NationalIDNumber int NOT NULL, 
StudentCardNumber nvarchar(100) NOT NULL
)

CREATE TABLE Teacher(
ID int IDENTITY(0, 1) NOT NULL,
FirstName nvarchar(100) NOT NULL,
LastName nvarchar(100) NOT NULL,
DateOfBirth date NOT NULL,
AcademicRank nvarchar(100) NOT NULL,
HireDate date NOT NULL
)

ALTER TABLE GradeDetails
ADD PRIMARY KEY (ID)

ALTER TABLE Grade
ADD PRIMARY KEY (ID)

ALTER TABLE AchievementType
ADD PRIMARY KEY (ID)

ALTER TABLE Course
ADD PRIMARY KEY (ID)

ALTER TABLE Student
ADD PRIMARY KEY (ID)

ALTER TABLE Teacher
ADD PRIMARY KEY (ID)

--Find all Students with FirstName = Antonio
SELECT * FROM Student
WHERE FirstName = 'Antonio'

--Find all Students with DateOfBirth greater than ‘01.01.1999’
SELECT * FROM Student
WHERE DateOfBirth > '1999.01.01'

--Find all Students with LastName starting With ‘J’ enrolled in January/1998
SELECT * FROM Student
WHERE LastName like 'J%' AND EnrolledDate >= '1998.01.01' AND EnrolledDate <= '1998.01.31'

--List all Students ordered by FirstName
SELECT * FROM Student
ORDER BY FirstName ASC

--List all Teacher Last Names and Student Last Names in single result set. Remove duplicates
SELECT LastName FROM Teacher
UNION
SELECT LastName FROM Student

--Create Foreign key constraints from diagram or with script
ALTER TABLE Grade
ADD CONSTRAINT FK_Grade_Student
FOREIGN KEY (StudentID)
REFERENCES Student (ID)

ALTER TABLE Grade
ADD CONSTRAINT FK_Grade_Course
FOREIGN KEY (CourseID)
REFERENCES Course (ID)

ALTER TABLE Grade
ADD CONSTRAINT FK_Grade_Teacher
FOREIGN KEY (TeacherID)
REFERENCES Teacher (ID)

ALTER TABLE GradeDetails
ADD CONSTRAINT FK_GradeDetails_Grade
FOREIGN KEY (GradeID)
REFERENCES Grade (ID)

ALTER TABLE GradeDetails
ADD CONSTRAINT FK_GradeDetails_AchievementType
FOREIGN KEY (AchievementTypeID)
REFERENCES AchievementType (ID)

--List all possible combinations of Courses names and AchievementType names that can be passed by student 
SELECT Course.[Name], AchievementType.[Name]
FROM Course
CROSS JOIN AchievementType

--List all Teachers without exam Grade
SELECT * FROM Teacher
LEFT OUTER JOIN Grade
ON Teacher.ID = TeacherID
WHERE Grade.ID IS NULL