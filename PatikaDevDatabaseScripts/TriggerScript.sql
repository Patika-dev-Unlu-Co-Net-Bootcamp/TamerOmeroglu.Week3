USE [PatikaDevDb]
GO
/****** Object:  Trigger [dbo].[percentSuccessRate]    Script Date: 30.01.2022 23:38:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER TRIGGER [dbo].[percentSuccessRate]
ON [dbo].[StudentsCourseCompletion]
AFTER UPDATE
AS
Begin
 declare @totalWeek int, @newPercent decimal

 select @totalWeek = c.DurationWeek from Courses c join CourseStudents cs on c.Id = cs.CourseId where (select CourseStudentId from inserted) = cs.Id
 select @newPercent = ((TotalWeekAttended / @totalWeek) * 100) from inserted

 update CourseStudents set GradeRate = @newPercent

End