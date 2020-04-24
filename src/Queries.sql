Create procedure [dbo].[AddNewPlaceDetails]  
(  
   @Name varchar (50), 
   @Kind varchar(50),
   @Rooms int ,  
   @MaxOfGuests int
   
)  
as  
begin  
   Insert into Place values(@Name,@Kind,@Rooms,@MaxOfGuests)  
End  