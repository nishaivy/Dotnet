use Entity_FrameWork

select * from Students

delete from Students

create or alter procedure Student_Club(@club_id int)
as 
Select * from Students where ClubId=@club_id

drop procedure Student_Club
Exec student_club 1
Exec student_course 2