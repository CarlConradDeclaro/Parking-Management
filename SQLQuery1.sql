CREATE TABLE Vehicle (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [v_plate]     VARCHAR (255) NOT NULL,
    [v_type]      VARCHAR (255) NOT NULL,
    [model]       VARCHAR (255) NOT NULL,
    [driver]      VARCHAR (255) NULL,
    [phone]       VARCHAR (255) NULL,
    [arrivalDate] DATE          NOT NULL,
    [arrivalTime] TIME (7)      NOT NULL,
    [status]      VARCHAR (255) NOT NULL,
    [s_sloc]      VARCHAR (255) NULL,
    [admin]       INT           NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE Admin_logs (
    [logID]     INT            IDENTITY (1, 1) NOT NULL,
    [adminID]   INT            NOT NULL,
    [adminName] NVARCHAR (100) NOT NULL,
    [timestamp] DATETIME       DEFAULT (getdate()) NULL,
    PRIMARY KEY CLUSTERED ([logID] ASC)
);


CREATE TABLE Transactions (
    [v_id]             INT          NOT NULL,
    [s_id]             INT          NOT NULL,
    [transaction_date] DATETIME     DEFAULT (getdate()) NULL,
    [admin_id]         INT          NULL,
    [departureDate]    VARCHAR (50) NULL,
    [departureTime]    VARCHAR (50) NULL,
    [hours]            FLOAT (53)   NULL,
    [amount]           FLOAT (53)   NULL,
    [change]           FLOAT (53)   NULL,
    [cash]             FLOAT (53)   NULL,
    PRIMARY KEY CLUSTERED ([v_id] ASC, [s_id] ASC)
);

CREATE TABLE UsersData (
    [id]        INT           IDENTITY (1, 1) NOT NULL,
    [firstname] VARCHAR (255) NULL,
    [lastname]  VARCHAR (255) NULL,
    [uPassword] VARCHAR (255) NULL,
    [email]     VARCHAR (255) NULL,
    [phoneNum]  VARCHAR (20)  NULL,
    [gender]    VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE V_Slots (
    [s_id]         INT           IDENTITY (1, 1) NOT NULL,
    [s_loc]        VARCHAR (225) NULL,
    [availability] INT           NULL,
    PRIMARY KEY CLUSTERED ([s_id] ASC)
);

CREATE TABLE Vehicle_Brand (
    [id]          INT           IDENTITY (1, 1) NOT NULL,
    [vehicleType] VARCHAR (255) NULL,
    [vBrand]      VARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE Vehicle_Type (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
    [vType]         VARCHAR (255) NULL,
    [flagdown]      INT           NULL,
    [addAmtPerHOur] INT           NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);