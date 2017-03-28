
create table Nugaletojai (
id int identity(1,1) primary key,
vardas varchar (100),
taskai int, data datetime)

insert into Nugaletojai(vardas, taskai, data)
values('TheLegend27', 1000000000, GETDATE())

select vardas, taskai, data from Nugaletojai
