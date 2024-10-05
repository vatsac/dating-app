create table Value(
Id int primary key,
Name varchar(max))


create table Users(
Id int primary key identity,
Username varchar(128),
PasswordHash varbinary(max),
PasswordSalt varbinary(max)
)


ALTER TABLE Users
    ADD 
        Gender VARCHAR(128) ,
        DateOfBirth DateTime ,
		KnownAs VARCHAR(128),
		Created DateTime ,
		LastActive DateTime ,
		Introduction VARCHAR(max),
		LookingFor VARCHAR(128),
		Interests VARCHAR(128),
		City VARCHAR(128),
		Country VARCHAR(128);

		 

		create table Photo(
Id int primary key identity,
Url varchar(max),
Description varchar(max),
DateAdded Datetime ,
IsMain bit,
UserId int Not Null
  Constraint FK_UserId Foreign Key(UserId)
  references Users(Id),
)

INSERT INTO Photo(Url,IsMain,Description,UserId) VALUES
 ('https://randomuser.me/api/portraits/women/3.jpg','true','Non deserunt labore sunt ex laboris et adipisicing ullamco officia minim.',1)
,('https://randomuser.me/api/portraits/women/49.jpg','true','Elit culpa eu excepteur ut elit tempor nulla duis dolore.',2)
,('https://randomuser.me/api/portraits/women/24.jpg','true','Veniam dolore nisi magna laboris minim id pariatur officia.',3)
,('https://randomuser.me/api/portraits/women/74.jpg','true','Veniam velit amet tempor laboris reprehenderit deserunt quis do veniam.',4)
,('https://randomuser.me/api/portraits/women/33.jpg','true','Ipsum enim cillum ad nisi consequat cillum ipsum ullamco tempor.',5)
,('https://randomuser.me/api/portraits/men/90.jpg','true','Irure cupidatat magna aute et dolore aliquip reprehenderit dolor irure.',6)
,('https://randomuser.me/api/portraits/men/96.jpg','true','Magna duis consectetur sit ut commodo non eiusmod.',7)
,('https://randomuser.me/api/portraits/men/4.jpg','true','Cupidatat veniam ea magna cillum velit minim non minim tempor ipsum excepteur.',8)
,('https://randomuser.me/api/portraits/men/76.jpg','true','Amet officia enim pariatur mollit tempor in ut.',9)
,('https://randomuser.me/api/portraits/men/14.jpg','true','Nulla nisi tempor sint cillum aliqua esse aute.',10);

UPDATE Users SET Gender = 'female',DateOfBirth = '1994-02-21',KnownAs = 'Lola',Created = '2017-08-02',LastActive = '2017-08-02',Introduction = 'Nulla excepteur sit anim ex do qui laboris officia eiusmod ut incididunt. Enim occaecat sint dolor esse et enim. Ad cupidatat exercitation ea id eiusmod nostrud amet Lorem sint. Laboris cupidatat aute dolor ad eu tempor elit ea tempor quis et. Lorem eiusmod commodo cillum id aute nisi fugiat. Aute laborum tempor ullamco elit exercitation veniam commodo elit dolor.',LookingFor = 'Male',Interests = 'Dolore nisi eiusmod ut irure ullamco nulla dolore est sit tempor quis.',City = 'Efland',Country = 'Burundi' WHERE Username= 'lola';
UPDATE Users SET Gender = 'female',DateOfBirth = '1979-04-19',KnownAs = 'Dorothy',Created = '2017-01-21',LastActive = '2017-01-21',Introduction = 'Consequat mollit velit aliquip in nostrud ad esse Lorem ea qui do et. Reprehenderit occaecat consectetur ad in laborum labore id. Esse ea duis eu non duis cillum magna reprehenderit deserunt. Tempor aute qui veniam non consequat do ea ipsum tempor ea deserunt consectetur. Laboris ipsum laboris ipsum sit Lorem magna nulla et. Nulla minim nisi minim fugiat. Exercitation veniam nostrud id exercitation adipisicing commodo.',LookingFor = 'Male',Interests = 'Nisi eu amet et tempor eu magna.',City = 'Deseret',Country = 'Mongolia' WHERE Username= 'dorothy';
UPDATE Users SET Gender = 'female',DateOfBirth = '1984-12-05',KnownAs = 'Reba',Created = '2017-06-24',LastActive = '2017-06-24',Introduction = 'Ea tempor reprehenderit officia commodo aliqua dolor. Ex culpa eiusmod quis Lorem fugiat. Incididunt duis ad enim sunt qui. Ullamco magna dolor in eiusmod sit. Ut ea ut commodo ipsum eu non sit eiusmod voluptate consequat aute eu. Nisi velit in sunt labore nulla sunt quis amet enim. Nulla sint mollit cupidatat aliqua ex adipisicing sint id tempor officia incididunt irure enim.',LookingFor = 'Male',Interests = 'Fugiat consequat elit velit ullamco nisi qui cillum.',City = 'Hannasville',Country = 'Poland' WHERE Username= 'reba';
UPDATE Users SET Gender = 'female',DateOfBirth = '1970-02-25',KnownAs = 'Annmarie',Created = '2017-07-17',LastActive = '2017-07-17',Introduction = 'Enim eiusmod esse magna aliquip occaecat. Non ea quis cillum aliquip reprehenderit aute proident officia do nulla voluptate duis. Deserunt ullamco quis qui cillum consequat esse sunt in dolore nulla sit officia voluptate. Tempor pariatur exercitation pariatur reprehenderit. Incididunt nulla magna exercitation officia enim veniam adipisicing laboris proident nisi id Lorem.',LookingFor = 'Male or Female',Interests = 'In dolor ex laboris ad sint.',City = 'Sutton',Country = 'Bouvet Island' WHERE Username= 'anmarie';
UPDATE Users SET Gender = 'female',DateOfBirth = '1953-03-01',KnownAs = 'Ashley',Created = '2017-03-25',LastActive = '2017-03-25',Introduction = 'Eiusmod dolore consectetur nisi laborum id duis occaecat dolor cupidatat excepteur eu aliquip. Nulla non ipsum in id eu consequat sint do non tempor aute incididunt do duis. Nostrud veniam ea in do aliqua mollit sit magna qui.',LookingFor = 'Male',Interests = 'Cillum duis veniam quis eu enim consequat reprehenderit occaecat pariatur minim ipsum.',City = 'Bayview',Country = 'Zambia' WHERE Username= 'ashley';
UPDATE Users SET Gender = 'male',DateOfBirth = '1993-08-21',KnownAs = 'Roy',Created = '2017-08-03',LastActive = '2017-08-03',Introduction = 'Cillum exercitation exercitation duis aliqua minim velit veniam. Veniam id exercitation excepteur dolore voluptate esse. Elit eiusmod voluptate ullamco fugiat sit cillum deserunt et.',LookingFor = 'Female',Interests = 'Lorem aute Lorem voluptate mollit.',City = 'Davenport',Country = 'Tuvalu' WHERE Username= 'roy';
UPDATE Users SET Gender = 'male',DateOfBirth = '1996-09-07',KnownAs = 'Duke',Created = '2017-07-07',LastActive = '2017-07-07',Introduction = 'Dolor voluptate enim laborum duis proident commodo sit. Sint cupidatat Lorem ullamco dolor qui proident. Consectetur fugiat ut ipsum ullamco ut magna minim consectetur consectetur. Quis labore nostrud minim dolor.',LookingFor = 'Female',Interests = 'Reprehenderit fugiat Lorem consectetur fugiat minim nulla magna commodo anim esse eu consectetur.',City = 'Inkerman',Country = 'Canada' WHERE Username= 'duke';
UPDATE Users  SET Gender = 'male',DateOfBirth = '1957-03-07',KnownAs = 'Lloyd',Created = '2017-08-22',LastActive = '2017-08-22',Introduction = 'Nostrud reprehenderit mollit magna incididunt nulla mollit ad do ullamco ipsum reprehenderit consequat minim. Nisi id est et consequat reprehenderit tempor fugiat aliquip mollit aute consectetur culpa. Ut amet aliqua minim magna. Velit dolore consectetur culpa ea magna nisi eu sit velit.',LookingFor = 'Female',Interests = 'Velit aute elit elit pariatur amet adipisicing sint eiusmod sunt eu ex voluptate ad.',City = 'Loma',Country = 'Paraguay' WHERE Username= 'lloyd';
UPDATE Users SET Gender = 'male',DateOfBirth = '1969-08-15',KnownAs = 'Larsen',Created = '2017-02-17',LastActive = '2017-02-17',Introduction = 'Mollit cillum ex eiusmod magna et dolor sit duis velit pariatur enim anim occaecat. Excepteur excepteur ut dolor nisi consequat mollit quis. Nisi irure quis et id amet aliqua.',LookingFor = 'Male',Interests = 'In non sint ea do veniam sunt duis quis mollit.',City = 'Bynum',Country = 'Pakistan' WHERE Username= 'larsen';
UPDATE Users SET Gender = 'male',DateOfBirth = '1984-02-19',KnownAs = 'Simon',Created = '2017-06-27',LastActive = '2017-06-27',Introduction = 'Aliqua nisi labore tempor adipisicing. Lorem in ut enim quis dolor magna commodo nisi ad voluptate et excepteur aliqua. Ea nostrud velit laborum sit nisi cillum proident nisi.',LookingFor = 'Male',Interests = 'Sit ea id excepteur adipisicing ea excepteur sint ex et amet commodo do voluptate esse.',City = 'Cavalero',Country = 'Viet Nam' WHERE Username= 'simon';

ALTER TABLE Photo
    ADD
	PublicID Varchar(max);


   create table Likes (
   Id int primary key,
   LikerId int Not Null
  Constraint FK_likerId Foreign Key(LikerId)
  references Users(Id),
  LikeeId int Not Null
  Constraint FK_LikeeId Foreign Key(LikeeId)
  references Users(Id))

        
create table Message(

Id int identity primary key,
SenderId int Not Null
Constraint FK_SenderId Foreign Key(SenderId)
references Users(Id),
RecipientId int Not Null
Constraint FK_RecipientId Foreign Key(RecipientId)
references Users(Id),
Content Varchar(max),
IsRead bit not null default 'false',
DateRead DateTime,
MessageSent DateTime Not Null default GETDATE(),
SenderDeleted bit not null default 'false',
RecipientDeleted bit not null default 'false'
)







)
      

     
