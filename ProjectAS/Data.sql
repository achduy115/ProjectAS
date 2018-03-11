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
	ID VARCHAR(5) PRIMARY KEY, -- ROM, ACT, HAR etc...
	NameDisplay NVARCHAR(50) NOT NULL, -- ROMANCE, ACTION, HAREM
)
GO

-- Table Anime
CREATE TABLE table_Anime
(
	-- Table info
	ID VARCHAR(8) PRIMARY KEY, -- SUM15001, SPI16002, etc...
	NameDisplay NVARCHAR(50) NOT NULL, -- Boku no pico, naruto, one piece, etc...
	ImageUrl VARCHAR(100) NOT NULL, -- Link đến Image
	Content NVARCHAR(200) NOT NULL DEFAULT N'Không có nôi dung.', -- Nôi dụng nói về anime
	CurrentEpisode VARCHAR(5) NOT NULL DEFAULT '0', -- Episode hiện tại VD: 0/??, 0/MAX
	MaxEpisode VARCHAR(5) NOT NULL DEFAULT '??', -- Số Episode tối đa
)
GO

-- Table Anime Category - Anime
CREATE TABLE table_AnimeCategory_Anime
(
	-- Table info
	IdAnimeCategory VARCHAR(5), -- ROM, ACT, HAR etc...
	IDAnime VARCHAR(8), -- SUM15001, SPI16002, etc...

	-- Foreign
	FOREIGN KEY (IDAnimeCategory) 
		REFERENCES table_AnimeCategory (ID),
	FOREIGN KEY (IDAnime) 
		REFERENCES table_Anime (ID)
)
GO

-- Table Nhóm Sub
CREATE TABLE table_SubTeam
(
	-- Table info
	ID VARCHAR(4) PRIMARY KEY, -- KRT, VNS, ZFS, etc...
	NameDisplay NVARCHAR(50) NOT NULL, -- vnsharing, zing fansub, etc...
	Info NVARCHAR(100) NOT NULL DEFAULT N'Không có mô tả', -- Mô tả về nhóm sub
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
	NameDisplay NVARCHAR(5) NOT NULL, -- '01', '02', 'OVA', etc... 
	IDEpisode VARCHAR(12) NOT NULL, -- SUM15001 + ZFS, etc...
	VideoUrl VARCHAR(100) NOT NULL -- Link đến Video

	-- Foreign
	FOREIGN KEY (IDEpisode)
		REFERENCES table_Episode (ID)
)
GO

-- Table Account User - Dùng API của facebook để nhận dữ liệu
CREATE TABLE table_AccountUser --
(
	ID INT PRIMARY KEY IDENTITY, -- ID của người dùng, để comment
	NameDisplay NVARCHAR(50) NOT NULL, -- Tên hiển thị
	Email VARCHAR(50) NOT NULL, -- Email
)

-- Table Account Admin
CREATE TABLE table_AccountAdmin --
(
	ID INT PRIMARY KEY IDENTITY, -- ID của admin
	NameDisplay NVARCHAR(50) NOT NULL, -- Tên hiển thị
	UserName VARCHAR(50) NOT NULL, -- tên đăng nhập
	PassWord VARCHAR(50) NOT NULL, -- mật khẩu
)

-- Table Comment
CREATE TABLE table_Comment --
(
	-- Table info
	ID INT PRIMARY KEY IDENTITY, -- ID comment
	IDAnime VARCHAR(8) -- ID của anime mà ng dùng comment
	-- Foreign
	FOREIGN KEY (IDAnime)
		REFERENCES table_Anime (ID)
)
GO

-- Table Info Commnent
CREATE TABLE table_InfoComment --
(
	-- Table info
	ID INT PRIMARY KEY IDENTITY, -- ID của nội dung comment
	IDComment INT NOT NULL, -- ID của comment - ứng với anime
	IDAccountUser INT NOT NULL, -- ID của ng dùng
	Info NVARCHAR(500) NOT NULL DEFAULT N'Không có thông tin.', -- Nôi dung comment
	Checked BIT DEFAULT 0 -- Check để biết comment này admin đã đọc chưa
	-- Foreign
	FOREIGN KEY (IDAccountUser)
		REFERENCES table_AccountUser(ID)
)
GO

-- Table AnimeView
CREATE TABLE table_AnimeView --
(
	-- Table info
	IDAnime VARCHAR(8) NOT NULL, -- ID của anime để xem số lượng view
	DayView INT NOT NULL DEFAULT 0, -- số lượng view theo ngày
	WeekView INT NOT NULL DEFAULT 0, -- số lượng view theo tuần
	MonthView INT NOT NULL DEFAULT 0, -- số lượng vuew theo tháng
	TotalView INT NOT NULL DEFAULT 0, -- tống số lượng của tất cả view
	--- Foreign
	FOREIGN KEY (IDAnime)
		REFERENCES table_Anime (ID)
)
GO

-- Table WebView
CREATE TABLE table_WebView --VALUES
(
	DayView INT NOT NULL DEFAULT 0, -- số lượng view của web theo ngày
	WeekView INT NOT NULL DEFAULT 0, -- số lượng view của web theo tuần
	MonthView INT NOT NULL DEFAULT 0, -- số lượng view của web theo tháng
	TotalView INT NOT NULL DEFAULT 0, -- tổng số lượng view của web
)

-- Table study Japanese
--CREATE TABLE table_Japanese --ALL
--(
	--
--)


