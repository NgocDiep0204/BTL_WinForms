CREATE DATABASE QL_CuaHang
USE QL_CuaHang
GO
-------CREATE TABLE-----
CREATE TABLE tNhanVien (
    MaNV NVARCHAR(10) PRIMARY KEY,
    TenNV NVARCHAR(50),
    GioiTinh NVARCHAR(5),
    NgaySinh DATE,
    DiaChi NVARCHAR(150),
    DienThoai NVARCHAR(15)
);
GO
CREATE TABLE tHoaDonNhap (
    SoHDN NVARCHAR(10) PRIMARY KEY,
    MaNV NVARCHAR(10),
    NgayNhap DATETIME,
    MaNCC NVARCHAR(10),
    FOREIGN KEY (MaNV) REFERENCES tNhanVien(MaNV),
    FOREIGN KEY (MaNCC) REFERENCES tNhaCungCap(MaNCC)
);
GO
CREATE TABLE tChiTietHDN (
    SoHDN NVARCHAR(10),
    MaSP NVARCHAR(10),
    SLNhap INT,
    KhuyenMai NVARCHAR(100),
    PRIMARY KEY (SoHDN, MaSP),
    FOREIGN KEY (SoHDN) REFERENCES tHoaDonNhap(SoHDN),
    FOREIGN KEY (MaSP) REFERENCES tSanPham(MaSP)
);

GO
CREATE TABLE tNhaCungCap (
    MaNCC NVARCHAR(10) PRIMARY KEY,
    TenNCC NVARCHAR(200),
    DiaChi NVARCHAR(150),
    SoDienThoai NVARCHAR(15)
);
GO
CREATE TABLE tHoaDonBan (
    SoHDB NVARCHAR(10) PRIMARY KEY,
    MaNV NVARCHAR(10),
    NgayBan DATETIME,
    MaKH NVARCHAR(10),
    FOREIGN KEY (MaNV) REFERENCES tNhanVien(MaNV),
    FOREIGN KEY (MaKH) REFERENCES tKhachHang(MaKH)
);
GO
CREATE TABLE tChiTietHDB (
    SoHDB NVARCHAR(10),
    MaSP NVARCHAR(10),
    SLBan INT,
    KhuyenMai NVARCHAR(100),
    ThanhTien DECIMAL(18, 2),
    PRIMARY KEY (SoHDB, MaSP),
    FOREIGN KEY (SoHDB) REFERENCES tHoaDonBan(SoHDB),
    FOREIGN KEY (MaSP) REFERENCES tSanPham(MaSP)
);
GO
CREATE TABLE tKhachHang (
    MaKH NVARCHAR(10) PRIMARY KEY,
    TenKH NVARCHAR(50),
    DiaChi NVARCHAR(150),
    DienThoai NVARCHAR(15),
    GioiTinh NVARCHAR(5)
);
GO
CREATE TABLE tSanPham (
    MaSP NVARCHAR(10) PRIMARY KEY,
    TenSP NVARCHAR(200),
    XuatXu NVARCHAR(100),
    SoLuong INT,
    DonGiaNhap DECIMAL(18, 2),
    DonGiaBan DECIMAL(18, 2),
    MaNSX NVARCHAR(10),
    TrongLuong NVARCHAR(50),
    Anh IMAGE,
    FOREIGN KEY (MaNSX) REFERENCES tNhaSanXuat(MaNSX)
);
GO
CREATE TABLE tNhaSanXuat (
    MaNSX NVARCHAR(10) PRIMARY KEY,
    TenNSX NVARCHAR(100)
);
GO
CREATE TABLE tTaiKhoan (
    TaiKhoan NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(100),
    MaNV NVARCHAR(10),
    FOREIGN KEY (MaNV) REFERENCES tNhanVien(MaNV)
);
GO

----- INSERT DATA-------
INSERT INTO tNhanVien (MaNV, TenNV, GioiTinh, NgaySinh, DiaChi, DienThoai)
VALUES 
('NV001', N'Nguyễn Văn A', N'Nam', '1990-01-01', N'Hà Nội', '123456789'),
('NV002', N'Trần Thị B', N'Nữ', '1995-05-05', N'TPHCM', '987654321'),
('NV003', N'Phạm Văn C', N'Nam', '1985-03-10', N'Đà Nẵng', '456123789');
INSERT INTO tNhaCungCap (MaNCC, TenNCC, DiaChi, SoDienThoai)
VALUES 
('NCC001', N'Công ty A', N'Địa chỉ A', '123456789'),
('NCC002', N'Công ty B', N'Địa chỉ B', '987654321'),
('NCC003', N'Công ty C', N'Địa chỉ C', '456123789');
INSERT INTO tHoaDonNhap (SoHDN, MaNV, NgayNhap, MaNCC)
VALUES 
('HDN001', N'NV001', '2023-10-01', N'NCC001'),
('HDN002', N'NV002', '2023-10-02', N'NCC002'),
('HDN003', N'NV003', '2023-10-03', N'NCC003');
INSERT INTO tChiTietHDN (SoHDN, MaSP, SLNhap, KhuyenMai)
VALUES 
('HDN001', N'SP001', 10, N'Giảm giá 10%'),
('HDN002', N'SP002', 15, N'Khuyến mãi hấp dẫn'),
('HDN003', N'SP003', 20, N'Không có khuyến mãi');
INSERT INTO tHoaDonBan (SoHDB, MaNV, NgayBan, MaKH)
VALUES 
('HDB001', N'NV001', '2023-10-01', N'KH001'),
('HDB002', N'NV002', '2023-10-02', N'KH002'),
('HDB003', N'NV003', '2023-10-03', N'KH003');
INSERT INTO tChiTietHDB (SoHDB, MaSP, SLBan, KhuyenMai, ThanhTien)
VALUES 
('HDB001', N'SP001', 5, N'Giảm giá 5%', 100.00),
('HDB002', N'SP002', 8, N'Khuyến mãi hấp dẫn', 150.00),
('HDB003', N'SP003', 10, N'Không có khuyến mãi', 200.00);
INSERT INTO tSanPham (MaSP, TenSP, XuatXu, SoLuong, DonGiaNhap, DonGiaBan, MaNSX, TrongLuong, Anh)
VALUES 
('SP001', N'Sản phẩm 1', N'Xuất xứ 1', 100, 50.00, 100.00, 'NSX001', N'Trọng lượng 1', NULL),
('SP002', N'Sản phẩm 2', N'Xuất xứ 2', 150, 75.00, 120.00, 'NSX002', N'Trọng lượng 2', NULL),
('SP003', N'Sản phẩm 3', N'Xuất xứ 3', 200, 100.00, 150.00, 'NSX003', N'Trọng lượng 3', NULL);
INSERT INTO tKhachHang (MaKH, TenKH, DiaChi, DienThoai, GioiTinh)
VALUES 
('KH001', N'Nguyễn Văn Khách 1', N'Địa chỉ 1', '111111111', N'Nam'),
('KH002', N'Trần Thị Khách 2', N'Địa chỉ 2', '222222222', N'Nữ'),
('KH003', N'Phạm Văn Khách 3', N'Địa chỉ 3', '333333333', N'Nam');
INSERT INTO tNhaSanXuat (MaNSX, TenNSX)
VALUES 
('NSX001', N'Nhà sản xuất 1'),
('NSX002', N'Nhà sản xuất 2'),
('NSX003', N'Nhà sản xuất 3');
INSERT INTO tTaiKhoan (TaiKhoan, MatKhau, MaNV)
VALUES 
('account1', N'pass1', 'NV001'),
('account2', N'pass2', 'NV002'),
('account3', N'pass3', 'NV003');



select * from tNhanVien

----- CREATE FUNCTON ... ----

UPDATE tTaiKhoan
SET TaiKhoan = N'admin3'
WHERE MatKhau = '123';



CREATE TRIGGER trg_DeleteMaNV
ON tNhanVien
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM tHoaDonNhap
    WHERE MaNV IN (SELECT deleted.MaNV FROM deleted);
	
	DELETE FROM tHoaDonBan
    WHERE MaNV IN (SELECT deleted.MaNV FROM deleted);

	DELETE FROM tTaiKhoan
    WHERE MaNV IN (SELECT deleted.MaNV FROM deleted);
END;



CREATE PROCEDURE DeleteBothTable
    @MaNV NVARCHAR(50)
AS
BEGIN
    BEGIN TRANSACTION; -- Bắt đầu giao dịch

    BEGIN TRY
        DELETE FROM tHoaDonBan WHERE MaNV = @MaNV; 
        DELETE FROM tHoaDonNhap WHERE MaNV = @MaNV;
		DELETE FROM tTaiKhoan WHERE MaNV = @MaNV;
		DELETE FROM tNhanVien WHERE MaNV = @MaNV; 
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
    END CATCH
END;


EXEC DeleteBothTable @MaNV = N'NV001';


delete tNhanVien
where MaNV = N'NV001';


---------------------


DECLARE @MaNV NVARCHAR(10) = 'NV001'; -- Mã nhân viên cần xóa

-- Cập nhật dữ liệu trong bảng tHoaDonNhap: 
-- Nếu có dòng nào trong bảng tHoaDonNhap có MaNV trùng với @MaNV, hãy cập nhật MaNV đó thành null hoặc giá trị mặc định.
UPDATE tHoaDonNhap
SET MaNV = @MaNV
WHERE MaNV = @MaNV;

UPDATE tHoaDonBan
SET MaNV = @MaNV
WHERE MaNV = @MaNV;

-- Cập nhật dữ liệu trong bảng tTaiKhoan:
-- Tương tự như trên, cập nhật MaNV thành giá trị mặc định hoặc null nếu có dòng nào chứa MaNV trùng với @MaNV.
UPDATE tTaiKhoan
SET MaNV = @MaNV
WHERE MaNV = @MaNV;

-- Cuối cùng, sau khi đã cập nhật dữ liệu trong các bảng có khóa ngoại trỏ đến MaNV, bạn có thể xóa dữ liệu từ bảng tNhanVien:
DELETE FROM tNhanVien WHERE MaNV = @MaNV;

select * from tMaNhanVien