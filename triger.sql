alter trigger trg_ChiTietHoaDon on ChiTietHoaDon
After insert as
begin 
	update NuocHoa
	set NuocHoa.SoLuongHienTai = NuocHoa.SoLuongHienTai - 
	( select inserted.SoLuong from inserted
	where MaNuocHoa = NuocHoa.MaNuocHoa)
	from NuocHoa join inserted on inserted.MaNuocHoa = NuocHoa.MaNuocHoa
end

insert into HoaDon(TenKhachHang, SdtKhachHang, NgayLap) values('Nguyen Van Toan', 03434343, GETDATE())
insert into ChiTietHoaDon values('CoWaWo30',2,650000)