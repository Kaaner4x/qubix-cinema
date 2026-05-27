USE QubixCinemaDB;
GO

SET NOCOUNT ON;
PRINT 'Real-World English Cinema Data Seeding Started...';

-- Clear existing data (order is critical due to foreign keys)
PRINT 'Clearing existing records...';
DELETE FROM dbo.Register;
DELETE FROM dbo.Reservations;
DELETE FROM dbo.Seats;
DELETE FROM dbo.Customers;
DELETE FROM dbo.Movies;

-- Reset identity seeds
DBCC CHECKIDENT ('dbo.Register', RESEED, 0);
DBCC CHECKIDENT ('dbo.Reservations', RESEED, 0);
DBCC CHECKIDENT ('dbo.Seats', RESEED, 0);
DBCC CHECKIDENT ('dbo.Customers', RESEED, 0);
DBCC CHECKIDENT ('dbo.Movies', RESEED, 0);

-- 1. Create a Pool of Real-World Master Movie Titles, Genres, and Runtimes
PRINT 'Seeding 200 Real-World English Movies...';
DECLARE @MoviePool TABLE (
    Id INT IDENTITY(1,1),
    Title VARCHAR(100),
    Genre VARCHAR(50),
    Runtime INT
);

INSERT INTO @MoviePool (Title, Genre, Runtime) VALUES
('Inception', 'Sci-Fi', 148),
('The Dark Knight', 'Action', 152),
('Interstellar', 'Sci-Fi', 169),
('Gladiator', 'Drama', 155),
('Pulp Fiction', 'Drama', 154),
('The Matrix', 'Action', 136),
('The Godfather', 'Drama', 175),
('Titanic', 'Drama', 194),
('Joker', 'Drama', 122),
('Avengers: Endgame', 'Action', 181),
('The Lion King', 'Comedy', 118),
('Jurassic Park', 'Sci-Fi', 127),
('Forrest Gump', 'Drama', 142),
('Spirited Away', 'Horror', 125),
('Whiplash', 'Drama', 106),
('Parasite', 'Drama', 132),
('Star Wars: A New Hope', 'Sci-Fi', 121),
('Coco', 'Comedy', 105),
('Toy Story', 'Comedy', 81),
('The Shawshank Redemption', 'Drama', 142),
('Fight Club', 'Action', 139),
('Se7en', 'Horror', 127),
('Django Unchained', 'Action', 165),
('The Prestige', 'Sci-Fi', 130),
('The Departed', 'Action', 151),
('Shutter Island', 'Horror', 138),
('Dunkirk', 'Action', 106),
('Blade Runner 2049', 'Sci-Fi', 164),
('The Martian', 'Sci-Fi', 144),
('Arrival', 'Sci-Fi', 116),
('Gravity', 'Sci-Fi', 91),
('Up', 'Comedy', 96),
('WALL-E', 'Sci-Fi', 98),
('Inside Out', 'Comedy', 95),
('Zootopia', 'Comedy', 108),
('Ratatouille', 'Comedy', 111),
('Finding Nemo', 'Comedy', 100),
('The Incredibles', 'Action', 115),
('Monsters, Inc.', 'Comedy', 92),
('The Green Mile', 'Drama', 189);

-- Distribute and generate 200 distinct movie records (blockbusters, sequels, re-releases, and VIP screenings)
DECLARE @m INT = 1;
DECLARE @titlePoolSize INT = 40;
WHILE @m <= 200
BEGIN
    DECLARE @poolIdx INT = ((@m - 1) % @titlePoolSize) + 1;
    DECLARE @rawTitle VARCHAR(100);
    DECLARE @rawGenre VARCHAR(50);
    DECLARE @rawRuntime INT;
    
    SELECT @rawTitle = Title, @rawGenre = Genre, @rawRuntime = Runtime 
    FROM @MoviePool WHERE Id = @poolIdx;
    
    -- Vary titles to look extremely realistic (e.g. sequels, years, 3D/IMAX re-releases)
    DECLARE @finalTitle VARCHAR(120);
    IF @m <= 40
        SET @finalTitle = @rawTitle;
    ELSE-IF @m <= 80
        SET @finalTitle = @rawTitle + ' - 3D Re-Release';
    ELSE-IF @m <= 120
        SET @finalTitle = @rawTitle + ' (IMAX Experience)';
    ELSE-IF @m <= 160
        SET @finalTitle = @rawTitle + ' II: Return of ' + CHOOSE((@m % 4) + 1, 'Hope', 'Fate', 'Justice', 'Shadows');
    ELSE
        SET @finalTitle = @rawTitle + ' (' + CAST(2023 + (@m % 4) AS VARCHAR) + ' Edition)';

    INSERT INTO dbo.Movies (MovieName, Genre, Runtime, ReleaseDate)
    VALUES (@finalTitle, @rawGenre, @rawRuntime + (@m % 15) - 7, DATEADD(DAY, -(@m * 4), GETDATE()));
    
    SET @m = @m + 1;
END
PRINT '200 Highly Realistic Movies Added.';

-- 2. Seeding 1000 Customers with Real-World First Names and Last Names (No Suffix Numbers!)
PRINT 'Seeding 1000 Realistic English Customers...';
DECLARE @FirstNames TABLE (Id INT IDENTITY(1,1), Name VARCHAR(50));
INSERT INTO @FirstNames (Name) VALUES 
('John'), ('Emma'), ('Liam'), ('Olivia'), ('Noah'), ('Ava'), ('William'), ('Sophia'), ('James'), ('Isabella'), 
('Oliver'), ('Charlotte'), ('Benjamin'), ('Amelia'), ('Lucas'), ('Mia'), ('Henry'), ('Harper'), ('Alexander'), ('Evelyn');

DECLARE @LastNames TABLE (Id INT IDENTITY(1,1), Name VARCHAR(50));
INSERT INTO @LastNames (Name) VALUES 
('Smith'), ('Johnson'), ('Williams'), ('Brown'), ('Jones'), ('Miller'), ('Davis'), ('Garcia'), ('Rodriguez'), ('Wilson'), 
('Martinez'), ('Anderson'), ('Taylor'), ('Thomas'), ('Hernandez'), ('Moore'), ('Martin'), ('Jackson'), ('Thompson'), ('White');

DECLARE @c INT = 1;
WHILE @c <= 1000
BEGIN
    DECLARE @fnIdx INT = ((@c - 1) % 20) + 1;
    DECLARE @lnIdx INT = ((@c * 7) % 20) + 1;
    DECLARE @midIdx INT = ((@c * 13) % 26) + 1;
    
    DECLARE @firstName VARCHAR(50);
    DECLARE @lastName VARCHAR(50);
    DECLARE @middleInit CHAR(1);
    
    SELECT @firstName = Name FROM @FirstNames WHERE Id = @fnIdx;
    SELECT @lastName = Name FROM @LastNames WHERE Id = @lnIdx;
    SET @middleInit = CHAR(64 + @midIdx); -- A to Z

    DECLARE @custFirst VARCHAR(80);
    IF @c % 3 = 0
        SET @custFirst = @firstName + ' ' + @middleInit + '.';
    ELSE
        SET @custFirst = @firstName;

    -- Emails are realistic corporate/personal emails
    DECLARE @email VARCHAR(100) = LOWER(@firstName) + '.' + LOWER(@lastName) + CAST(10 + (@c % 89) AS VARCHAR) + '@gmail.com';
    DECLARE @phone VARCHAR(50) = '+1 (555) ' + CAST(100 + (@c % 900) AS VARCHAR) + '-' + RIGHT('0000' + CAST(@c * 17 AS VARCHAR), 4);

    INSERT INTO dbo.Customers (CustomerFirstName, CustomerLastName, PhoneNumber, Email)
    VALUES (@custFirst, @lastName, @phone, @email);

    SET @c = @c + 1;
END
PRINT '1000 Realistic English Customers Seeded.';

-- 3. Seeding 1000 Seats across 20 Cinema Halls
PRINT 'Seeding 1000 Seats (20 Halls x 50 Seats)...';
DECLARE @h INT = 1;
DECLARE @s INT;
WHILE @h <= 20
BEGIN
    SET @s = 1;
    WHILE @s <= 50
    BEGIN
        INSERT INTO dbo.Seats (HallName, SerialNumber, SeatNumber, isBooked) 
        VALUES ('Hall ' + CHAR(64 + @h), (@s - 1) / 10 + 1, @s, 0);
        SET @s = @s + 1;
    END
    SET @h = @h + 1;
END
PRINT '1000 Seats Seeding Complete.';

-- 4. Seeding 5000 Reservations
PRINT 'Seeding 5000 English Reservations...';
DECLARE @r INT = 1;
DECLARE @randMovieId INT;
DECLARE @randCustomerId INT;
DECLARE @randSeatId INT;
WHILE @r <= 5000
BEGIN
    SET @randMovieId = (ABS(CHECKSUM(NEWID())) % 200) + 1;
    SET @randCustomerId = (ABS(CHECKSUM(NEWID())) % 1000) + 1;
    SET @randSeatId = (ABS(CHECKSUM(NEWID())) % 1000) + 1;
    
    INSERT INTO dbo.Reservations (MovieId, CustomerId, SeatId, ReservationDate) 
    VALUES (@randMovieId, @randCustomerId, @randSeatId, DATEADD(MINUTE, -(@r * 15), GETDATE()));
    
    SET @r = @r + 1;
END
PRINT '5000 Reservations Seeded Successfully.';

-- Synchronize isBooked statuses in Seats table
UPDATE dbo.Seats SET isBooked = 1 
WHERE SeatId IN (SELECT DISTINCT SeatId FROM dbo.Reservations);
PRINT 'Seats booking statuses synchronized.';

-- 5. Seeding 5000 Register Transactions (100% Real-World Food, Concessions, and Tickets)
PRINT 'Seeding 5000 Cash Register transactions (F&B / Tickets)...';
DECLARE @reg INT = 1;
DECLARE @amount MONEY;
DECLARE @desc VARCHAR(200);

-- Cache a list of movie names for ticket descriptions
DECLARE @MovieNames TABLE (Id INT IDENTITY(1,1), Name VARCHAR(120));
INSERT INTO @MovieNames (Name) SELECT MovieName FROM dbo.Movies;

WHILE @reg <= 5000
BEGIN
    IF @reg % 2 = 0
    BEGIN
        -- Ticket sales
        DECLARE @mName VARCHAR(120);
        SELECT @mName = Name FROM @MovieNames WHERE Id = ((@reg % 200) + 1);
        
        IF @reg % 5 = 0
        BEGIN
            SET @amount = 25.00; -- VIP lounge ticket
            SET @desc = 'VIP Ticket Sale - ' + @mName;
        END
        ELSE
        BEGIN
            SET @amount = 15.00; -- Standard ticket
            SET @desc = 'Standard Ticket Sale - ' + @mName;
        END
    END
    ELSE
    BEGIN
        -- Food & Beverage / Concession sales
        SET @amount = CHOOSE((@reg % 5) + 1, 12.50, 8.00, 18.50, 6.50, 22.00);
        SET @desc = CHOOSE((@reg % 5) + 1, 
            'Popcorn (Large) & Coca-Cola Combo', 
            'Nachos with Warm Cheese Dip', 
            'Premium Hot Dog & Beverage Combo', 
            'Double Sweet Treats Box (M&Ms & Skittles)', 
            'Ultimate Family Concession Basket');
    END
    
    INSERT INTO dbo.Register (Amount, Description, TransactionDate) 
    VALUES (@amount, @desc, DATEADD(MINUTE, -(@reg * 10), GETDATE()));
    
    SET @reg = @reg + 1;
END
PRINT '5000 Cash Register Transactions Added successfully.';

PRINT '100% REAL-WORLD CINEMA DATABASE SEEDING COMPLETED SUCCESSFULLY!';
