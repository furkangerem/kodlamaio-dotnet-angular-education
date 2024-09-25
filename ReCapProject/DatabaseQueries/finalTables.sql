-- 1. Users tablosu: Kullanıcı bilgilerini tutar
CREATE TABLE Users (
    Id INT PRIMARY KEY IDENTITY(1,1),  -- Otomatik artan birincil anahtar
    FirstName NVARCHAR(50) NOT NULL,
    LastName NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,  -- Benzersiz email adresi
    Password NVARCHAR(255) NOT NULL  -- Parola için en az 255 karakter
);

-- 2. Customers tablosu: Müşteri bilgilerini tutar, Users tablosuna bağlı
CREATE TABLE Customers (
    Id INT PRIMARY KEY IDENTITY(1,1),  -- Otomatik artan birincil anahtar
    UserId INT NOT NULL,  -- Users tablosuna bağlanan sütun
    CompanyName NVARCHAR(100) NOT NULL,
    CONSTRAINT FK_Customers_Users FOREIGN KEY (UserId) REFERENCES Users(Id)  -- Kullanıcılar ile ilişki
);

-- 3. Brand tablosu: Arabaların marka bilgilerini tutar
CREATE TABLE Brand (
    Id INT PRIMARY KEY IDENTITY(1,1),  -- Otomatik artan birincil anahtar
    Name NVARCHAR(50) NOT NULL  -- Marka adı
);

-- 4. Color tablosu: Arabaların renk bilgilerini tutar
CREATE TABLE Color (
    Id INT PRIMARY KEY IDENTITY(1,1),  -- Otomatik artan birincil anahtar
    Name NVARCHAR(50) NOT NULL  -- Renk adı
);

-- 5. Car tablosu: Araba bilgilerini tutar, Brand ve Color tablolarına bağlı
CREATE TABLE Car (
    Id INT PRIMARY KEY IDENTITY(1,1),  -- Otomatik artan birincil anahtar
    Name NVARCHAR(100) NOT NULL,  -- Araba adı
    BrandId INT NOT NULL,  -- Brand tablosuna yabancı anahtar
    ColorId INT NOT NULL,  -- Color tablosuna yabancı anahtar
    ModelYear INT NOT NULL,  -- Model yılı
    DailyPrice DECIMAL(10, 2) NOT NULL,  -- Günlük fiyat
    Description NVARCHAR(255),  -- Açıklama
    CONSTRAINT FK_Car_Brand FOREIGN KEY (BrandId) REFERENCES Brand(Id),  -- Marka ile ilişki
    CONSTRAINT FK_Car_Color FOREIGN KEY (ColorId) REFERENCES Color(Id)   -- Renk ile ilişki
);

-- 6. Rentals tablosu: Kiralama bilgilerini tutar, Customers ve Car tablolarına bağlı
CREATE TABLE Rentals (
    Id INT PRIMARY KEY IDENTITY(1,1),  -- Otomatik artan birincil anahtar
    CarId INT NOT NULL,  -- Kiralanan araba
    CustomerId INT NOT NULL,  -- Kiralayan müşteri
    RentDate DATE NOT NULL,  -- Kiralama tarihi
    ReturnDate DATE NULL,  -- Teslim tarihi, teslim edilmemişse NULL
    CONSTRAINT FK_Rentals_Car FOREIGN KEY (CarId) REFERENCES Car(Id),  -- Araba ile ilişki
    CONSTRAINT FK_Rentals_Customers FOREIGN KEY (CustomerId) REFERENCES Customers(Id)  -- Müşteri ile ilişki
);
