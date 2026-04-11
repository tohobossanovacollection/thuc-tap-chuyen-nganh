-- Schema quan ly ban hang
-- Target: SQL Server
-- Db name: TTCN

-- Xoa bang theo thu tu phu thuoc de tao lai an toan
IF OBJECT_ID(N'dbo.chi_tiet_hoa_don', N'U') IS NOT NULL DROP TABLE dbo.chi_tiet_hoa_don;
IF OBJECT_ID(N'dbo.chi_tiet_phieu_nhap', N'U') IS NOT NULL DROP TABLE dbo.chi_tiet_phieu_nhap;
IF OBJECT_ID(N'dbo.hoa_don', N'U') IS NOT NULL DROP TABLE dbo.hoa_don;
IF OBJECT_ID(N'dbo.phieu_nhap_hang', N'U') IS NOT NULL DROP TABLE dbo.phieu_nhap_hang;
IF OBJECT_ID(N'dbo.san_pham', N'U') IS NOT NULL DROP TABLE dbo.san_pham;
IF OBJECT_ID(N'dbo.danh_muc_san_pham', N'U') IS NOT NULL DROP TABLE dbo.danh_muc_san_pham;
IF OBJECT_ID(N'dbo.khach_hang', N'U') IS NOT NULL DROP TABLE dbo.khach_hang;
IF OBJECT_ID(N'dbo.giam_gia', N'U') IS NOT NULL DROP TABLE dbo.giam_gia;
IF OBJECT_ID(N'dbo.nha_cung_cap', N'U') IS NOT NULL DROP TABLE dbo.nha_cung_cap;
IF OBJECT_ID(N'dbo.nhan_vien', N'U') IS NOT NULL DROP TABLE dbo.nhan_vien;
IF OBJECT_ID(N'dbo.tai_khoan', N'U') IS NOT NULL DROP TABLE dbo.tai_khoan;
GO

CREATE TABLE dbo.tai_khoan (
	ma_tai_khoan      VARCHAR(20) NOT NULL,
	ten_dang_nhap     VARCHAR(100) NOT NULL,
	mat_khau          VARCHAR(255) NOT NULL,
	quyen_han         VARCHAR(30) NOT NULL,
	CONSTRAINT PK_tai_khoan PRIMARY KEY (ma_tai_khoan),
	CONSTRAINT UQ_tai_khoan_ten_dang_nhap UNIQUE (ten_dang_nhap),
	CONSTRAINT CHK_tk_quyen_han CHECK (quyen_han IN ('ADMIN', 'QUAN_LY', 'NHAN_VIEN'))
);
GO

CREATE TABLE dbo.nhan_vien (
	ma_nhan_vien      VARCHAR(20) NOT NULL,
	ma_tai_khoan      VARCHAR(20) NOT NULL,
	ho_ten            NVARCHAR(150) NOT NULL,
	ngay_sinh         DATE NULL,
	dia_chi           NVARCHAR(255) NULL,
	so_dien_thoai     VARCHAR(20) NULL,
	email             VARCHAR(150) NULL,
	chuc_vu           NVARCHAR(100) NULL,
	phong_ban         NVARCHAR(100) NULL,
	trang_thai        VARCHAR(20) NOT NULL CONSTRAINT DF_nhan_vien_trang_thai DEFAULT ('ACTIVE'),
	CONSTRAINT PK_nhan_vien PRIMARY KEY (ma_nhan_vien),
	CONSTRAINT UQ_nhan_vien_ma_tai_khoan UNIQUE (ma_tai_khoan),
	CONSTRAINT UQ_nhan_vien_so_dien_thoai UNIQUE (so_dien_thoai),
	CONSTRAINT UQ_nhan_vien_email UNIQUE (email),
	CONSTRAINT FK_nv_tai_khoan FOREIGN KEY (ma_tai_khoan)
		REFERENCES dbo.tai_khoan(ma_tai_khoan)
		ON UPDATE CASCADE
		ON DELETE NO ACTION,
	CONSTRAINT CHK_nv_trang_thai CHECK (trang_thai IN ('ACTIVE', 'INACTIVE'))
);
GO

CREATE TABLE dbo.nha_cung_cap (
	ma_nha_cung_cap   VARCHAR(20) NOT NULL,
	ten_nha_cung_cap  NVARCHAR(200) NOT NULL,
	so_dien_thoai     VARCHAR(20) NULL,
	dia_chi           NVARCHAR(255) NULL,
	email             VARCHAR(150) NULL,
	CONSTRAINT PK_nha_cung_cap PRIMARY KEY (ma_nha_cung_cap),
	CONSTRAINT UQ_ncc_ten UNIQUE (ten_nha_cung_cap)
);
GO

CREATE TABLE dbo.danh_muc_san_pham (
	ma_danh_muc       VARCHAR(20) NOT NULL,
	ten_danh_muc      NVARCHAR(150) NOT NULL,
	CONSTRAINT PK_danh_muc_san_pham PRIMARY KEY (ma_danh_muc),
	CONSTRAINT UQ_danh_muc_san_pham_ten UNIQUE (ten_danh_muc)
);
GO

CREATE TABLE dbo.san_pham (
	ma_san_pham       VARCHAR(20) NOT NULL,
	ma_danh_muc       VARCHAR(20) NOT NULL,
	ten_san_pham      NVARCHAR(200) NOT NULL,
	gia_nhap          DECIMAL(15,2) NOT NULL,
	gia_ban           DECIMAL(15,2) NOT NULL,
	so_luong_ton      INT NOT NULL CONSTRAINT DF_san_pham_so_luong_ton DEFAULT (0),
	mo_ta_san_pham    NVARCHAR(MAX) NULL,
	CONSTRAINT PK_san_pham PRIMARY KEY (ma_san_pham),
	CONSTRAINT FK_sp_danh_muc FOREIGN KEY (ma_danh_muc)
		REFERENCES dbo.danh_muc_san_pham(ma_danh_muc)
		ON UPDATE CASCADE
		ON DELETE NO ACTION,
	CONSTRAINT CHK_sp_gia_nhap CHECK (gia_nhap >= 0),
	CONSTRAINT CHK_sp_gia_ban CHECK (gia_ban >= 0),
	CONSTRAINT CHK_sp_so_luong_ton CHECK (so_luong_ton >= 0)
);
GO

CREATE TABLE dbo.phieu_nhap_hang (
	ma_phieu_nhap     VARCHAR(20) NOT NULL,
	ngay_nhap         DATETIME2(0) NOT NULL CONSTRAINT DF_pnh_ngay_nhap DEFAULT (SYSDATETIME()),
	tong_tien         DECIMAL(15,2) NOT NULL CONSTRAINT DF_pnh_tong_tien DEFAULT (0),
	ma_nha_cung_cap   VARCHAR(20) NOT NULL,
	ma_nhan_vien      VARCHAR(20) NOT NULL,
	CONSTRAINT PK_phieu_nhap_hang PRIMARY KEY (ma_phieu_nhap),
	CONSTRAINT FK_pnh_nha_cung_cap FOREIGN KEY (ma_nha_cung_cap)
		REFERENCES dbo.nha_cung_cap(ma_nha_cung_cap)
		ON UPDATE CASCADE
		ON DELETE NO ACTION,
	CONSTRAINT FK_pnh_nhan_vien FOREIGN KEY (ma_nhan_vien)
		REFERENCES dbo.nhan_vien(ma_nhan_vien)
		ON UPDATE CASCADE
		ON DELETE NO ACTION,
	CONSTRAINT CHK_pnh_tong_tien CHECK (tong_tien >= 0)
);
GO

CREATE TABLE dbo.chi_tiet_phieu_nhap (
	ma_phieu_nhap     VARCHAR(20) NOT NULL,
	ma_san_pham       VARCHAR(20) NOT NULL,
	so_luong          INT NOT NULL,
	gia_nhap          DECIMAL(15,2) NOT NULL,
	thanh_tien        DECIMAL(15,2) NOT NULL,
	CONSTRAINT PK_chi_tiet_phieu_nhap PRIMARY KEY (ma_phieu_nhap, ma_san_pham),
	CONSTRAINT FK_ctpn_phieu_nhap FOREIGN KEY (ma_phieu_nhap)
		REFERENCES dbo.phieu_nhap_hang(ma_phieu_nhap)
		ON UPDATE CASCADE
		ON DELETE CASCADE,
	CONSTRAINT FK_ctpn_san_pham FOREIGN KEY (ma_san_pham)
		REFERENCES dbo.san_pham(ma_san_pham)
		ON UPDATE CASCADE
		ON DELETE NO ACTION,
	CONSTRAINT CHK_ctpn_so_luong CHECK (so_luong > 0),
	CONSTRAINT CHK_ctpn_gia_nhap CHECK (gia_nhap >= 0),
	CONSTRAINT CHK_ctpn_thanh_tien CHECK (thanh_tien >= 0)
);
GO

CREATE TABLE dbo.giam_gia (
	ma_giam_gia       VARCHAR(20) NOT NULL,
	phan_tram_giam    DECIMAL(5,2) NOT NULL CONSTRAINT DF_gg_phan_tram_giam DEFAULT (0),
	so_tien_giam      DECIMAL(15,2) NOT NULL CONSTRAINT DF_gg_so_tien_giam DEFAULT (0),
	so_luong_su_dung  INT NOT NULL CONSTRAINT DF_gg_so_luong_su_dung DEFAULT (0),
	ngay_bat_dau      DATETIME2(0) NOT NULL,
	ngay_ket_thuc     DATETIME2(0) NOT NULL,
	trang_thai        VARCHAR(20) NOT NULL CONSTRAINT DF_gg_trang_thai DEFAULT ('ACTIVE'),
	CONSTRAINT PK_giam_gia PRIMARY KEY (ma_giam_gia),
	CONSTRAINT CHK_gg_phan_tram CHECK (phan_tram_giam BETWEEN 0 AND 100),
	CONSTRAINT CHK_gg_so_tien CHECK (so_tien_giam >= 0),
	CONSTRAINT CHK_gg_so_luong CHECK (so_luong_su_dung >= 0),
	CONSTRAINT CHK_gg_ngay CHECK (ngay_ket_thuc >= ngay_bat_dau),
	CONSTRAINT CHK_gg_trang_thai CHECK (trang_thai IN ('ACTIVE', 'INACTIVE', 'EXPIRED'))
);
GO

CREATE TABLE dbo.khach_hang (
	ma_khach_hang     VARCHAR(20) NOT NULL,
	ten_khach_hang    NVARCHAR(150) NOT NULL,
	so_dien_thoai     VARCHAR(20) NULL,
	dia_chi           NVARCHAR(255) NULL,
	CONSTRAINT PK_khach_hang PRIMARY KEY (ma_khach_hang)
);
GO

CREATE TABLE dbo.hoa_don (
	ma_hoa_don        VARCHAR(20) NOT NULL,
	ngay_gio_ban      DATETIME2(0) NOT NULL CONSTRAINT DF_hd_ngay_gio_ban DEFAULT (SYSDATETIME()),
	tong_tien         DECIMAL(15,2) NOT NULL,
	ma_nhan_vien      VARCHAR(20) NOT NULL,
	ma_khach_hang     VARCHAR(20) NULL,
	ma_giam_gia       VARCHAR(20) NULL,
	giam_gia          DECIMAL(15,2) NOT NULL CONSTRAINT DF_hd_giam_gia DEFAULT (0),
	thanh_tien_cuoi   DECIMAL(15,2) NOT NULL,
	CONSTRAINT PK_hoa_don PRIMARY KEY (ma_hoa_don),
	CONSTRAINT FK_hd_nhan_vien FOREIGN KEY (ma_nhan_vien)
		REFERENCES dbo.nhan_vien(ma_nhan_vien)
		ON UPDATE CASCADE
		ON DELETE NO ACTION,
	CONSTRAINT FK_hd_khach_hang FOREIGN KEY (ma_khach_hang)
		REFERENCES dbo.khach_hang(ma_khach_hang)
		ON UPDATE CASCADE
		ON DELETE SET NULL,
	CONSTRAINT FK_hd_giam_gia FOREIGN KEY (ma_giam_gia)
		REFERENCES dbo.giam_gia(ma_giam_gia)
		ON UPDATE CASCADE
		ON DELETE SET NULL,
	CONSTRAINT CHK_hd_tong_tien CHECK (tong_tien >= 0),
	CONSTRAINT CHK_hd_giam_gia CHECK (giam_gia >= 0),
	CONSTRAINT CHK_hd_thanh_tien_cuoi CHECK (thanh_tien_cuoi >= 0)
);
GO

CREATE TABLE dbo.chi_tiet_hoa_don (
	ma_hoa_don        VARCHAR(20) NOT NULL,
	ma_san_pham       VARCHAR(20) NOT NULL,
	so_luong          INT NOT NULL,
	don_gia           DECIMAL(15,2) NOT NULL,
	thanh_tien        DECIMAL(15,2) NOT NULL,
	CONSTRAINT PK_chi_tiet_hoa_don PRIMARY KEY (ma_hoa_don, ma_san_pham),
	CONSTRAINT FK_cthd_hoa_don FOREIGN KEY (ma_hoa_don)
		REFERENCES dbo.hoa_don(ma_hoa_don)
		ON UPDATE CASCADE
		ON DELETE CASCADE,
	CONSTRAINT FK_cthd_san_pham FOREIGN KEY (ma_san_pham)
		REFERENCES dbo.san_pham(ma_san_pham)
		ON UPDATE CASCADE
		ON DELETE NO ACTION,
	CONSTRAINT CHK_cthd_so_luong CHECK (so_luong > 0),
	CONSTRAINT CHK_cthd_don_gia CHECK (don_gia >= 0),
	CONSTRAINT CHK_cthd_thanh_tien CHECK (thanh_tien >= 0)
);
GO

-- Index cho cot khoa ngoai de truy van nhanh hon
CREATE INDEX IX_nv_ma_tai_khoan ON dbo.nhan_vien(ma_tai_khoan);
CREATE INDEX IX_sp_ma_danh_muc ON dbo.san_pham(ma_danh_muc);
CREATE INDEX IX_pnh_ma_nha_cung_cap ON dbo.phieu_nhap_hang(ma_nha_cung_cap);
CREATE INDEX IX_pnh_ma_nhan_vien ON dbo.phieu_nhap_hang(ma_nhan_vien);
CREATE INDEX IX_ctpn_ma_san_pham ON dbo.chi_tiet_phieu_nhap(ma_san_pham);
CREATE INDEX IX_hd_ma_nhan_vien ON dbo.hoa_don(ma_nhan_vien);
CREATE INDEX IX_hd_ma_khach_hang ON dbo.hoa_don(ma_khach_hang);
CREATE INDEX IX_hd_ma_giam_gia ON dbo.hoa_don(ma_giam_gia);
CREATE INDEX IX_cthd_ma_san_pham ON dbo.chi_tiet_hoa_don(ma_san_pham);
GO
