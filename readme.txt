Hello this is for test source control for git gitHub


 Insert Into [CalMaster].[dbo].[Training_Program1] ([Class_ID]
      ,[ClassTitle]
      ,[ClassDate]
      ,[Course_Duration]
      ,[Distribution]
      ,[Supervisor1]
      ,[Instructors]
      ,[Site_Location]
      ,[Class_Description])

SELECT 
      [Class_ID]
      ,[ClassTitle]
      ,[ClassDate]
      ,[Course_Duration]
      ,[Distribution]
      ,[Supervisor1]
      ,[Instructors]
      ,[Site_Location]
      ,[Class_Description]

 FROM [CalMaster].[dbo].[Training_Program]




"INSERT INTO [Training_Program] ([Class_ID], [ClassTitle], [ClassDate], [Course_Duration], [Distribution], [Supervisor1], [Instructors], [Class_Description], [Site_Location]) VALUES (@Class_ID, @ClassTitle, @ClassDate, @Course_Duration, @Distribution, @Supervisor1, @Instructors, @Class_Description, @Site_Location)" 