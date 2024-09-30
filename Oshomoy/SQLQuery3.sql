CREATE TABLE Payment (
    TrxId INT PRIMARY KEY IDENTITY(1,1),      
    Username NVARCHAR(100) NOT NULL,          
    Email NVARCHAR(100) NOT NULL,             
    Method NVARCHAR(50) NOT NULL,      
    PaymentDate DATE NOT NULL,                       
    UserId INT,                              
    CONSTRAINT FK_UserId FOREIGN KEY (UserId) REFERENCES Users(UserId)  
);