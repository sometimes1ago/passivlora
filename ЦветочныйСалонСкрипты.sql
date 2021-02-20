create database ���������_�����
go

use ���������_�����
go

create table ����_�������
(
ID_���� int primary key identity,
������������ varchar(25) unique  not null
)
go


insert into ����_�������(������������)
values	('������'),
		('�����'),
		('������'),
		('��������� ��������'),
		('������� ��������'),
		('���� �� ����������')
go

create table ������
(
ID_������ int primary key identity,
������������ varchar(50) unique not null,
���_������ int foreign key references ����_�������(ID_����) not null,
�����_�� int not null,
������_�� int not null,
������_�� int not null,
�������� varchar(255) not null,
��������� money not null
)
go

insert into ������(������������, ���_������, �����_��, ������_��, ������_��, ���������)
values	('�������� ����������','1','30','30','65','1670'),
		('����������','1','25','30','70','1940'),
		('������ �������������','1','40','40','76','2100'),
		('����� Love','1','25','25','25','1000'),
		('����� ���������','1','45','20','30','2000'),
		('�����','2','14','7','68','100'),
		('�������','2','15','5','39','60'),
		('����','2','9','7','40','50'),
		('�������','2','11','7','23','90'),
		('���������','2','9','9','32','80'),
		('���������','3','8','8','12','100'),
		('�������','3','12','12','14','120'),
		('�������','3','16','13','15','180'),
		('�������','3','20','20','18','250'),
		('��������','3','25','25','27','350'),
		('����� �����������','4','10','10','20','560'),
		('�������','4','5','10','20','720'),
		('��������','4','7','12','14','480'),
		('�������','4','8','8','17','670'),
		('��������','4','10','7','28','510'),
		('������������','5','6','5','20','700'),
		('�����','5','5','4','15','1000'),
		('��������','5','3','3','10','1200'),
		('���������','5','8','9','18','970'),
		('��������','5','10','5','21','690'),
		('���������','6','20','20','60','250'),
		('�������','6','8','3','16','320'),
		('������� ������','6','300','20','20','120'),
		('������� �����','6','50','30','25','500'),
		('�����������','6','8','3','40','200')
go

create procedure GetOrdersByUsername
@username varchar(25)
as
	begin
		select ������.ID_������ as �����_������, ������.������������ as �����, ����_�������.������������ as ���_������, 
		�������.�������, �������.���, �������.�������, ������.�����_������, ������.�����_��������, ������.����_������, ������.�����_��������, ������.������_������, ������.���_������
		from ������_�������� inner join ������ on ������_��������.����� = ������.ID_������
							 inner join ������ on ������.����� = ������.ID_������
							 inner join ����_������� on ������.���_������ = ����_�������.ID_����
							 inner join ������� on ������_��������.������ = �������.ID_�������
							 inner join ������������ on �������.������_���_����� = ������������.ID_������������
		where ������������.����� = @username
	end
go

create view GetAllUsersOrders
(�����_������, �����, ���_������, �������_�������, ���_�������, �������_�������, �����_������, �����_��������, ����_������, ������_������, ���_������)
as
		select ������.ID_������, ������.������������, ����_�������.������������, 
		�������.�������, �������.���, �������.�������, ������.�����_������, ������.�����_��������, ������.����_������, ������.������_������, ������.���_������
		from ������_�������� inner join ������ on ������_��������.����� = ������.ID_������
							 inner join ������ on ������.����� = ������.ID_������
							 inner join ����_������� on ������.���_������ = ����_�������.ID_����
							 inner join ������� on ������_��������.������ = �������.ID_�������
							 inner join ������������ on �������.������_���_����� = ������������.ID_������������
go

create view GetAllProds
(�����_������, ������������, ���_������, �����_��, ������_��, ������_��, ���������)
as
	select ������.ID_������, ������.������������, ����_�������.������������, ������.�����_��, ������.������_��, ������.������_��, ������.���������
	from ������ inner join ����_������� on ������.���_������ = ����_�������.ID_����
go

create view GetAllEmployees
(�������, ���, ��������, �������, ����, �����, ������, ���������_����)
as
	select ����������.�������, ����������.���, ����������.��������, ����������.�������, ����_�������������.������������, ������������.�����, ������������.������, ������������.����
	from ���������� inner join ������������ on ����������.������_���_����� = ������������.ID_������������
					inner join ����_������������� on ����_�������������.ID_���� = ������������.����
go

create view GetAllShipments
(�����_��������, ���������, �����, ����������, ����_��������)
as
select ��������.ID_��������, ����������.��������_��������, ������.������������, ������_�_���������.����������, ��������.����_��������
from ������_�_��������� inner join �������� on ������_�_���������.�������� = ��������.ID_��������
						inner join ���������� on ��������.��������� = ����������.ID_����������
						inner join ������ on ������_�_���������.����� = ������.ID_������
go

create trigger ValidShipmentDateChecker
on ��������
for insert
as
	declare @id int = (select ID_�������� from inserted)
	declare @date date = (select ����_�������� from inserted)
	begin
		if (@date > GETDATE())
			begin
				rollback transaction
				raiserror('���� �������� �� ����� ���� ������ �����������!',0,1)
			end
	end
go

create view GetAllClients
(�����_�������, �������, ���, �������, �����, ������, ���������_����)
as
	select �������.ID_�������, �������.�������, �������.���, �������.�������, ������������.�����, ������������.������, ������������.����
	from ������� inner join ������������ on �������.������_���_����� = ������������.ID_������������
go

select * from GetAllClients where ����� = '244'

create trigger OrderNumberChecker
on ������
for update
as
	declare @id int = (select ID_������ from inserted)
	declare @status varchar(10) = (select ������_������ from inserted)
	begin
		if exists (select ID_������ from ������ where ID_������ = @id)
			begin
				update ������
				set ������_������ = @status
				where ID_������ = @id
			end
		else 
			begin
				rollback transaction
				raiserror('������� ������ �� ����������!',0,1)
			end
	end
go


create table �����
(
ID_������ int primary key identity,
��������������� int not null
)
go

insert into �����(���������������)
values	('670')
go

create table ������_��_������
(
ID_������ int primary key identity,
����� int foreign key references �����(ID_������) not null,
����� int foreign key references ������(ID_������) not null,
���������� int not null
)
go

insert into ������_��_������(�����, �����, ����������)
values	('1','1','5'),
		('1','2','6'),
		('1','3','7'),
		('1','4','12'),
		('1','5','18'),
		('1','6','22'),
		('1','7','5'),
		('1','8','6'),
		('1','9','16'),
		('1','10','34'),
		('1','11','2'),
		('1','12','12'),
		('1','13','21'),
		('1','14','7'),
		('1','15','5'),
		('1','16','8'),
		('1','17','32'),
		('1','18','12'),
		('1','19','56'),
		('1','20','44'),
		('1','21','42'),
		('1','22','11'),
		('1','23','24'),
		('1','24','32'),
		('1','25','12'),
		('1','26','35'),
		('1','27','43'),
		('1','28','22'),
		('1','29','11'),
		('1','30','20')
go

create table �������������_�����������
(
ID_������������� int primary key identity, 
������� varchar(25) not null,
��� varchar(25) not null,
�������� varchar(25) not null,
������� varchar(20) not null,
)
go

insert into �������������_�����������(�������, ���, ��������, �������)
values	('��������','�����','��������','+7 950 900 81 69'),
		('������','�������','��������','+7 930 560 86 27'),
		('���������','�����','��������','+7 952 400 40 18'),
		('�������','������','���������','+7 492 590 21 43'),
		('�������','������','���������','+7 560 900 90 90')
go

create table ����������
(
ID_���������� int primary key identity,
��������_�������� varchar(50) unique not null,
�����_�������� varchar(255) not null,
����������_���� int foreign key references �������������_�����������(ID_�������������) not null
)
go

insert into ���������� (��������_��������, �����_��������, ����������_����)
values	('Florist.ru','����, �������-158�','1'),
		('��������','����, ����������-98�, ��� �14','2'),
		('�������� �������','����, ������-213','3'),
		('��������� ��������','�����������, ����������-52�','4'),
		('SeedsGrow','�����������, ������-�����-74','5')
go

create table ��������
(
ID_�������� int primary key identity,
��������� int foreign key references ����������(ID_����������) not null,
����_�������� date not null
)
go

insert into ��������(���������, ����_��������)
values	('1','2021-02-01'),
		('2','2021-02-03'),
		('1','2021-02-05'),
		('1','2021-02-06'),
		('2','2021-02-06'),
		('3','2021-02-06'),
		('3','2021-02-10'),
		('4','2021-02-10'),
		('4','2021-02-11'),
		('3','2021-02-15'),
		('3','2021-02-17'),
		('5','2021-02-15'),
		('5','2021-02-17'),
		('5','2021-02-19'),
		('1','2021-02-19'),
		('3','2021-02-20')
go

create table ������_�_���������
(
ID_������ int primary key identity,
�������� int foreign key references ��������(ID_��������) not null,
����� int foreign key references ������(ID_������) not null,
���������� int not null
)
go

insert into ������_�_���������(��������, �����, ����������)
values	('1','1','5'),
		('1','2','4'),
		('1','3','2'),
		('1','4','6'),
		('2','5','8'),
		('2','6','9'),
		('2','7','11'),
		('3','8','12'),
		('3','9','5'),
		('3','10','6'),
		('3','11','9'),
		('3','12','7'),
		('4','13','5'),
		('4','14','6'),
		('5','15','64'),
		('6','15','8'),
		('7','16','7'),
		('7','17','11'),
		('7','18','16'),
		('8','19','19'),
		('8','20','24'),
		('8','21','54'),
		('8','22','32'),
		('9','23','16'),
		('10','24','24'),
		('10','24','35'),
		('11','12','56'),
		('11','12','35'),
		('11','15','23'),
		('11','16','4'),
		('11','15','2'),
		('12','22','5'),
		('12','29','9'),
		('12','30','4'),
		('13','21','65'),
		('14','23','3'),
		('15','12','25'),
		('15','14','36')
go

create table ����_�������������
(
ID_���� int primary key identity,
������������ varchar(25) unique not null 
)
go

insert into ����_�������������
values	('������������'),
		('������'),
		('�������������')
go

create table ������������
(
ID_������������ int primary key identity,
����� varchar(25) unique not null,
������ varchar(25) not null,
���� int foreign key references ����_�������������(ID_����) not null
)
go

insert into ������������(�����, ������, ����)
values	('user','user','1'),
		('cash','cash','2'),
		('admin','admin','3')
go

insert into ������������(�����, ������, ����)
values	('cash1','cash1','2'),
		('admin1','admin1','3')

go

create table ����������
(
ID_���������� int primary key identity,
������� varchar(25) not null, 
��� varchar(25) not null, 
�������� varchar(25) not null, 
������� varchar(25) not null,
������_���_����� int foreign key references ������������(ID_������������) not null
)
go

insert into ����������(�������, ���, ��������, �������, ������_���_�����)
values	
		('���������','���������','������������','+7 923 450 90 62','2'),
		('���������','�������','��������','+7 950 550 41 29','4'),
		('������','���������','��������','+7 983 601 90 50','3'),
		('�������','�������','���������','+7 923 887 54 74','5')
go		
DBCC CHECKIDENT (����������, RESEED,0)
go
create table �������
(
ID_������� int primary key identity,
������� varchar(25) not null,
��� varchar(25) not null,
������� varchar(25) not null,
������_���_����� int foreign key references ������������(ID_������������) not null
)
go

insert into �������(�������, ���, �������, ������_���_�����)
values	('����','�����','+7 973 187 71 92','1')
go

create table ������
(
ID_������ int primary key identity,
����� int foreign key references ������(ID_������) not null,
���������� int not null,
������_�������� varchar(30) not null,
������_������ varchar(30) not null,
�����_�������� varchar(150) not null,
����_������ date not null,
�����_������ money not null
)
go

create table ������_��������
(
ID_������ int primary key identity,
����� int foreign key references ������(ID_������) not null,
������ int foreign key references �������(ID_�������) not null
)
go