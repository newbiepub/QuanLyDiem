/*
	Trigger Xep Loai Diem
*/
CREATE TRIGGER XepLoaiDiem
    ON [dbo].[DIEM]
    FOR INSERT, UPDATE
    AS
    BEGIN TRAN
	declare @MaHocSinh int;
	declare @DiemMieng int;
	declare @DiemGiuaKy int;
	declare @DiemHocKy int;
	declare @HocKy nchar(10);
	declare @DiemKy1 float;
	declare @DiemKy2 float;
	declare @tongSoMonKy1 int;
	declare @tongSoMonKy2 int;
	declare @XepLoai nvarchar(20);
	set @DiemKy1 = 0;
	set @DiemKy2 = 0;
	set @tongSoMonKy1 = 0;
	set @tongSoMonKy2 = 0;
	select @MaHocSinh=MaHocSinh from inserted;
	if @MaHocSinh is null
		select @MaHocSinh=MaHocSinh from deleted;
	declare @diem_cursor cursor;
	set @diem_cursor = cursor for select DiemMieng,DiemGiuaKy,DiemHocKy,HocKy from DIEM where MaHocSinh=@MaHocSinh;
	begin try
		open @diem_cursor;
		fetch next from @diem_cursor into @DiemMieng,@DiemGiuaKy,@DiemHocKy,@HocKy;
		while @@FETCH_STATUS = 0
		begin 
			print 'Hoc Ky: ' + @HocKy;
			PRINT 'Diem Mieng: ' + CAST(@DiemMieng as nvarchar) + '\ Diem Giua Ky: ' + cast(@DiemGiuaKy as nvarchar) + '\ Diem Hoc Ky: ' + cast(@DiemHocKy as nvarchar);
			if @HocKy = 'hk1'
				begin 
					set @DiemKy1 = @DiemKy1 + (cast((@DiemMieng + @DiemGiuaKy * 2 + @DiemHocKy * 3) as float) / 6);
					set @tongSoMonKy1 = @tongSoMonKy1 + 1;
				end
			else if @HocKy = 'hk2'
				begin
					set @DiemKy2 = @DiemKy2 + (cast((@DiemMieng + @DiemGiuaKy * 2 + @DiemHocKy * 3) as float) / 6);
					set @tongSoMonKy2 = @tongSoMonKy2 + 1;
				end
			fetch next from @diem_cursor into @DiemMieng,@DiemGiuaKy,@DiemHocKy, @HocKy
		end
		if @tongSoMonKy1 <> 0
			set @DiemKy1 = @DiemKy1 / @tongSoMonKy1;
	 	if @tongSoMonKy2 <> 0
		set @DiemKy2= @DiemKy2 / @tongSoMonKy2; 
		print 'Hoc ky 1: ' + cast(@DiemKy1 as nvarchar) + '\ Hoc Ky 2: ' + cast(@DiemKy2 as nvarchar)
		declare @diemTongKet float;
		set @diemTongKet = 0;
		if @DiemKy1 = 0
			begin
				set @diemTongKet = @DiemKy2;
			end
		else if @DiemKy2 = 0
			begin
				set @diemTongKet = @DiemKy1;
			end
		else if @DiemKy1 <> 0 and @DiemKy2 <> 0
			set @diemTongKet = (@DiemKy1 + @DiemKy2 * 2) / 3;
		print 'Diem Tong Ket: ' + cast(@diemTongKet as nvarchar);
		if @diemTongKet >= 8
			set @XepLoai = 'Gioi'
		else if @diemTongKet < 8 and @diemTongKet > 5
			set @XepLoai = 'Kha'
		else if @diemTongKet <= 5
			set @XepLoai = 'Trung Binh'
		update HOC_SINH set DiemTrungBinh=@diemTongKet,XepLoai=@XepLoai where MaHocSinh=@MaHocSinh;
		CLOSE @diem_cursor;
		DEALLOCATE @diem_cursor;
		commit tran
	end try
	begin catch
		 PRINT 'Error Message: ' + ERROR_MESSAGE();
		 rollback tran
	end catch