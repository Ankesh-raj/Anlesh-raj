PatientId { get; set; }
        public string PatientName { get; set; }
        public string PatientEmail { get; set; }    
        
        public string PatientPassword { get; set; }

    

	 create database HospitalManagementService
	 use HospitalManagementService
	 create table Patient(

	PatientId int primary key,
	 PatientName varchar(12),
	 PatientEmail varchar(25),
	 PatientPassword varchar(28))
	 select *from Patient


	 create table Patient1
	 (
	PatientId int primary key,
     PatientEmail varchar(20),
     PatientName varchar(20),
    Patientsex varchar(20))


	
create table Doctor(
 DoctorId int primary key,
DoctorName varchar(20),
    DoctorEmail varchar(20),       
DoctorPassword  varchar(20),
 DoctorSpeciality varchar(20))

 select*from Doctor;


create table Appointment(
  PatientId int references Patient (PatientId),
  PatientName varchar(20),
 
  DoctorId  int references Doctor(DoctorId),
DoctorName  varchar(20),
AppointmentDate Date)




		create  database LibraryManagementSystem
		use LibraryManagementSystem

		create table User1
		(
         UserId int  primary key,
        Username varchar(20),
         Usermail varchar(20),
        UserPassword varchar(20))

		select *from User1
		create table Book
		(
		BokkId int primary key,
		BookName varchar(20),
		BookAuthor varchar(20),
		BookCopies int 
		)
		

	
		
		