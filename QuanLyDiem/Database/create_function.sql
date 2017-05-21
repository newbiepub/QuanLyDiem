/*
	Trung Binh Mon
*/
CREATE FUNCTION TrungBinhMon
(
	@DiemMieng float,
	@DiemGiuaKy float,
	@DiemHocKy float
)
RETURNS float
AS
BEGIN
	RETURN (@DiemMieng + @DiemGiuaKy * 2 + @DiemHocKy * 3) / 6;
END