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
CREATE proc getAllHocSinhTheoLop
@malop bigInt
as
	IF @malop IS NOT NULL
		select MaHocSinh, TenHocSinh from HOC_SINH where MaLop=@malop
	ElSE
		return
/*
	Tim Khoi
*/
Create Proc getAllKhoi 
As
select * from KHOI

/*
	Tim Lop Theo Khoi
*/

CREATE proc getAllLopTheoKhoi
@makhoi bigInt
as
	IF @makhoi IS NOT NULL
		select MaLop,TenLop from LOP where Khoi=@makhoi;
	ELSE
		return

/*
	Tim Hoc Sinh Theo Lop
*/
CREATE proc select_diem_from_mahocsinh_mamonhoc
	@MaHocSinh bigint,
	@MaMon bigint,
	@HocKy nchar(10)
as
	if @MaHocSinh is not null and @MaMon is not null
		begin
			select * from DIEM where MaHocSinh=@MaHocSinh and MaMon=@MaMon and HocKy=@HocKy;
		end
	else 
		return;