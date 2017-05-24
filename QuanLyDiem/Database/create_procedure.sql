/* 
	INSERT DIEM
*/
CREATE proc insert_diem
	@MaHocSinh bigint,
	@MaMon bigint,
	@DiemMieng int,
	@DiemGiuaKy int,
	@DiemHocKy int,
	@HocKy nchar(10),
	@NamHoc datetime,
	@GhiChu nvarchar(max)
as
	begin try
		if exists (select MaMon from DIEM where MaMon=@MaMon and MaHocSinh=@MaHocSinh and HocKy=@HocKy)
			begin
				print 'updating Diem';
				update DIEM set DiemMieng=@DiemMieng,DiemGiuaKy=@DiemGiuaKy,DiemHocKy=@DiemHocKy,HocKy=@HocKy,NamHoc=@NamHoc,GhiChu=@GhiChu where MaHocSinh=@MaHocSinh and HocKy=@HocKy;
			end
		else
			begin
				print 'inserting Diem';
				insert into DIEM(MaHocSinh,MaMon,DiemMieng,DiemGiuaKy,DiemHocKy,HocKy,NamHoc,GhiChu) 
				values(@MaHocSinh,@MaMon,@DiemMieng,@DiemGiuaKy,@DiemHocKy,@HocKy,@NamHoc,@GhiChu);
			end
	end try
	begin catch
		print '' + error_message();
	end catch
return

/*
	Tim Hoc Sinh Theo Lop
*/
go
CREATE proc getAllHocSinhTheoLop
@malop bigInt
as
begin
	IF @malop IS NOT NULL
		select MaHocSinh, TenHocSinh from HOC_SINH where MaLop=@malop
	ElSE
		return
end
/*
	Tim Khoi
*/
go
Create Proc getAllKhoi 
As
begin
	select * from KHOI
end
/*
	Tim Lop Theo Khoi
*/
go
CREATE proc getAllLopTheoKhoi
@makhoi bigInt
as
begin
	IF @makhoi IS NOT NULL
		select MaLop,TenLop from LOP where Khoi=@makhoi;
	ELSE
		return
end
/*
	Tim Hoc Sinh Theo Lop
*/
go
CREATE proc select_diem_from_mahocsinh_mamonhoc
	@MaHocSinh bigint,
	@MaMon bigint,
	@HocKy nchar(10),
	@NamHoc datetime
as
begin
	if @MaHocSinh is not null and @MaMon is not null
		begin
			select * from DIEM where MaHocSinh=@MaHocSinh and MaMon=@MaMon and HocKy=@HocKy and YEAR(NamHoc)=YEAR(@NamHoc);
		end
	else 
		return;
end
/* 
	Bang Diem Hoc Sinh
*/
go
CREATE PROCEDURE sDiemTheoMaHSvaHocKy
	@MaHocSinh bigint,
	@HocKy nchar(10),
	@NamHoc datetime
AS
begin
	select TenMon,DiemMieng,DiemGiuaKy,DiemHocKy,dbo.TrungBinhMon(DiemMieng,DiemGiuaKy, DiemHocKy) as TBMon from DIEM inner join MON_HOC on DIEM.MaMon=MON_HOC.MaMon where MaHocSinh=@MaHocSinh and HocKy=@HocKy and YEAR(NamHoc)=YEAR(@NamHoc);
	RETURN 0
end
/*
	GET GIAO VIEN
*/
go
CREATE PROCEDURE GetGiaoVien
AS
begin
	select * from GIAO_VIEN inner join DAY on GIAO_VIEN.MaGiaoVien = DAY.MaGV inner join LOP on LOP.MaLop = DAY.MaLop inner join MON_HOC on DAY.MaMon = MON_HOC.MaMon;
RETURN 0;
end
/*
	GET HOC SINH
*/
go
CREATE PROCEDURE GetHocSinh
AS
begin
	select * from HOC_SINH inner join LOP on HOC_SINH.MaLop = LOP.MaLop;
RETURN 0;
end
/*
	Cap Nhat Giao Vien
*/
go
CREATE PROCEDURE SuaGiaoVien
	@ten nvarchar(150),
	@gioitinh int,
	@ngaysinh date,
	@diachi nvarchar(120),
	@sodienthoai nvarchar(11),
	@lop bigint,
	@mon bigint,
	@ma bigint

AS
Begin
	update GIAO_VIEN
	set TenGiaoVien=@ten,GioiTinh=@gioitinh, NgaySinh = @ngaysinh, DiaChi = @diachi, SoDienThoai = @sodienthoai
	where MaGiaoVien = @ma

	update DAY
	set MaLop = @lop, MaMon = @mon
	where MaGV = @ma
	
end

/*
	Cap Nhat Hoc Sinh
*/
go
CREATE PROCEDURE SuaHocSinh
	@tenhocsinh nvarchar(150),
	@gioitinh int,
	@malop bigint,
	@ngaysinh date,
	@diachi nvarchar(120),
	@mahocsinh bigint

AS
begin
	update HOC_SINH
	set TenHocSinh=@tenhocsinh,GioiTinh=@gioitinh,MaLop=@malop,NgaySinh=@ngaysinh,DiaChi=@diachi
	where MaHocSinh = @mahocsinh
end

/*
	Tim Kiem Co Ban
*/

/*Hoc Sinh*/
Go
CREATE PROCEDURE TimHocSinhCoBan
	@mahocsinh int
AS
begin
	SELECT MaHocSinh,TenHocSinh, NgaySinh,LOP.TenLop, GioiTinh, HOC_SINH.MaLop, DiaChi, Khoi, GhiChu from HOC_SINH,LOP where HOC_SINH.MaLop=LOP.MaLop and MaHocSinh = @mahocsinh;
end
/*Giao Vien*/
go
CREATE PROCEDURE TimGiaoVienCoBan
	@magiaovien int
AS
begin
	SELECT  MaGiaoVien,TenGiaoVien,NgaySinh,GioiTinh,LOP.MaLop,TenMon,TenLop,Khoi,SoDienThoai,DiaChi from DAY,GIAO_VIEN,LOP,MON_HOC where LOP.MaLop = DAY.MaLop and MaGiaoVien = MaGV and MON_HOC.MaMon = DAY.MaMon and MaGiaoVien=@magiaovien;
end

/* Them Giao Vien */
Go
CREATE PROCEDURE ThemGiaoVien
	@ten nvarchar(150),
	@gioitinh int,
	@ngaysinh date,
	@diachi nvarchar(120),
	@sodienthoai nvarchar(11),
	@lop bigint,
	@mon bigint

AS
Begin
	Insert into GIAO_VIEN(TenGiaoVien,GioiTinh,SoDienThoai,NgaySinh,DiaChi) 
	values(@ten,@gioitinh,@sodienthoai,@ngaysinh,@diachi);

	Insert into DAY(MaGV,MaLop,MaMon,GhiChu) 
	values((SELECT TOP 1 MaGiaoVien FROM GIAO_VIEN ORDER BY MaGiaoVien DESC),@lop,@mon,'')
	
end

/* Them Hoc Sinh */
go
CREATE PROCEDURE ThemHocSinh
	@tenhocsinh nvarchar(150),
	@gioitinh int,
	@malop bigint,
	@ngaysinh date,
	@diachi nvarchar(120)

AS
begin
	Insert into HOC_SINH(TenHocSinh,GioiTinh,MaLop,NgaySinh,DiaChi) values(@tenhocsinh,@gioitinh,@malop,@ngaysinh,@diachi)
end

/* 
	Xoa Giao Vien
*/
Go
CREATE PROCEDURE XoaGiaoVien
	@ma bigint

AS
begin
	Delete from DAY where MaGV = @ma
	Delete from GIAO_VIEN where MaGiaoVien = @ma
	
end

/*
	Xoa Hoc Sinh
*/
go
CREATE PROCEDURE XoaHocSinh
	@mahocsinh bigint

AS
Begin
	Delete from HOC_SINH where MaHocSinh = @mahocsinh
end

/*
	Them Mon Hoc
*/
Go
CREATE PROCEDURE insertMonHoc
	@TenMon nvarchar(50)
AS
Begin
	insert into MON_HOC(TenMon) values(@TenMon);
End

/*
	Update Mon Hoc
*/

Go
CREATE PROCEDURE updateMonHoc
	@MaMon int,
	@TenMon nvarchar(50)
AS
Begin
	update MON_HOC set TenMon=@TenMon where MaMon=@MaMon;
RETURN 0
end

/*
	Xoa Mon Hoc
*/
Go
CREATE PROCEDURE deleteMonHoc
	@MaMon int
AS
begin
	delete MON_HOC where MaMon=@MaMon;
RETURN 0
end
