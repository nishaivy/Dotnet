use entity

select * from Students

delete from Students

create or alter procedure Student_teacher(@teacher_id int)
as 
Select * from Students where teacherId=@teacher_id

drop procedure Student_teacher
Exec Student_teacher 1
Exec student_course 1