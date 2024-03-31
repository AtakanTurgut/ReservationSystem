create trigger increase_stock	-- alter trigger increase_stock
on ProductMovements
after insert
as
declare @amount decimal
declare @id int
declare @type nvarchar(6)
select @type = MovementType from inserted
if(@type = 'Giriþ')
begin
select @amount = Amount, @id = ProductId from inserted
update Products set Total += @amount where ProductId = @id
end
if(@type = 'Çýkýþ')
begin
select @amount = Amount, @id = ProductId from inserted
update Products set Total -= @amount where ProductId = @id
end