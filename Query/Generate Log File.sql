cREATE DATABASE [Test] ON 
    (FILENAME = N'D:\DB\tt.mdf')
    FOR ATTACH_REBUILD_LOG


EXEC sp_attach_single_file_db @dbname = 'dbABC', 
   @physname = 'D:\Microsoft SQL Server\MSSQL\Data\dbABC.mdf'