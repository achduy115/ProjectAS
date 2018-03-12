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

-- Added - insert a anime category
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

