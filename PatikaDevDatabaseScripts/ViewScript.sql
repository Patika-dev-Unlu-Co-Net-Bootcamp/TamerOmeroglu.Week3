USE [PatikaDevDb]
GO
CREATE VIEW [dbo].[StudentsListGroupByCourse]
AS
SELECT c.Name AS 'Course', s.Name AS 'StudentName', s.LastName AS 'StudentLastName'
FROM     CourseStudents cs JOIN
                  Courses c ON cs.CourseId = c.Id JOIN
                  Students s ON cs.StudentId = s.Id
GROUP BY c.Name, s.Name, s.LastName
ORDER BY c.Name, s.Name, s.LastName offset 0 rows



