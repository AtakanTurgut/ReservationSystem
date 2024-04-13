create procedure ChartRoomStatus
as
select StatusName, Count(*) as 'Count' from Rooms 
inner join Statuses
on Statuses.StatusId = Rooms.StatusId
group by StatusName

execute ChartRoomStatus