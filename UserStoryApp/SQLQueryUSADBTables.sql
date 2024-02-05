Use UserStoryApplication;

CREATE TABLE MemberTable(
	GroupMemberNo INT NOT NULL IDENTITY(1,1) UNIQUE,
	FirstName VARCHAR(50),
	Surname VARCHAR(50),
	Username VARCHAR(50),
	[Password] VARCHAR(50),
	PRIMARY KEY (GroupMemberNo)
);

CREATE TABLE UserStoryTable(
	UserStoryNo INT NOT NULL IDENTITY(1,1) UNIQUE,
	UserStoryTitle VARCHAR(50),
	UserRole VARCHAR(50),
	UserStorydescription TEXT,
	UserStoryStartDate DATE,
	UserStoryEndDate DATE,
	UserStoryStatus VARCHAR(50),
	UserStoryPriority VARCHAR(50),
	PRIMARY KEY (UserStoryNo)
);

CREATE TABLE UserStory_MemberTable(
	UserStoryNo INT NOT NULL,
	GroupMemberNo INT NOT NULL,
	Responsibility TEXT,
	CONSTRAINT PK_UserStoryMemberTable PRIMARY KEY (UserStoryNo,GroupMemberNo),
	FOREIGN KEY (UserStoryNo) references UserStoryTable,
	FOREIGN KEY (GroupMemberNo) references MemberTable
);

CREATE TABLE TestCasesTable(
	TestCases INT NOT NULL IDENTITY(1,1) UNIQUE,
	TestCaseDetails TEXT,
	UserStoryNo INT,
	PRIMARY KEY (TestCases),
	FOREIGN KEY (UserStoryNo) references UserStoryTable
);