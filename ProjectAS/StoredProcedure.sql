USE master
GO

USE ProjectAS
GO

-- Added - Get all anime category
CREATE PROC USP_LoadAnimeCategoryList
AS
BEGIN
	SELECT * FROM dbo.table_AnimeCategory
END
GO

-- Added - Insert a anime category
CREATE PROC USP_InsertAnimeCategory
@ID VARCHAR(5), @NameDisplay NVARCHAR(50)
AS
BEGIN
	INSERT INTO dbo.table_AnimeCategory (ID, NameDisplay)
	VALUES(@ID, @NameDisplay)
END
GO

-- Added - Update a anime category
CREATE PROC USP_UpdateAnimeCategory
@ID VARCHAR(5), @NameDisplay NVARCHAR(50)
AS
BEGIN
	UPDATE dbo.table_AnimeCategory SET NameDisplay = @NameDisplay
	WHERE ID = @ID
END
GO

-- Added - Delete a anime category
CREATE PROC USP_DeleteAnimeCategory
@ID VARCHAR(5)
AS
BEGIN
	DELETE dbo.table_AnimeCategory
	WHERE ID = @ID
END
GO

-- Added - Get all anime
CREATE PROC USP_LoadAnimeList
AS
BEGIN
	SELECT * FROM dbo.table_Anime
END
GO

-- Added - Insert a anime
CREATE PROC USP_InsertAnime
@ID VARCHAR(8), @NameDisplay NVARCHAR(50), @ImageUrl VARCHAR(100), @Content NVARCHAR(200)
AS
BEGIN
	INSERT INTO dbo.table_Anime(ID, NameDisplay, ImageUrl, Content)
					VALUES(@ID, @NameDisplay, @ImageUrl, @Content)
END
GO

--Added - Update a anime
CREATE PROC USP_UpdateAnime
@ID VARCHAR(8), @NameDisplay NVARCHAR(50), @ImageUrl VARCHAR(100), @Content NVARCHAR(200), @CurrentEpisode VARCHAR(5), @MaxEpisode VARCHAR(5)
AS
BEGIN
	UPDATE dbo.table_Anime SET NameDisplay = @NameDisplay, ImageUrl = @ImageUrl, Content = @Content, CurrentEpisode = @CurrentEpisode, MaxEpisode = @MaxEpisode
	WHERE ID = @ID
END
GO

--Added - Delete a anime
CREATE PROC USP_DeleteAnime
@ID VARCHAR(8)
AS
BEGIN
	DELETE dbo.table_Anime
	WHERE ID = @ID
END
GO