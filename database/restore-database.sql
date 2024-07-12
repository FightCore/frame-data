RESTORE DATABASE FrameData
FROM DISK = '/var/opt/mssql/data/framedata.bak'
WITH MOVE 'FrameData' TO '/var/opt/mssql/data/framedata.mdf'
MOVE 'FrameData_log' TO '/var/opt/mssql/data/framedata_log.ldf'