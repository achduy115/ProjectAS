-- PROJECT AS
-- version 1.0.0.0
USE master
GO

--
-- Database: ProjectAS
--

CREATE DATABASE ProjectAS
GO

USE ProjectAS
GO

-- TABLE

-- Table Anime Category
CREATE TABLE table_AnimeCategory
(
	-- Table info
	ID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL,
	Title NVARCHAR(100) NOT NULL DEFAULT N'Không có mô tả.',
	...
)
GO

-- Table Anime
CREATE TABLE table_Anime
(
	-- Table info
	ID VARCHAR(8) PRIMARY KEY, -- SUM15001, SPI16002, etc...
	IDAnimeCategory INT NOT NULL, -- 1, 2, etc...
	Name NVARCHAR(50) NOT NULL, -- Boku no pico, naruto, one piece, etc...
	Image VARCHAR(100) NOT NULL, -- Link đến Image
	Title VARCHAR(100) NOT NULL DEFAULT N'Không có tiêu đề.',
	Content NVARCHAR(200) NOT NULL DEFAULT N'Không có nôi dung.',
	CurrentEpisode VARCHAR(5) NOT NULL DEFAULT '0',
	MaxEpisode VARCHAR(5) NOT NULL DEFAULT '??', 
	
	-- Foreign
	FOREIGN KEY (IDAnimeCategory) 
		REFERENCES table_AnimeCategory (ID)
)
GO

-- Table Nhóm Sub
CREATE TABLE table_SubTeam
(
	-- Table info
	ID VARCHAR(4) PRIMARY KEY, -- KRT, VNS, ZFS, etc...
	Name NVARCHAR(50) NOT NULL, -- vnsharing, zing fansub, etc...
	Info NVARCHAR(100) NOT NULL DEFAULT N'Không có mô tả',
)
GO

-- Table Episode
CREATE TABLE table_Episode
(
	-- Table info
	ID VARCHAR(12) PRIMARY KEY, -- SUM15001 + ZFS, etc...
	IDAnime VARCHAR(8) NOT NULL, -- SUM15001, etc...
	IDSubTeam VARCHAR(4) NOT NULL, -- ZFS, etc...

	-- Foreign
	FOREIGN KEY (IDAnime)
		REFERENCES table_Anime (ID),
	
	FOREIGN KEY (IDSubTeam)
		REFERENCES table_SubTeam (ID)
)
GO

-- Table Info Episode
CREATE TABLE table_InfoEpisode
(
	-- Table info
	ID VARCHAR(16) PRIMARY KEY, -- SUM15001 + ZFS + 0001(tập 1), etc...
	Name NVARCHAR(5) NOT NULL, -- '01', '02', 'OVA', etc... 
	IDEpisode VARCHAR(12) NOT NULL, -- SUM15001 + ZFS, etc...
	Video VARCHAR(100) NOT NULL -- Link đến Video

	-- Foreign
	FOREIGN KEY (IDEpisode)
		REFERENCES table_Episode (ID)
)
GO

-- Table Account
CREATE TABLE table_Account --
(
	ID INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL,
	Email VARCHAR(50) NOT NULL,
)

-- Table Comment
CREATE TABLE table_Comment --
(
	-- Table info
	ID INT PRIMARY KEY IDENTITY,
	IDAnime VARCHAR(8)
	-- Foreign
	FOREIGN KEY (IDAnime)
		REFERENCES table_Anime (ID)
)
GO

CREATE TABLE table_InfoComment --
(
	-- Table info
	ID INT PRIMARY KEY IDENTITY,
	IDComment INT NOT NULL,
	IDAccount INT NOT NULL,
	Info NVARCHAR(500) NOT NULL DEFAULT N'Không có thông tin.',
	-- Foreign
	FOREIGN KEY (IDAccount)
		REFERENCES table_Account (ID)
)
GO

-- Table View
CREATE TABLE table_View --
(
	-- Table info
	IDAnime VARCHAR(8) NOT NULL, 
	DayView INT NOT NULL DEFAULT 0,
	WeekView INT NOT NULL DEFAULT 0,
	MonthView INT NOT NULL DEFAULT 0,
	TotalView INT NOT NULL DEFAULT 0,
	--- Foreign
)
GO

-- Table study Japanese
CREATE TABLE table_Japanese --ALL
(
	...
)


