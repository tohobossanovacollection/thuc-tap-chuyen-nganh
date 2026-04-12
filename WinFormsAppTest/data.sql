INSERT INTO dbo.tai_khoan (ma_tai_khoan, ten_dang_nhap, mat_khau, quyen_han)
VALUES
('TK20260405220220887', 'levents', 'h$c4122005', 'ADMIN'),
('TK20260405220220888', 'user02', 'hash02', 'ADMIN'),
('TK20260405220220889', 'user03', 'hash03', 'QUAN_LY'),
('TK20260405220220890', 'user04', 'hash04', 'QUAN_LY'),
('TK20260405220220891', 'user05', 'hash05', 'QUAN_LY'),
('TK20260405220220892', 'user06', 'hash06', 'QUAN_LY'),
('TK20260405220220893', 'user07', 'hash07', 'NHAN_VIEN'),
('TK20260405220220894', 'user08', 'hash08', 'NHAN_VIEN'),
('TK20260405220220895', 'user09', 'hash09', 'NHAN_VIEN'),
('TK20260405220220896', 'user10', 'hash10', 'NHAN_VIEN'),
('TK20260405220220897', 'user11', 'hash11', 'NHAN_VIEN'),
('TK20260405220220898', 'user12', 'hash12', 'NHAN_VIEN'),
('TK20260405220220899', 'user13', 'hash13', 'NHAN_VIEN'),
('TK20260405220220900', 'user14', 'hash14', 'NHAN_VIEN'),
('TK20260405220220901', 'user15', 'hash15', 'NHAN_VIEN'),
('TK20260405220220902', 'user16', 'hash16', 'NHAN_VIEN'),
('TK20260405220220903', 'user17', 'hash17', 'NHAN_VIEN'),
('TK20260405220220904', 'user18', 'hash18', 'NHAN_VIEN'),
('TK20260405220220905', 'user19', 'hash19', 'NHAN_VIEN'),
('TK20260405220220906', 'user20', 'hash20', 'NHAN_VIEN');
GO

INSERT INTO dbo.nhan_vien
(ma_nhan_vien, ma_tai_khoan, ho_ten, ngay_sinh, dia_chi, so_dien_thoai, email, chuc_vu, phong_ban, trang_thai)
VALUES
('NV001', 'TK20260405220220887', N'Nhan Vien 01', '1990-01-01', N'Dia chi 01', '0901000001', 'nv01@example.com', N'Giam doc', N'Ban quan ly', 'ACTIVE'),
('NV002', 'TK20260405220220888', N'Nhan Vien 02', '1990-02-02', N'Dia chi 02', '0901000002', 'nv02@example.com', N'Pho giam doc', N'Ban quan ly', 'ACTIVE'),
('NV003', 'TK20260405220220889', N'Nhan Vien 03', '1991-03-03', N'Dia chi 03', '0901000003', 'nv03@example.com', N'Truong phong', N'Kinh doanh', 'ACTIVE'),
('NV004', 'TK20260405220220890', N'Nhan Vien 04', '1991-04-04', N'Dia chi 04', '0901000004', 'nv04@example.com', N'Truong phong', N'Ke toan', 'ACTIVE'),
('NV005', 'TK20260405220220891', N'Nhan Vien 05', '1992-05-05', N'Dia chi 05', '0901000005', 'nv05@example.com', N'Quan ly cua hang', N'Ban hang', 'ACTIVE'),
('NV006', 'TK20260405220220892', N'Nhan Vien 06', '1992-06-06', N'Dia chi 06', '0901000006', 'nv06@example.com', N'Quan ly kho', N'Kho', 'ACTIVE'),
('NV007', 'TK20260405220220893', N'Nhan Vien 07', '1993-07-07', N'Dia chi 07', '0901000007', 'nv07@example.com', N'Nhan vien', N'Ban hang', 'ACTIVE'),
('NV008', 'TK20260405220220894', N'Nhan Vien 08', '1993-08-08', N'Dia chi 08', '0901000008', 'nv08@example.com', N'Nhan vien', N'Ban hang', 'ACTIVE'),
('NV009', 'TK20260405220220895', N'Nhan Vien 09', '1994-09-09', N'Dia chi 09', '0901000009', 'nv09@example.com', N'Nhan vien', N'Ke toan', 'ACTIVE'),
('NV010', 'TK20260405220220896', N'Nhan Vien 10', '1994-10-10', N'Dia chi 10', '0901000010', 'nv10@example.com', N'Nhan vien', N'Kho', 'ACTIVE'),
('NV011', 'TK20260405220220897', N'Nhan Vien 11', '1995-11-11', N'Dia chi 11', '0901000011', 'nv11@example.com', N'Nhan vien', N'Ban hang', 'ACTIVE'),
('NV012', 'TK20260405220220898', N'Nhan Vien 12', '1995-12-12', N'Dia chi 12', '0901000012', 'nv12@example.com', N'Nhan vien', N'Ban hang', 'ACTIVE'),
('NV013', 'TK20260405220220899', N'Nhan Vien 13', '1996-01-13', N'Dia chi 13', '0901000013', 'nv13@example.com', N'Nhan vien', N'Kho', 'ACTIVE'),
('NV014', 'TK20260405220220900', N'Nhan Vien 14', '1996-02-14', N'Dia chi 14', '0901000014', 'nv14@example.com', N'Nhan vien', N'Ke toan', 'ACTIVE'),
('NV015', 'TK20260405220220901', N'Nhan Vien 15', '1997-03-15', N'Dia chi 15', '0901000015', 'nv15@example.com', N'Nhan vien', N'Ban hang', 'ACTIVE'),
('NV016', 'TK20260405220220902', N'Nhan Vien 16', '1997-04-16', N'Dia chi 16', '0901000016', 'nv16@example.com', N'Nhan vien', N'Ban hang', 'ACTIVE'),
('NV017', 'TK20260405220220903', N'Nhan Vien 17', '1998-05-17', N'Dia chi 17', '0901000017', 'nv17@example.com', N'Nhan vien', N'Kho', 'ACTIVE'),
('NV018', 'TK20260405220220904', N'Nhan Vien 18', '1998-06-18', N'Dia chi 18', '0901000018', 'nv18@example.com', N'Nhan vien', N'Ke toan', 'ACTIVE'),
('NV019', 'TK20260405220220905', N'Nhan Vien 19', '1999-07-19', N'Dia chi 19', '0901000019', 'nv19@example.com', N'Nhan vien', N'Ban hang', 'ACTIVE'),
('NV020', 'TK20260405220220906', N'Nhan Vien 20', '1999-08-20', N'Dia chi 20', '0901000020', 'nv20@example.com', N'Nhan vien', N'Ban hang', 'INACTIVE');
GO

INSERT INTO dbo.nha_cung_cap (ma_nha_cung_cap, ten_nha_cung_cap, so_dien_thoai, dia_chi, email)
VALUES
('NCC001', 'Nha cung cap 01', '0911000001', N'Dia chi NCC 01', 'ncc01@example.com'),
('NCC002', 'Nha cung cap 02', '0911000002', N'Dia chi NCC 02', 'ncc02@example.com'),
('NCC003', 'Nha cung cap 03', '0911000003', N'Dia chi NCC 03', 'ncc03@example.com'),
('NCC004', 'Nha cung cap 04', '0911000004', N'Dia chi NCC 04', 'ncc04@example.com'),
('NCC005', 'Nha cung cap 05', '0911000005', N'Dia chi NCC 05', 'ncc05@example.com'),
('NCC006', 'Nha cung cap 06', '0911000006', N'Dia chi NCC 06', 'ncc06@example.com'),
('NCC007', 'Nha cung cap 07', '0911000007', N'Dia chi NCC 07', 'ncc07@example.com'),
('NCC008', 'Nha cung cap 08', '0911000008', N'Dia chi NCC 08', 'ncc08@example.com'),
('NCC009', 'Nha cung cap 09', '0911000009', N'Dia chi NCC 09', 'ncc09@example.com'),
('NCC010', 'Nha cung cap 10', '0911000010', N'Dia chi NCC 10', 'ncc10@example.com'),
('NCC011', 'Nha cung cap 11', '0911000011', N'Dia chi NCC 11', 'ncc11@example.com'),
('NCC012', 'Nha cung cap 12', '0911000012', N'Dia chi NCC 12', 'ncc12@example.com'),
('NCC013', 'Nha cung cap 13', '0911000013', N'Dia chi NCC 13', 'ncc13@example.com'),
('NCC014', 'Nha cung cap 14', '0911000014', N'Dia chi NCC 14', 'ncc14@example.com'),
('NCC015', 'Nha cung cap 15', '0911000015', N'Dia chi NCC 15', 'ncc15@example.com'),
('NCC016', 'Nha cung cap 16', '0911000016', N'Dia chi NCC 16', 'ncc16@example.com'),
('NCC017', 'Nha cung cap 17', '0911000017', N'Dia chi NCC 17', 'ncc17@example.com'),
('NCC018', 'Nha cung cap 18', '0911000018', N'Dia chi NCC 18', 'ncc18@example.com'),
('NCC019', 'Nha cung cap 19', '0911000019', N'Dia chi NCC 19', 'ncc19@example.com'),
('NCC020', 'Nha cung cap 20', '0911000020', N'Dia chi NCC 20', 'ncc20@example.com');
GO

INSERT INTO dbo.danh_muc_san_pham (ma_danh_muc, ten_danh_muc)
VALUES
('DM001', N'Danh muc 01'),
('DM002', N'Danh muc 02'),
('DM003', N'Danh muc 03'),
('DM004', N'Danh muc 04'),
('DM005', N'Danh muc 05'),
('DM006', N'Danh muc 06'),
('DM007', N'Danh muc 07'),
('DM008', N'Danh muc 08'),
('DM009', N'Danh muc 09'),
('DM010', N'Danh muc 10'),
('DM011', N'Danh muc 11'),
('DM012', N'Danh muc 12'),
('DM013', N'Danh muc 13'),
('DM014', N'Danh muc 14'),
('DM015', N'Danh muc 15'),
('DM016', N'Danh muc 16'),
('DM017', N'Danh muc 17'),
('DM018', N'Danh muc 18'),
('DM019', N'Danh muc 19'),
('DM020', N'Danh muc 20');
GO

INSERT INTO dbo.san_pham
(ma_san_pham, ma_danh_muc, ten_san_pham, gia_nhap, gia_ban, so_luong_ton, mo_ta_san_pham)
VALUES
('SP001', 'DM001', N'San pham 01', 52500.00, 67500.00, 120, N'Mo ta san pham 01'),
('SP002', 'DM002', N'San pham 02', 55000.00, 70000.00, 118, N'Mo ta san pham 02'),
('SP003', 'DM003', N'San pham 03', 57500.00, 72500.00, 116, N'Mo ta san pham 03'),
('SP004', 'DM004', N'San pham 04', 60000.00, 75000.00, 114, N'Mo ta san pham 04'),
('SP005', 'DM005', N'San pham 05', 62500.00, 77500.00, 112, N'Mo ta san pham 05'),
('SP006', 'DM006', N'San pham 06', 65000.00, 80000.00, 110, N'Mo ta san pham 06'),
('SP007', 'DM007', N'San pham 07', 67500.00, 82500.00, 108, N'Mo ta san pham 07'),
('SP008', 'DM008', N'San pham 08', 70000.00, 85000.00, 106, N'Mo ta san pham 08'),
('SP009', 'DM009', N'San pham 09', 72500.00, 87500.00, 104, N'Mo ta san pham 09'),
('SP010', 'DM010', N'San pham 10', 75000.00, 90000.00, 102, N'Mo ta san pham 10'),
('SP011', 'DM011', N'San pham 11', 77500.00, 92500.00, 100, N'Mo ta san pham 11'),
('SP012', 'DM012', N'San pham 12', 80000.00, 95000.00, 98, N'Mo ta san pham 12'),
('SP013', 'DM013', N'San pham 13', 82500.00, 97500.00, 96, N'Mo ta san pham 13'),
('SP014', 'DM014', N'San pham 14', 85000.00, 100000.00, 94, N'Mo ta san pham 14'),
('SP015', 'DM015', N'San pham 15', 87500.00, 102500.00, 92, N'Mo ta san pham 15'),
('SP016', 'DM016', N'San pham 16', 90000.00, 105000.00, 90, N'Mo ta san pham 16'),
('SP017', 'DM017', N'San pham 17', 92500.00, 107500.00, 88, N'Mo ta san pham 17'),
('SP018', 'DM018', N'San pham 18', 95000.00, 110000.00, 86, N'Mo ta san pham 18'),
('SP019', 'DM019', N'San pham 19', 97500.00, 112500.00, 84, N'Mo ta san pham 19'),
('SP020', 'DM020', N'San pham 20', 100000.00, 115000.00, 82, N'Mo ta san pham 20');
GO

INSERT INTO dbo.giam_gia
(ma_giam_gia, phan_tram_giam, so_tien_giam, so_luong_su_dung, ngay_bat_dau, ngay_ket_thuc, trang_thai)
VALUES
('GG001', 0.00, 5000.00, 10, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'ACTIVE'),
('GG002', 0.00, 7000.00, 15, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'ACTIVE'),
('GG003', 0.00, 8000.00, 12, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'ACTIVE'),
('GG004', 0.00, 9000.00, 9, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'ACTIVE'),
('GG005', 0.00, 10000.00, 8, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'ACTIVE'),
('GG006', 0.00, 11000.00, 7, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'ACTIVE'),
('GG007', 0.00, 12000.00, 6, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'ACTIVE'),
('GG008', 0.00, 13000.00, 5, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'ACTIVE'),
('GG009', 0.00, 14000.00, 4, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'ACTIVE'),
('GG010', 0.00, 15000.00, 3, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'ACTIVE'),
('GG011', 5.00, 0.00, 20, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'INACTIVE'),
('GG012', 10.00, 0.00, 18, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'INACTIVE'),
('GG013', 15.00, 0.00, 16, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'INACTIVE'),
('GG014', 20.00, 0.00, 14, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'INACTIVE'),
('GG015', 25.00, 0.00, 12, '2026-01-01 00:00:00', '2026-12-31 23:59:59', 'INACTIVE'),
('GG016', 0.00, 5000.00, 11, '2025-01-01 00:00:00', '2025-12-31 23:59:59', 'EXPIRED'),
('GG017', 0.00, 6000.00, 10, '2025-01-01 00:00:00', '2025-12-31 23:59:59', 'EXPIRED'),
('GG018', 0.00, 7000.00, 9, '2025-01-01 00:00:00', '2025-12-31 23:59:59', 'EXPIRED'),
('GG019', 0.00, 8000.00, 8, '2025-01-01 00:00:00', '2025-12-31 23:59:59', 'EXPIRED'),
('GG020', 0.00, 9000.00, 7, '2025-01-01 00:00:00', '2025-12-31 23:59:59', 'EXPIRED');
GO

INSERT INTO dbo.khach_hang (ma_khach_hang, ten_khach_hang, so_dien_thoai, dia_chi)
VALUES
('KH001', N'Khach hang 01', '0922000001', N'Dia chi KH 01'),
('KH002', N'Khach hang 02', '0922000002', N'Dia chi KH 02'),
('KH003', N'Khach hang 03', '0922000003', N'Dia chi KH 03'),
('KH004', N'Khach hang 04', '0922000004', N'Dia chi KH 04'),
('KH005', N'Khach hang 05', '0922000005', N'Dia chi KH 05'),
('KH006', N'Khach hang 06', '0922000006', N'Dia chi KH 06'),
('KH007', N'Khach hang 07', '0922000007', N'Dia chi KH 07'),
('KH008', N'Khach hang 08', '0922000008', N'Dia chi KH 08'),
('KH009', N'Khach hang 09', '0922000009', N'Dia chi KH 09'),
('KH010', N'Khach hang 10', '0922000010', N'Dia chi KH 10'),
('KH011', N'Khach hang 11', '0922000011', N'Dia chi KH 11'),
('KH012', N'Khach hang 12', '0922000012', N'Dia chi KH 12'),
('KH013', N'Khach hang 13', '0922000013', N'Dia chi KH 13'),
('KH014', N'Khach hang 14', '0922000014', N'Dia chi KH 14'),
('KH015', N'Khach hang 15', '0922000015', N'Dia chi KH 15'),
('KH016', N'Khach hang 16', '0922000016', N'Dia chi KH 16'),
('KH017', N'Khach hang 17', '0922000017', N'Dia chi KH 17'),
('KH018', N'Khach hang 18', '0922000018', N'Dia chi KH 18'),
('KH019', N'Khach hang 19', '0922000019', N'Dia chi KH 19'),
('KH020', N'Khach hang 20', '0922000020', N'Dia chi KH 20');
GO

INSERT INTO dbo.phieu_nhap_hang (ma_phieu_nhap, ngay_nhap, tong_tien, ma_nha_cung_cap, ma_nhan_vien)
VALUES
('PNH001', '2026-01-01 09:00:00', 525000.00, 'NCC001', 'NV001'),
('PNH002', '2026-01-02 09:00:00', 550000.00, 'NCC002', 'NV002'),
('PNH003', '2026-01-03 09:00:00', 575000.00, 'NCC003', 'NV003'),
('PNH004', '2026-01-04 09:00:00', 600000.00, 'NCC004', 'NV004'),
('PNH005', '2026-01-05 09:00:00', 625000.00, 'NCC005', 'NV005'),
('PNH006', '2026-01-06 09:00:00', 650000.00, 'NCC006', 'NV006'),
('PNH007', '2026-01-07 09:00:00', 675000.00, 'NCC007', 'NV007'),
('PNH008', '2026-01-08 09:00:00', 700000.00, 'NCC008', 'NV008'),
('PNH009', '2026-01-09 09:00:00', 725000.00, 'NCC009', 'NV009'),
('PNH010', '2026-01-10 09:00:00', 750000.00, 'NCC010', 'NV010'),
('PNH011', '2026-01-11 09:00:00', 775000.00, 'NCC011', 'NV011'),
('PNH012', '2026-01-12 09:00:00', 800000.00, 'NCC012', 'NV012'),
('PNH013', '2026-01-13 09:00:00', 825000.00, 'NCC013', 'NV013'),
('PNH014', '2026-01-14 09:00:00', 850000.00, 'NCC014', 'NV014'),
('PNH015', '2026-01-15 09:00:00', 875000.00, 'NCC015', 'NV015'),
('PNH016', '2026-01-16 09:00:00', 900000.00, 'NCC016', 'NV016'),
('PNH017', '2026-01-17 09:00:00', 925000.00, 'NCC017', 'NV017'),
('PNH018', '2026-01-18 09:00:00', 950000.00, 'NCC018', 'NV018'),
('PNH019', '2026-01-19 09:00:00', 975000.00, 'NCC019', 'NV019'),
('PNH020', '2026-01-20 09:00:00', 1000000.00, 'NCC020', 'NV020');
GO

INSERT INTO dbo.chi_tiet_phieu_nhap
(ma_phieu_nhap, ma_san_pham, so_luong, gia_nhap, thanh_tien)
VALUES
('PNH001', 'SP001', 10, 52500.00, 525000.00),
('PNH002', 'SP002', 10, 55000.00, 550000.00),
('PNH003', 'SP003', 10, 57500.00, 575000.00),
('PNH004', 'SP004', 10, 60000.00, 600000.00),
('PNH005', 'SP005', 10, 62500.00, 625000.00),
('PNH006', 'SP006', 10, 65000.00, 650000.00),
('PNH007', 'SP007', 10, 67500.00, 675000.00),
('PNH008', 'SP008', 10, 70000.00, 700000.00),
('PNH009', 'SP009', 10, 72500.00, 725000.00),
('PNH010', 'SP010', 10, 75000.00, 750000.00),
('PNH011', 'SP011', 10, 77500.00, 775000.00),
('PNH012', 'SP012', 10, 80000.00, 800000.00),
('PNH013', 'SP013', 10, 82500.00, 825000.00),
('PNH014', 'SP014', 10, 85000.00, 850000.00),
('PNH015', 'SP015', 10, 87500.00, 875000.00),
('PNH016', 'SP016', 10, 90000.00, 900000.00),
('PNH017', 'SP017', 10, 92500.00, 925000.00),
('PNH018', 'SP018', 10, 95000.00, 950000.00),
('PNH019', 'SP019', 10, 97500.00, 975000.00),
('PNH020', 'SP020', 10, 100000.00, 1000000.00);
GO

INSERT INTO dbo.hoa_don
(ma_hoa_don, ngay_gio_ban, tong_tien, ma_nhan_vien, ma_khach_hang, ma_giam_gia, giam_gia, thanh_tien_cuoi)
VALUES
('HD001', '2026-04-01 10:00:00', 67500.00, 'NV007', 'KH001', 'GG001', 5000.00, 62500.00),
('HD002', '2026-04-02 10:00:00', 70000.00, 'NV008', 'KH002', 'GG002', 7000.00, 63000.00),
('HD003', '2026-04-03 10:00:00', 72500.00, 'NV009', 'KH003', 'GG003', 8000.00, 64500.00),
('HD004', '2026-04-04 10:00:00', 75000.00, 'NV010', 'KH004', 'GG004', 9000.00, 66000.00),
('HD005', '2026-04-05 10:00:00', 77500.00, 'NV011', 'KH005', 'GG005', 10000.00, 67500.00),
('HD006', '2026-04-06 10:00:00', 80000.00, 'NV012', 'KH006', 'GG006', 11000.00, 69000.00),
('HD007', '2026-04-07 10:00:00', 82500.00, 'NV013', 'KH007', 'GG007', 12000.00, 70500.00),
('HD008', '2026-04-08 10:00:00', 85000.00, 'NV014', 'KH008', 'GG008', 13000.00, 72000.00),
('HD009', '2026-04-09 10:00:00', 87500.00, 'NV015', 'KH009', 'GG009', 14000.00, 73500.00),
('HD010', '2026-04-10 10:00:00', 90000.00, 'NV016', 'KH010', 'GG010', 15000.00, 75000.00),
('HD011', '2026-04-11 10:00:00', 92500.00, 'NV017', 'KH011', NULL, 0.00, 92500.00),
('HD012', '2026-04-12 10:00:00', 95000.00, 'NV018', 'KH012', NULL, 0.00, 95000.00),
('HD013', '2026-04-13 10:00:00', 97500.00, 'NV019', 'KH013', NULL, 0.00, 97500.00),
('HD014', '2026-04-14 10:00:00', 100000.00, 'NV020', 'KH014', NULL, 0.00, 100000.00),
('HD015', '2026-04-15 10:00:00', 102500.00, 'NV001', 'KH015', NULL, 0.00, 102500.00),
('HD016', '2026-04-16 10:00:00', 105000.00, 'NV002', 'KH016', NULL, 0.00, 105000.00),
('HD017', '2026-04-17 10:00:00', 107500.00, 'NV003', 'KH017', NULL, 0.00, 107500.00),
('HD018', '2026-04-18 10:00:00', 110000.00, 'NV004', 'KH018', NULL, 0.00, 110000.00),
('HD019', '2026-04-19 10:00:00', 112500.00, 'NV005', 'KH019', NULL, 0.00, 112500.00),
('HD020', '2026-04-20 10:00:00', 115000.00, 'NV006', 'KH020', NULL, 0.00, 115000.00);
GO

INSERT INTO dbo.chi_tiet_hoa_don
(ma_hoa_don, ma_san_pham, so_luong, don_gia, thanh_tien)
VALUES
('HD001', 'SP001', 1, 67500.00, 67500.00),
('HD002', 'SP002', 1, 70000.00, 70000.00),
('HD003', 'SP003', 1, 72500.00, 72500.00),
('HD004', 'SP004', 1, 75000.00, 75000.00),
('HD005', 'SP005', 1, 77500.00, 77500.00),
('HD006', 'SP006', 1, 80000.00, 80000.00),
('HD007', 'SP007', 1, 82500.00, 82500.00),
('HD008', 'SP008', 1, 85000.00, 85000.00),
('HD009', 'SP009', 1, 87500.00, 87500.00),
('HD010', 'SP010', 1, 90000.00, 90000.00),
('HD011', 'SP011', 1, 92500.00, 92500.00),
('HD012', 'SP012', 1, 95000.00, 95000.00),
('HD013', 'SP013', 1, 97500.00, 97500.00),
('HD014', 'SP014', 1, 100000.00, 100000.00),
('HD015', 'SP015', 1, 102500.00, 102500.00),
('HD016', 'SP016', 1, 105000.00, 105000.00),
('HD017', 'SP017', 1, 107500.00, 107500.00),
('HD018', 'SP018', 1, 110000.00, 110000.00),
('HD019', 'SP019', 1, 112500.00, 112500.00),
('HD020', 'SP020', 1, 115000.00, 115000.00);
GO
