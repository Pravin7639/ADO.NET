create database B22ADONETDB
go
use  B22ADONETDB
go
create table Trainer
(
Id int primary key identity,
Name varchar(50),
City varchar(50),
Experience int 
)
go

insert into Trainer values ('Vikul','Pune',14),('Usha','Pune',3)
go
insert into Trainer values ('Atul' ,'Pune', 5)

select * from Trainer

