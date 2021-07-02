create database SHopp

create table Loginn(
Logginn int identity (1,1),
adresa varchar (255),
pass varchar (255)
)
insert into Loginn values ('yahoo@gmail.com', 'abcd')

select * from Loginn

create table Registration (
Register int identity (1,1),
Emri varchar (255),
Prodhimtaria varchar (255),
Adresa varchar (255),
Kontakti int,
email varchar (255),
pass varchar (255)
)
alter table Registration add CEO varchar(255)
insert into Registration values('Nike','PaisjeSportive', 'University of Oregon', +1800-806-6453, 'nike@gmail.com', 'abcd','John Donahoe')
UPDATE Registration
SET Kontakti = 044255226
WHERE Kontakti=+1800-806-6453

select * from Registration

create table OfertaDitore(
OfertaD int identity (1,1),
Produkti varchar (255),
PhotoFileName varchar (255)
)
insert into OfertaDitore values('Atlete', 'anonymos.png')

select *from OfertaDitore

create table OfertaJavore(
OfertaJ int identity (1,1),
Produkti varchar (255),
PhotoFileName varchar (255)
)
insert into OfertaJavore values('PerFemij', 'anonymos.png')

select *from OfertaJavore

create table OfertaSezonale(
OfertaS int identity (1,1),
Produkti varchar (255),
PhotoFileName varchar (255)
)
insert into OfertaSezonale values('Sezonale', 'anonymos.png')

select *from OfertaSezonale

create table OfertaOutlet(
OfertaO int identity (1,1),
Produkti varchar (255),
PhotoFileName varchar (255)
)
insert into OfertaOutlet values('Tranerka', 'anonymos.png')

select *from OfertaOutlet

create table ContactUs(
ContactId int identity(1,1),
Emri varchar (255),
Mbiemri varchar(255),
email varchar (255),
tel int,
Message varchar(500)
)

insert into ContactUs values('Filan', 'Fisteku', 'filan@gmail.com', 044432244, 'Filan fisteku kush jeni ju')
select * from ContactUs

create table ListaDeshirave(
Ld int identity (1,1),
Produkti varchar (255)
)
insert into ListaDeshirave values ('Topa')
select * from ListaDeshirave

create table Feedback(
FeedbackId int identity (1,1),
Eksperienca varchar (255),
Kompanis varchar (255)
)
insert into Feedback values ('8/10','Mire')
update Feedback
set Kompanis = 'Impressed'
where Kompanis='Mire'

select * from Feedback

create table RrethNesh(
RrethNeshId int identity (1,1),
Lokacioni varchar (255)
)

insert into RrethNesh values ('Prishtin')

select * from RrethNesh

create table Informata(
InformataId int identity (1,1),
Sherbimet varchar (255),
SherbimetPerKonsumator varchar (255)
)

insert into Informata values ('Ofertat e Fundit','Loje Shperblyse')

select * from Informata

create table Fletushkat(
FletushkatId int identity (1,1),
Lloji varchar (255)
)
insert into Fletushkat values ('Lodrat e Plazhit')

select * from Fletushkat

create table Stafi(
StafiId int identity (1,1),
Emri varchar (255),
Mbiemri varchar (255),
Email varchar (255)
)
insert into Stafi values('Ardit', 'Gerguri', 'ag@ubt-uni.net')
select * from Stafi


create table FAQ(
FaqId int identity (1,1),
FrequentlyAskedQuestions varchar (255)
)

insert into FAQ values ('Si mund tju kontaktojm')

select * from FAQ

create table Support(
SupportId int identity (1,1),
HelpCenter varchar (255)
)
 insert into Support values ('troubleshooting')
select * from Support

create table Employee(
EmployeId int identity(1,1),
EmployeeName varchar (255),
Department varchar (255),
DateOfJoing date,
PhotoFileName varchar (255)
)
insert into Employee values ('Ebi','Atlete','2020-06-01','anonymous.png')
select * from Employee

create table Porosia(
PorosiaId int identity (1,1),
emri varchar (255),
mbiemri varchar (255),
adresa varchar (255),
produkti varchar (255)
)
insert into Porosia values ('Dita', 'Simnica', 'Prishtin','laptop')

select * from Porosia

create table Kompania(
KompaniaId int identity (1,1),
Emri varchar(255),
Produkti varchar (255),
Marka varchar (255)
)

insert into Kompania values('Ilyrian','Pantollona','Ilyrian')
select * from Kompania


