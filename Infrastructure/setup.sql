USE [EFChallengeDB]
GO
DROP USER IF EXISTS [efchallengeuser]
GO
USE [master]
GO
IF EXISTS (SELECT 1 FROM master.sys.server_principals WHERE [name] = N'efchallengeuser' and [type] IN ('C','E', 'G', 'K', 'S', 'U'))
BEGIN
    DROP LOGIN [efchallengeuser]
END
GO
DROP DATABASE IF EXISTS [EFChallengeDB];
CREATE DATABASE [EFChallengeDB];
GO
USE [master]
GO
CREATE LOGIN [efchallengeuser] WITH PASSWORD=N'Password!1234', DEFAULT_DATABASE=[EFChallengeDB], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
USE [EFChallengeDB]
GO
CREATE USER [efchallengeuser] FOR LOGIN [efchallengeuser]
GO
USE [EFChallengeDB]
GO
ALTER USER [efchallengeuser] WITH DEFAULT_SCHEMA=[dbo]
GO
USE [EFChallengeDB]
GO
ALTER ROLE [db_owner] ADD MEMBER [efchallengeuser]
GO