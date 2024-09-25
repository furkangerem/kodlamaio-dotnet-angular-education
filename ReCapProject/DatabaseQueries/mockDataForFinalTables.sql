INSERT INTO Users (FirstName, LastName, Email, Password) VALUES
('Ahmet', 'Yılmaz', 'ahmet.yilmaz@example.com', 'securePassword1'),
('Fatma', 'Demir', 'fatma.demir@example.com', 'securePassword2'),
('Mehmet', 'Kaya', 'mehmet.kaya@example.com', 'securePassword3');

INSERT INTO Customers (UserId, CompanyName) VALUES
(1, 'Yılmaz Otomotiv'),
(2, 'Demir İnşaat'),
(3, 'Kaya Elektronik');

INSERT INTO Brand (Name) VALUES
('Toyota'),
('Ford'),
('BMW');

INSERT INTO Color (Name) VALUES
('Kırmızı'),
('Mavi'),
('Siyah');

INSERT INTO Car (Name, BrandId, ColorId, ModelYear, DailyPrice, Description) VALUES
('Corolla', 1, 1, 2022, 150.00, 'Hızlı ve güvenilir bir sedan.'),
('Focus', 2, 2, 2021, 120.00, 'Sportif tasarımı ile dikkat çekiyor.'),
('3 Serisi', 3, 3, 2020, 250.00, 'Lüks ve performans odaklı bir araç.');

INSERT INTO Rentals (CarId, CustomerId, RentDate, ReturnDate) VALUES
(1, 1, '2024-09-01', '2024-09-10'),
(2, 2, '2024-09-05', NULL),
(3, 3, '2024-09-07', '2024-09-14');