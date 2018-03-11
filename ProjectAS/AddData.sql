-- PROJECT AS
-- version 1.0.0.0
USE master
GO

--
-- Database: ProjectAS
--

USE ProjectAS
GO

-- Add Data

-- Table Anime Category

INSERT INTO dbo.table_AnimeCategory
    (ID, Name, Title)
VALUES 
    (ROM, N'Tình cảm', N'Lãng mạn')

-- Table Anime
    ...
-- Table Sub Team

INSERT INTO dbo.table_SubTeam 
    (ID, Name, Info)
VALUES 
    (VNS, N'Vnsharing fansub', N'VnSharing Fansub (viết tắt là VNFS) được thành lập ngày 15/9/2007, là một thành viên quan trọng của diễn đàn Vnsharing.net/forum, chuyên vietsub về hai mảng chính là Anime và Tokusatsu.Đến năm 2014, khi Vnsharing tan rã, VNFS đã bắt đầu đi vào hoạt động độc lập, phát triển ra Fanpage Facebook và Homepage riêng.VNFS là ngôi nhà chung để thể hiện sự đam, tinh thần Share All We Have để chia sẻ với mọi người những tập phim được phụ đề tiếng Việt thật chất lượng.')

-- Table Episode
    ...
-- Table Info Episode
    ...
-- Table Account
    ...
-- Table Comment
    ...
-- Table Info Commnent
    ...
-- Table View
    ...