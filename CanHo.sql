create database CanHo;
use CanHo;

-- tao bang --
create table NhanVien 
(
	MaNV varchar(5) primary key,
    TenNV varchar(50) not null,
    SoDT varchar(10),
    GioiTinh varchar(5)
);

create table CanHo
(
	MaCH varchar(5) primary key,
    TenCH varchar(50) not null
);

create table ThietBi
(
	MaTB varchar(5) primary key,
    TenTB varchar(50) not null
);

create table NV_BT
(
	MaNV varchar(5) not null,
    MaTB varchar(5) not null,
    MaCH varchar(5) not null,
    LanThu int not null,
    NgBT datetime
);

-- KHoa chinh

alter table NV_BT
add constraint PK_NV_BT primary key(MaNV, MaTB, MaCH, LanThu);

-- Khoa Ngoai
alter table NV_BT 
add constraint FK_NV_BT1 foreign key(MaNV) references NhanVien(MaNV);

alter table NV_BT 
add constraint FK_NV_BT2 foreign key(MaTB) references ThietBi(MaTB);

alter table NV_BT 
add constraint FK_NV_BT3 foreign key(MaCH) references CanHo(MaCH);


-- insert du lieu
insert into nhanvien values 
("nv01", "Nguyen Nhat Minh", "7355608", "nam"),
("nv02", "Nguyen Thi Minh", "7355608", "nu");

insert into CanHo values
("1", "khach san"),
("2", "nha nghi");

insert into ThietBi values
("1", "Dieu hoa"),
("2", "Quat");

insert into NV_BT values 
("nv01", "1", "1", 1, "2021-11-28"),
("nv01", "2", "2", 2, "2021-11-28"),
("nv02", "2", "1", 1, "2021-11-28");