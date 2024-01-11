CREATE DATABASE QuanLyCuaHangBanLaptop
use QuanLyCuaHangBanLaptop

create table Loai(
	MaLoai nvarchar(10) not null,
	TenLoai nvarchar(50) not null,
	GhiChu nvarchar(100),
	CONSTRAINT PK_L PRIMARY KEY(MaLoai)
)
CREATE TABLE SanPham(
	MaSP nvarchar(10) NOT NULL,
	TenSP nvarchar(50) NOT NULL,
	MaLoai nvarchar(10) Not null,
	SLSanPham int,
	DonGiaBan int ,
	GiamGia int,
	GhiChu nvarchar(100),
	Anh Image,
	CONSTRAINT PK_SP PRIMARY KEY(MaSP),
	CONSTRAINT FK_HDN_Loai FOREIGN KEY(MaLoai) REFERENCES Loai(MaLoai)
)
Go

CREATE TABLE NhaCungCap(
	MaNCC nvarchar(10) NOT NULL,
	TenNCC nvarchar(50) NOT NULL,
	SoDienThoai nvarchar(15) NOT NULL, 
	DiaChi nvarchar(50) not null,
	CONSTRAINT PK_NCC PRIMARY KEY(MaNCC),
)

CREATE TABLE Khach(
	MaKhach nvarchar(10) NOT NULL,
	TenKhach nvarchar(50) NOT NULL,
	Diachi Nvarchar(50),
	DienThoai nvarchar(50),
	CONSTRAINT PK_KH PRIMARY KEY(MaKhach)
)
Go
CREATE TABLE NhanVien(
	MaNhanVien nvarchar(10) NOT NULL,
	TenNhanVien nvarchar(50) NOT NULL,
	GioiTinh nvarchar(10),
	DiaChi nvarchar(50),
	DienThoai nvarchar(100),
	NgaySinh date,
	NgayLv date,
	Hsl int,
	ChucVu nvarchar(50),
	GhiChu nvarchar(50)
	CONSTRAINT PK_NV PRIMARY KEY(MaNhanVien)
)
Go

CREATE TABLE HoaDonNhap(
	MaHoaDonNhap nvarchar(50) NOT NULL,
	MaNhanVien nvarchar(10) NOT NULL,
	NgayNhap Date,
	MaNCC nvarchar(10),
	TongTien int
	CONSTRAINT PK_HDN PRIMARY KEY(MaHoaDonNhap),
	CONSTRAINT FK_HDN_NV FOREIGN KEY(MaNhanVien) REFERENCES NhanVien(MaNhanVien),
	CONSTRAINT FK_HDN_NCC FOREIGN KEY(MaNCC) REFERENCES NhaCungCap(MaNCC),
)

CREATE TABLE HoaDonBan(
	MaHoaDonBan nvarchar(10) NOT NULL,
	MaNhanVien nvarchar(10) NOT NULL,
	NgayBan Date,
	MaKhach nvarchar(10) NOT NULL,
	TongTien int,
	CONSTRAINT PK_HDB PRIMARY KEY(MaHoaDonBan),
	CONSTRAINT FK_HDB1 FOREIGN KEY(MaNhanVien) REFERENCES NhanVien(MaNhanVien),
	CONSTRAINT FK_HDB2 FOREIGN KEY(MaKhach) REFERENCES Khach(MaKhach)
)
Go

CREATE TABLE ChiTietHDB(
	MaHoaDonBan NVARCHAR(10) NOT NULL ,
	MaSP NVARCHAR(10) NOT NULL,
	SoLuong int,
	ThanhTien int,
	CONSTRAINT PK_CTHDB PRIMARY KEY(MaHoaDonBan,MaSP),
	CONSTRAINT FK_CTHDB1 FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP),
	CONSTRAINT FK_CTHDB2 FOREIGN KEY(MaHoaDonBan) REFERENCES HoaDonBan(MaHoaDonBan)
)
Go
CREATE TABLE ChiTietHDN(
	MaHoaDonNhap NVARCHAR(50) NOT NULL ,
	MaSP NVARCHAR(10) NOT NULL,
	DonGiaNhap int,
	SoLuong int ,
	ThanhTien int,
	CONSTRAINT PK_CTHDN PRIMARY KEY(MaHoaDonNhap,MaSP),
	CONSTRAINT FK_CTHDN1 FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP),
	CONSTRAINT FK_CTHDN2 FOREIGN KEY(MaHoaDonNhap) REFERENCES HoaDonNhap(MaHoaDonNhap)
)
Go

create table UserAccount(
	UserName nchar(50) not null,
	[PassWord]  nchar(50) not null,
	MaNhanVien nvarchar(10) NOT NULL,
	TypeAccount int not null
	Constraint PK_UserAccount primary key (UserName),
	CONSTRAINT FK_UA FOREIGN KEY(MaNhanVien) REFERENCES NhanVien(MaNhanVien)
)

drop table SanPham
drop table ChiTietHDB
drop table ChiTietHDN
drop table HoaDonNhap
drop table HoaDonBan
drop table NhanVien
drop table NhaCungCap
drop table Loai
drop table UserAccount

insert into Khach values('KH001',N'Nguyễn Văn An',N'Hà Nội'	,'0987654321'),
('KH002',N'Trần Thị Bình',N'TP. Hồ Chí Minh',	'0123456789'),
('KH003',N'	Lê Văn Chung'	,N'Đà Nẵng','0123456789'),
('KH004',N'Vũ Thị Dương',N'Hải Phòng','0123456789')


INSERT INTO NhanVien (MaNhanVien, TenNhanVien, DiaChi, DienThoai)
VALUES (N'NV001', N'Nguyen Van A', '123 Đường ABC', '0123456789');

INSERT INTO NhaCungCap (MaNCC, TenNCC, DiaChi, SoDienThoai)
VALUES (N'NCC001', N'Nha Cung Cap A', N'456 Đường XYZ', '0987654321');

INSERT INTO HoaDonNhap (MaHoaDonNhap, MaNhanVien, NgayNhap, MaNCC, TongTien)
VALUES (N'HDN231117001', N'NV001', N'2023-01-15', N'NCC001', 500000);

select * from NhaCungCap 
-- Thêm dữ liệu vào bảng ChiTietHDN
INSERT INTO ChiTietHDN (MaHoaDonNhap, MaSP, SoLuong)
VALUES
    (N'HDN001', N'SP001', 10),
    (N'HDN001', N'SP002', 5);

INSERT INTO SanPham (MaSP, TenSP, DonGiaBan, MaLoai)
VALUES
    (N'SP0001', N'Sản Phẩm 1', 100000, N'LSP001'),
    (N'SP0002', N'Sản Phẩm 2', 150000, N'LSP002');
INSERT INTO Loai (MaLoai, TenLoai, GhiChu)
VALUES
    (N'LSP001', N'Loại Sản Phẩm 1', NULL),
    (N'LSP002', N'Loại Sản Phẩm 2', NULL);


INSERT INTO UserAccount values(N'Admin' , N'123', N'NV001', 1)
INSERT INTO UserAccount values(N'NhanVien' , N'123', N'NV001', 0)



-------- Function ---------
------Lấy danh sách hóa đơn nhập hàng 
CREATE FUNCTION GetHoaDonNhapHang()
RETURNS TABLE
AS
RETURN (
    SELECT HDN.MaHoaDonNhap, HDN.NgayNhap, HDN.MaNhanVien,
           CTHDN.MaSP, CTHDN.SoLuong , CTHDN.DonGiaNhap, HDN.MaNCC, HDN.TongTien
    FROM HoaDonNhap HDN
    INNER JOIN ChiTietHDN CTHDN ON HDN.MaHoaDonNhap = CTHDN.MaHoaDonNhap
);

------Tự động xóa hóa đơn nhập
CREATE TRIGGER trg_DeleteChiTietHDN
ON HoaDonNhap
INSTEAD OF DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM ChiTietHDN
    WHERE MaHoaDonNhap IN (SELECT MaHoaDonNhap FROM deleted);

    -- Now delete the record from HoaDonNhap
    DELETE FROM HoaDonNhap
    WHERE MaHoaDonNhap IN (SELECT MaHoaDonNhap FROM deleted);
END;


select * from GetHoaDonNhapHang()
DROP TRIGGER trg_DeleteChiTietHDN

delete from HoaDonNhap 
where MaHoaDonNhap = N'HDN2311190007';

------- Xóa hóa đơn nhập
CREATE PROCEDURE DeleteHoaDonNhap
    @MaHoaDonNhap NVARCHAR(50),
    @MaSP NVARCHAR(10)
AS
BEGIN
    DELETE FROM ChiTietHDN
    WHERE MaHoaDonNhap = @MaHoaDonNhap AND MaSP = @MaSP;

    DELETE FROM HoaDonNhap
    WHERE MaHoaDonNhap = @MaHoaDonNhap;
	
	DELETE FROM SanPham
    WHERE MaSP = @MaSP;
END;

EXECUTE DeleteHoaDonNhap 
    @MaHoaDonNhap = N'HDN2311170004',
	@MaSP = N'SP0001';


DROP PROCEDURE DeleteHoaDonNhap;

------ Xóa chi tiết hóa đơn nhập
CREATE PROCEDURE DeleteChiTietHoaDonNhap
    @MaHoaDonNhap NVARCHAR(50),
    @MaSP NVARCHAR(10)
AS
BEGIN
    DECLARE @SoLuong INT;

    -- Lấy số lượng sản phẩm từ ChiTietHDN
    SELECT @SoLuong = SoLuong
    FROM ChiTietHDN
    WHERE MaHoaDonNhap = @MaHoaDonNhap AND MaSP = @MaSP;

    -- Kiểm tra nếu số lượng sản phẩm trong ChiTietHDN bằng số lượng sản phẩm trong SanPham
    IF @SoLuong = (SELECT SLSanPham FROM SanPham WHERE MaSP = @MaSP)
    BEGIN
        -- Xóa dòng tương ứng trong SanPham
        DELETE FROM SanPham WHERE MaSP = @MaSP;
    END
    ELSE
    BEGIN
        -- Giảm số lượng sản phẩm trong SanPham
        UPDATE SanPham
        SET SLSanPham = SLSanPham - @SoLuong
        WHERE MaSP = @MaSP;
    END

    -- Xóa dòng trong ChiTietHDN
    DELETE FROM ChiTietHDN
    WHERE MaHoaDonNhap = @MaHoaDonNhap AND MaSP = @MaSP;

    -- Xóa dòng trong HoaDonNhap
    DELETE FROM HoaDonNhap
    WHERE MaHoaDonNhap = @MaHoaDonNhap;
END;

EXECUTE DeleteChiTietHoaDonNhap 
    @MaHoaDonNhap = N'HDN2311190011',
	@MaSP = N'SP0001';

SELECT * FROM SanPham
SELECT * FROM GetHoaDonNhapHang()


-----Tự động cập nhật tiền hóa đơn nhập hàng
CREATE TRIGGER UpdateTongTien
ON ChiTietHDN
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE HoaDonNhap
    SET TongTien = ISNULL((SELECT SUM(SoLuong * DonGiaNhap) FROM ChiTietHDN WHERE ChiTietHDN.MaHoaDonNhap = HoaDonNhap.MaHoaDonNhap), 0)
    FROM HoaDonNhap
    WHERE HoaDonNhap.MaHoaDonNhap IN (SELECT MaHoaDonNhap FROM inserted) OR
          HoaDonNhap.MaHoaDonNhap IN (SELECT MaHoaDonNhap FROM deleted);
END;

CREATE TRIGGER UpdateThanhTien
ON ChiTietHDN
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE ChiTietHDN
    SET ThanhTien = ISNULL(ChiTietHDN.DonGiaNhap * ChiTietHDN.SoLuong, 0)
    FROM ChiTietHDN
    INNER JOIN inserted ON ChiTietHDN.MaHoaDonNhap = inserted.MaHoaDonNhap AND ChiTietHDN.MaSP = inserted.MaSP;
END;


Drop Trigger UpdateThanhTien

SELECT * FROM GetHoaDonNhapHang();
SELECT * FROM ChiTietHDN

UPDATE ChiTietHDN
SET SoLuong = 9
FROM ChiTietHDN
WHERE ChiTietHDN.MaHoaDonNhap = N'HDN2311190001'
      AND ChiTietHDN.MaSP = N'SP0001';

--- Thống kê

--- Lấy nhân viên bán được nhiều hàng nhất
CREATE PROCEDURE GetTopSellingEmployee
    @Month INT,
    @Year INT
AS
BEGIN
    SELECT TOP 1
        NV.TenNhanVien AS EmployeeName,
        SUM(ISNULL(CTHDB.ThanhTien, 0)) AS TotalRevenue
    FROM
        NhanVien NV
    LEFT JOIN
        HoaDonBan HDB ON NV.MaNhanVien = HDB.MaNhanVien
    LEFT JOIN
        ChiTietHDB CTHDB ON HDB.MaHoaDonBan = CTHDB.MaHoaDonBan
    WHERE
        MONTH(HDB.NgayBan) = @Month AND YEAR(HDB.NgayBan) = @Year
    GROUP BY
        NV.TenNhanVien, NV.MaNhanVien
    ORDER BY
        TotalRevenue DESC;
END

EXEC GetTopSellingEmployees @Month = 11, @Year = 2023;

--- Lấy sản phẩm bán chạy nhất theo tháng
CREATE PROCEDURE GetBestSellingProduct
    @Month INT,
    @Year INT
AS
BEGIN
    SELECT TOP 1
        SP.MaSP AS ProductID,
        SP.TenSP AS ProductName,
        SUM(ISNULL(CTHDB.SoLuong, 0)) AS TotalQuantitySold
    FROM
        SanPham SP
    LEFT JOIN
        ChiTietHDB CTHDB ON SP.MaSP = CTHDB.MaSP
    LEFT JOIN
        HoaDonBan HDB ON CTHDB.MaHoaDonBan = HDB.MaHoaDonBan
    WHERE
        MONTH(HDB.NgayBan) = @Month AND YEAR(HDB.NgayBan) = @Year
    GROUP BY
        SP.MaSP, SP.TenSP
    ORDER BY
        TotalQuantitySold DESC;
END

EXEC GetBestSellingProduct @Month = 11, @Year = 2023;

---- Khách hàng của tháng 
CREATE PROCEDURE GetTopCustomerInMonth
    @Month INT,
    @Year INT
AS
BEGIN
    SELECT TOP 1
        K.MaKhach AS CustomerID,
        K.TenKhach AS CustomerName,
        SUM(CTHDB.ThanhTien) AS TotalSpending
    FROM
        Khach K
    JOIN
        HoaDonBan HDB ON K.MaKhach = HDB.MaKhach
    JOIN
        ChiTietHDB CTHDB ON HDB.MaHoaDonBan = CTHDB.MaHoaDonBan
    WHERE
        MONTH(HDB.NgayBan) = @Month AND YEAR(HDB.NgayBan) = @Year
    GROUP BY
        K.MaKhach, K.TenKhach
    ORDER BY
        TotalSpending DESC;
END

EXEC GetTopCustomerInMonth @Month = 11, @Year = 2023;

--- Danh sách sản phẩm đã bán trong tháng
CREATE PROCEDURE GetSoldProductsInMonth
    @Month INT,
    @Year INT
AS
BEGIN
    SELECT
        SP.MaSP AS ProductID,
        SP.TenSP AS ProductName,
        SUM(CTHDB.SoLuong) AS SLBan,
        SUM(CTHDB.ThanhTien) AS DonGia,
        AVG(SP.DonGiaBan) AS TongTien
    FROM
        SanPham SP
    JOIN
        ChiTietHDB CTHDB ON SP.MaSP = CTHDB.MaSP
    JOIN
        HoaDonBan HDB ON CTHDB.MaHoaDonBan = HDB.MaHoaDonBan
    WHERE
        MONTH(HDB.NgayBan) = @Month AND YEAR(HDB.NgayBan) = @Year
    GROUP BY
        SP.MaSP, SP.TenSP
    ORDER BY
        SLBan DESC;
END

EXEC GetSoldProductsInMonth @Month = 11, @Year = 2023;



------ Doanh thu theo tháng 
CREATE PROCEDURE GetDoanhThuThang
    @Month INT = NULL,
    @Year INT = NULL
AS
BEGIN
    SELECT
        MONTH(HDB.NgayBan) AS Month,
        SUM(ISNULL(CTHDB.ThanhTien, 0)) AS TotalRevenue
    FROM
        HoaDonBan HDB
    LEFT JOIN
        ChiTietHDB CTHDB ON HDB.MaHoaDonBan = CTHDB.MaHoaDonBan
    WHERE
        (@Month IS NULL OR MONTH(HDB.NgayBan) = @Month)
        AND (@Year IS NULL OR YEAR(HDB.NgayBan) = @Year)
    GROUP BY
        MONTH(HDB.NgayBan)
    ORDER BY
        Month;
END
EXEC GetDoanhThuThang @Month = 11, @Year = 2023;



------ Doanh thu các tháng trong năm

--- Thống kê doanh thu theo năm
CREATE PROCEDURE GetMonthlyRevenue
    @Year INT
AS
BEGIN
    -- Tạo bảng số hóa đơn từ 1 đến 12
    DECLARE @Months TABLE (Month INT);
    INSERT INTO @Months VALUES (1), (2), (3), (4), (5), (6), (7), (8), (9), (10), (11), (12);

    SELECT
        M.Month AS Month,
        --SUM(ISNULL(CTHDB.ThanhTien, 0)) AS TotalRevenue
		ISNULL(SUM(CAST(CTHDB.ThanhTien AS bigint)), 0) AS TotalRevenue
    FROM
        @Months M
    LEFT JOIN
        HoaDonBan HDB ON MONTH(HDB.NgayBan) = M.Month AND YEAR(HDB.NgayBan) = @Year
    LEFT JOIN
        ChiTietHDB CTHDB ON HDB.MaHoaDonBan = CTHDB.MaHoaDonBan
    GROUP BY
        M.Month
    ORDER BY
        M.Month;
END
drop PROCEDURE GetMonthlyRevenue

EXEC GetMonthlyRevenue @Year = 2023;

select * from ChiTietHDB

----- Thống kê chi phí theo năm
CREATE PROCEDURE GetMonthlyExpenses
    @Year INT
AS
BEGIN
    -- Tạo bảng số hóa đơn từ 1 đến 12
    DECLARE @Months TABLE (Month INT);
    INSERT INTO @Months VALUES (1), (2), (3), (4), (5), (6), (7), (8), (9), (10), (11), (12);

    SELECT
        M.Month AS Month,
        --ISNULL(SUM(HDN.TongTien), 0) AS TotalExpenses
		ISNULL(SUM(CAST(HDN.TongTien AS bigint)), 0) AS TotalExpenses
    FROM
        @Months M
    LEFT JOIN
        HoaDonNhap HDN ON MONTH(HDN.NgayNhap) = M.Month AND YEAR(HDN.NgayNhap) = @Year
    GROUP BY
        M.Month
    ORDER BY
        M.Month;
END

drop PROCEDURE GetMonthlyExpenses

EXEC GetMonthlyExpenses @Year = 2023;


EXEC GetMonthlyExpenses @Year = 2023;
EXEC GetMonthlyRevenue @Year = 2023;


----- Lợi nhuận  
----- Lợi nhuận theo năm (Cách 1)
CREATE PROCEDURE GetMonthlyProfit
    @Year INT
AS
BEGIN
    -- Tạo bảng số hóa đơn từ 1 đến 12
    DECLARE @Months TABLE (Month INT);
    INSERT INTO @Months VALUES (1), (2), (3), (4), (5), (6), (7), (8), (9), (10), (11), (12);

    SELECT
        M.Month AS Month,
        ISNULL(SUM(ISNULL(HDB.TongTien, 0)) - SUM(ISNULL(HDN.TongTien, 0)), 0) AS MonthlyProfit
    FROM
        @Months M
    LEFT JOIN
        HoaDonBan HDB ON MONTH(HDB.NgayBan) = M.Month AND YEAR(HDB.NgayBan) = @Year
    LEFT JOIN
        HoaDonNhap HDN ON MONTH(HDN.NgayNhap) = M.Month AND YEAR(HDN.NgayNhap) = @Year
    GROUP BY
        M.Month
    ORDER BY
        M.Month;
END


-- Tính lợi nhuận theo năm (Cách 2) -- Đang dùng
CREATE PROCEDURE GetMonthlyProfit
    @Year INT
AS
BEGIN
    -- Tạo bảng số hóa đơn từ 1 đến 12
    DECLARE @Months TABLE (Month INT);
    INSERT INTO @Months VALUES (1), (2), (3), (4), (5), (6), (7), (8), (9), (10), (11), (12);

    -- Tính doanh thu từ stored procedure GetMonthlyRevenue
    SELECT
        M.Month AS Month,
        --ISNULL(SUM(ISNULL(CTHDB.ThanhTien, 0)), 0) AS TotalRevenue
		ISNULL(SUM(CAST(CTHDB.ThanhTien AS bigint)), 0) AS TotalRevenue
    INTO #Revenue
    FROM
        @Months M
    LEFT JOIN
        HoaDonBan HDB ON MONTH(HDB.NgayBan) = M.Month AND YEAR(HDB.NgayBan) = @Year
    LEFT JOIN
        ChiTietHDB CTHDB ON HDB.MaHoaDonBan = CTHDB.MaHoaDonBan
    GROUP BY
        M.Month;

    -- Tính chi phí từ stored procedure GetMonthlyExpenses
    SELECT
        M.Month AS Month,
        --ISNULL(SUM(ISNULL(HDN.TongTien, 0)), 0) AS TotalExpenses
		ISNULL(SUM(CAST(HDN.TongTien AS bigint)), 0) AS TotalExpenses
    INTO #Expenses
    FROM
        @Months M
    LEFT JOIN
        HoaDonNhap HDN ON MONTH(HDN.NgayNhap) = M.Month AND YEAR(HDN.NgayNhap) = @Year
    GROUP BY
        M.Month;

    -- Tính lợi nhuận bằng cách trừ chi phí từ doanh thu
    SELECT
        R.Month,
        R.TotalRevenue - E.TotalExpenses AS MonthlyProfit
    FROM
        #Revenue R
    LEFT JOIN
        #Expenses E ON R.Month = E.Month;

    -- Drop bảng tạm
    DROP TABLE #Revenue;
    DROP TABLE #Expenses;
END

drop PROCEDURE GetMonthlyProfit;

EXEC GetMonthlyProfit @Year = 2023;


----- thống kê các loại được bán 
drop PROCEDURE GetLoaiDuocBanTheoThang

CREATE PROCEDURE GetLoaiDuocBanTheoThang
    @Thang INT
AS
BEGIN
        SELECT
            L.TenLoai,
            COUNT(SP.MaSP) AS SoLuong
        FROM
            Loai L
        LEFT JOIN
            SanPham SP ON L.MaLoai = SP.MaLoai
        LEFT JOIN
            ChiTietHDB CTHDB ON SP.MaSP = CTHDB.MaSP
        LEFT JOIN
            HoaDonBan HDB ON CTHDB.MaHoaDonBan = HDB.MaHoaDonBan
        WHERE
            MONTH(HDB.NgayBan) = @Thang
        GROUP BY
            L.TenLoai
END;

EXEC GetLoaiDuocBanTheoThang @Thang = 11;



select * from SanPham


select * from ChiTietHDB
select * from HoaDonBan

drop TRIGGER CapNhatTongTienBan
-------- Function cua Diep
CREATE TRIGGER CapNhatTongTienBan
ON ChiTietHDB
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật thành tiền trong chi tiết hóa đơn bán
    UPDATE CTHDB
    SET ThanhTien = CTHDB.SoLuong * (DonGiaBan - (DonGiaBan * GiamGia / 100))
    FROM ChiTietHDB CTHDB
    INNER JOIN inserted I ON CTHDB.MaHoaDonBan = I.MaHoaDonBan
    INNER JOIN SanPham SP ON CTHDB.MaSP = SP.MaSP;

    -- Cập nhật tổng tiền trong hóa đơn bán
    UPDATE HDB
    SET TongTien = ISNULL((SELECT SUM(ThanhTien) FROM ChiTietHDB WHERE MaHoaDonBan = HDB.MaHoaDonBan), 0)
    FROM HoaDonBan HDB
    INNER JOIN inserted I ON HDB.MaHoaDonBan = I.MaHoaDonBan;
END;



CREATE OR ALTER TRIGGER capnhatTT
ON ChiTietHDB
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    UPDATE HoaDonBan
    SET TongTien = COALESCE((
        SELECT SUM(COALESCE(ThanhTien, 0))
        FROM ChiTietHDB
        WHERE ChiTietHDB.MaHoaDonBan = HoaDonBan.MaHoaDonBan
    ), 0)
    FROM HoaDonBan
    WHERE MaHoaDonBan IN (SELECT MaHoaDonBan FROM inserted)
       OR MaHoaDonBan IN (SELECT MaHoaDonBan FROM deleted);
END
create procedure TongTien @mahdb nvarchar(10), @tongtien money output
as
begin 
select @tongtien = sum(ThanhTien) from ChiTietHDB inner join HoaDonBan 
								  on HoaDonBan.MaHoaDonBan = ChiTietHDB.MaHoaDonBan
where HoaDonBan.MaHoaDonBan = @mahdb
end
declare @tien nvarchar(10)
exec TongTien 'HDB0001', @tien output
print @tien
-----trigger thành tiền----
CREATE or alter TRIGGER CapNhatTongTienBan
ON ChiTietHDB
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật thành tiền trong chi tiết hóa đơn bán
    UPDATE CTHDB
    SET ThanhTien = CTHDB.SoLuong * (DonGiaBan - (DonGiaBan * GiamGia / 100))
    FROM ChiTietHDB CTHDB
    INNER JOIN inserted I ON CTHDB.MaHoaDonBan = I.MaHoaDonBan
    INNER JOIN SanPham SP ON CTHDB.MaSP = SP.MaSP;

    -- Cập nhật tổng tiền trong hóa đơn bán
    --UPDATE HDB
    --SET TongTien = ISNULL((SELECT SUM(ThanhTien) FROM ChiTietHDB WHERE MaHoaDonBan = HDB.MaHoaDonBan), 0)
    --FROM HoaDonBan HDB
    --INNER JOIN inserted I ON HDB.MaHoaDonBan = I.MaHoaDonBan;
END;
-----triiger tổng tiền----
CREATE OR ALTER TRIGGER capnhatTT
ON ChiTietHDB
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    UPDATE HoaDonBan
    SET TongTien = COALESCE((
        SELECT SUM(COALESCE(ThanhTien, 0))
        FROM ChiTietHDB
        WHERE ChiTietHDB.MaHoaDonBan = HoaDonBan.MaHoaDonBan
    ), 0)
    FROM HoaDonBan
    WHERE MaHoaDonBan IN (SELECT MaHoaDonBan FROM inserted)
       OR MaHoaDonBan IN (SELECT MaHoaDonBan FROM deleted);
END
drop trigger capnhatTT
----tính tổng tiền
create procedure TinhTongTien @tien money output
as
begin
	select @tien = sum(TongTien)  from HoaDonBan 
end

declare @t money
exec TinhTongTien @t output
print @t
----
create or alter procedure TT_MaKH @makh nvarchar(10), @tienn money output
as
begin	
	select @tienn = sum(TongTien) from HoaDonBan where makhach = @makh
end
declare @tt money
exec TT_MaKH'KH01', @tt output
print @tt
-----
create or alter procedure TT_Ngay @ngay datetime, @tiennn money output
as
begin	
	select @tiennn = sum(TongTien) from HoaDonBan where NgayBan = @ngay
end
declare @ttt money
exec TT_Ngay'2023-11-19', @ttt output
print @ttt




---- Test
SET SoLuong = 3
WHERE MaHoaDonNhap = N'HDN001';


UPDATE ChiTietHDN
SET SoLuong = 10
FROM ChiTietHDN
WHERE ChiTietHDN.MaHoaDonNhap = N'HDN2311180005'
      AND ChiTietHDN.MaSP = N'SP0011';
	  

SELECT * FROM GetHoaDonNhapHang();


Select * FROM HoaDonNhap
JOIN ChiTietHDN ON ChiTietHDN.MaHoaDonNhap = HoaDonNhap.MaHoaDonNhap
WHERE HoaDonNhap.MaHoaDonNhap = N'HDN2311180005'
      AND ChiTietHDN.MaSP = N'SP0012';




-- Chèn dữ liệu cho bảng Loai
INSERT INTO Loai (MaLoai, TenLoai, GhiChu) VALUES 
(N'L1', N'Laptop Gaming', N'Dành cho giải trí và chơi game'),
(N'L2', N'Laptop Văn Phòng', N'Dành cho công việc văn phòng');

-- Chèn dữ liệu cho bảng SanPham
INSERT INTO SanPham (MaSP, TenSP, MaLoai, SLSanPham, DonGiaBan, GiamGia, GhiChu) VALUES 
(N'SP1', N'Laptop Gaming XYZ', N'L1', 50, 15000000, 5, N'Mô tả sản phẩm 1'),
(N'SP2', N'Laptop Văn Phòng ABC', N'L2', 30, 10000000, 0, N'Mô tả sản phẩm 2');

-- Chèn dữ liệu cho bảng NhaCungCap
INSERT INTO NhaCungCap (MaNCC, TenNCC, SoDienThoai, DiaChi) VALUES 
(N'NCC1', N'Nhà cung cấp A', '0123456789', N'Địa chỉ A'),
(N'NCC2', N'Nhà cung cấp B', '0987654321', N'Địa chỉ B');

-- Chèn dữ liệu cho bảng Khach
INSERT INTO Khach (MaKhach, TenKhach, Diachi, DienThoai) VALUES 
(N'KH1', N'Khách hàng 1', N'Địa chỉ khách hàng 1', '0123456789'),
(N'KH2', N'Khách hàng 2', N'Địa chỉ khách hàng 2', '0987654321');

-- Chèn dữ liệu cho bảng NhanVien
INSERT INTO NhanVien (MaNhanVien, TenNhanVien, GioiTinh, DiaChi, DienThoai, NgaySinh, NgayLv, Hsl, ChucVu, GhiChu) VALUES 
(N'NV1', N'Nhân viên 1', N'Nam', N'Địa chỉ NV1', '0123456789', '1990-01-01', '2020-01-01', 1, N'Nhân viên', N'Ghi chú NV1'),
(N'NV2', N'Nhân viên 2', N'Nữ', N'Địa chỉ NV2', '0987654321', '1995-05-05', '2021-01-01', 1, N'Nhân viên', N'Ghi chú NV2');

-- Chèn dữ liệu cho bảng HoaDonNhap
INSERT INTO HoaDonNhap (MaHoaDonNhap, MaNhanVien, NgayNhap, MaNCC, TongTien) VALUES 
(N'HDN1', N'NV1', '2023-01-05', N'NCC1', 5000000),
(N'HDN2', N'NV2', '2023-02-10', N'NCC2', 7000000);

-- Chèn dữ liệu cho bảng HoaDonBan
INSERT INTO HoaDonBan (MaHoaDonBan, MaNhanVien, NgayBan, MaKhach, TongTien) VALUES 
(N'HDB3', 'NV1', '2023-11-15', 'KH1', 12000000);

-- Chèn dữ liệu cho bảng ChiTietHDB
INSERT INTO ChiTietHDB (MaHoaDonBan, MaSP, SoLuong, ThanhTien) VALUES 
('HDB3', 'SP2', 3, 45000000);

-- Chèn dữ liệu cho bảng ChiTietHDN
INSERT INTO ChiTietHDN (MaHoaDonNhap, MaSP, DonGiaNhap, SoLuong, ThanhTien) VALUES 
('HDN1', 'SP1', 4000000, 5, 20000000),
('HDN2', 'SP2', 6000000, 3, 18000000);

-- Chèn dữ liệu cho bảng UserAccount
INSERT INTO UserAccount (UserName, PassWord, MaNhanVien, TypeAccount) VALUES 
('user1', 'pass1', 'NV1', 1),
('user2', 'pass2', 'NV2', 2);

