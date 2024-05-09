 CREATE TABLE Transactions (
   v_id INT,
   s_id INT,
   transaction_date DATETIME DEFAULT GETDATE(),
   admin_id INT,
   PRIMARY KEY (v_id, s_id)
);

ALTER TABLE Transactions
ADD departureDate VARCHAR(50),
    departureTime VARCHAR(50),
    hours FLOAT,
    amount FLOAT,
    change FLOAT,
    cash FLOAT;

ALTER TABLE Transactions
ADD id int primary key identity(1,1)



 


