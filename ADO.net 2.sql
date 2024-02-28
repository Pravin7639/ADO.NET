use B22ADONETDB
go
select * from Trainer
go
create table Student 
(
RollNumber int primary key identity,
Name varchar(50),
Gender varchar(20),
TrainerId int foreign key references Trainer(Id)
)
go

insert into Student values ('Sachin','Male',1),('Pravin','Male',2),
('Aarti','Female',1),('Kiran','Female',2)
go

select  Id, Name, City, Experience from Trainer;select RollNumber, Name, Gender, TrainerId from Student



