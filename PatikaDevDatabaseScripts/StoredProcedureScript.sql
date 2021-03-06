USE [PatikaDevDb]
GO
/****** Object:  StoredProcedure [dbo].[spAddCourseStudent]    Script Date: 30.01.2022 23:40:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER Proc [dbo].[spAddCourseStudent]
(@CourseId int, @StudentId int)
As
Begin
	

	if((select count(*) from Courses where Id = @CourseId) = 0)
		raiserror('Course Not Found!',1,1);
	
	else if((select count(*) from Students where Id = @StudentId) = 0)
		raiserror('Student Not Found!',1,1);

	else if((select count(*) from CourseStudents cs join CourseDates cd on cs.CourseId = cd.CourseId where cd.StartDate >= (select StartDate from CourseDates where CourseId = @CourseId) and cd.EndDate <= (select StartDate from CourseDates where CourseId = @CourseId)) > 0)
		raiserror('The student is enrolled in another education on this date',1,1)

	else
		insert into CourseStudents (CourseId, StudentId) values (@CourseId,@StudentId)

End

