go
create database nhanvien
go
use nhanvien
go
create table ttnhanvien(
idnv varchar(200) primary key,
tennv nvarchar(200),
luong money
)
go 
insert into ttnhanvien values 
('1',N'Admin Công Thắng', 50000000),
('2',N'Ql Hoàng Huy',20000000)
go
select * from ttnhanvien