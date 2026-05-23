USE QubixCinemaDB;
GO

SET NOCOUNT ON;
PRINT 'Veri ekleme işlemi başladı, lütfen bekleyin...';

-- 1. Movies Tablosuna 200 Film Ekleme
DECLARE @m INT = 1;
WHILE @m <= 200
BEGIN
    INSERT INTO dbo.Movies (MovieName, Genre, Runtime, ReleaseDate) 
    VALUES ('Film ' + CAST(@m AS VARCHAR), 
            CHOOSE((@m % 5) + 1, 'Aksiyon', 'Bilim Kurgu', 'Drama', 'Komedi', 'Korku'),
            100 + (@m % 60), 
            DATEADD(DAY, -(@m * 10), GETDATE()));
    SET @m = @m + 1;
END
PRINT '200 Film Eklendi.';

-- 2. Customers Tablosuna 1000 Müşteri Ekleme
DECLARE @c INT = 1;
WHILE @c <= 1000
BEGIN
    INSERT INTO dbo.Customers (CustomerFirstName, CustomerLastName, PhoneNumber, Email) 
    VALUES ('MüşteriAd_' + CAST(@c AS VARCHAR), 
            'Soyad_' + CAST(@c AS VARCHAR), 
            '555' + RIGHT('0000000' + CAST(@c AS VARCHAR), 7), 
            'musteri' + CAST(@c AS VARCHAR) + '@example.com');
    SET @c = @c + 1;
END
PRINT '1000 Müşteri Eklendi.';

-- 3. Seats Tablosuna 1000 Koltuk Ekleme (20 Salon x 50 Koltuk)
DECLARE @h INT = 1; -- Salon Sayısı
DECLARE @s INT; -- Koltuk Sayısı
WHILE @h <= 20
BEGIN
    SET @s = 1;
    WHILE @s <= 50
    BEGIN
        -- Salon A'dan başlayarak isimlendirme (A, B, C...)
        INSERT INTO dbo.Seats (HallName, SerialNumber, SeatNumber, isBooked) 
        VALUES ('Salon ' + CHAR(64 + @h), (@s - 1) / 10 + 1, (@s - 1) % 10 + 1, 0);
        SET @s = @s + 1;
    END
    SET @h = @h + 1;
END
PRINT '1000 Koltuk Eklendi.';

-- 4. Reservations Tablosuna 5000 Rezervasyon Ekleme
DECLARE @r INT = 1;
DECLARE @randMovieId INT;
DECLARE @randCustomerId INT;
DECLARE @randSeatId INT;
WHILE @r <= 5000
BEGIN
    -- Rastgele ID'ler üret (Mevcut eklenenlerin ID aralığına göre)
    SET @randMovieId = (ABS(CHECKSUM(NEWID())) % 200) + 1;
    SET @randCustomerId = (ABS(CHECKSUM(NEWID())) % 1000) + 1;
    SET @randSeatId = (ABS(CHECKSUM(NEWID())) % 1000) + 1;
    
    INSERT INTO dbo.Reservations (MovieId, CustomerId, SeatId, ReservationDate) 
    VALUES (@randMovieId, @randCustomerId, @randSeatId, DATEADD(MINUTE, -(@r * 15), GETDATE()));
    
    SET @r = @r + 1;
END
PRINT '5000 Rezervasyon Eklendi.';

-- Rezerve edilen koltukları tespit edip isBooked = 1 olarak güncelle
UPDATE dbo.Seats SET isBooked = 1 
WHERE SeatId IN (SELECT DISTINCT SeatId FROM dbo.Reservations);
PRINT 'Koltuk doluluk durumları güncellendi.';

-- 5. Register Tablosuna 5000 Kasa Hareketi Ekleme
DECLARE @reg INT = 1;
WHILE @reg <= 5000
BEGIN
    INSERT INTO dbo.Register (Amount, Description, TransactionDate) 
    VALUES (
        50.00 + (ABS(CHECKSUM(NEWID())) % 200), -- 50 ile 250 arası rastgele fiyat
        'Otomatik Bilet/Ürün Satışı - İşlem ' + CAST(@reg AS VARCHAR), 
        DATEADD(MINUTE, -(@reg * 10), GETDATE())
    );
    SET @reg = @reg + 1;
END
PRINT '5000 Kasa Hareketi Eklendi.';

PRINT 'BÜYÜK HACİMLİ TEST VERİSİ EKLEME İŞLEMİ TAMAMLANDI!';
