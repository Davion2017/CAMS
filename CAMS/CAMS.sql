create database school;

use school;

CREATE TABLE course(
	id int NOT NULL PRIMARY KEY IDENTITY(1,1),
	number char(6) NOT NULL UNIQUE,
	cname varchar(50) UNIQUE,
	ename VARCHAR(100) UNIQUE,
	score tinyint,
	chour tinyint,
	lhour tinyint,
	tchour tinyint,
	tlhour SMALLINT,
);

create table resource(
	id int not null primary key IDENTITY(1,1),
	course_id int FOREIGN KEY REFERENCES course(id),
	name VARCHAR(50) not null,
	resourse_url VARCHAR(50),
);

CREATE TABLE category_course(
	id int not null PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(20) not null UNIQUE,
);

CREATE TABLE major(
	id int not null PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(50) not null UNIQUE,
);

CREATE TABLE education_program(
	id int not null PRIMARY key IDENTITY(1,1),
	name VARCHAR(100) not null unique,
	objective VARCHAR(2000),
	specification VARCHAR(5000),
	duration tinyint,
	degree VARCHAR(20),
	min_credit tinyint,
	publish_year SMALLINT,
	major_id int FOREIGN KEY REFERENCES major(id),
);

CREATE TABLE curriculum(
	id int not null PRIMARY KEY IDENTITY(1,1),
	program_id int FOREIGN KEY REFERENCES education_program(id),
	course_id int FOREIGN KEY REFERENCES course(id),
	category_id int FOREIGN KEY REFERENCES category_course(id),
	semester tinyint CHECK(semester>=1 and semester<=80),
	isdegree tinyint CHECK(isdegree in (0,1)),
);

CREATE TABLE class(
	id int not null PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(50) UNIQUE,
	enroll_year SMALLINT,
	major_id int FOREIGN KEY REFERENCES major(id),
);

CREATE TABLE student(
	id int not null PRIMARY KEY IDENTITY(1,1),
	scode char(12) UNIQUE,
	name VARCHAR(50),
	gender char(2) CHECK(gender in ('男','女')),
	photo VARCHAR(20),
	class_id int FOREIGN KEY REFERENCES class(id),
	passwd varchar(50),
);

CREATE TABLE semester(
	id int not null PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(50) UNIQUE,
);

CREATE TABLE plan_study_course(
	id int not null PRIMARY KEY IDENTITY(1,1),
	course_id int FOREIGN KEY REFERENCES course(id),
	semester_id int FOREIGN KEY REFERENCES semester(id),
	student_id int FOREIGN KEY REFERENCES student(id),
);

CREATE TABLE teacher(
	id int not null PRIMARY KEY IDENTITY(1,1),
	tcode char(6),
	name VARCHAR(50),
	gender char(2) CHECK(gender in ('男','女')),
	title VARCHAR(10),
	introduction VARCHAR(2000),
	photo VARCHAR(20),
	passwd varchar(50),
);

CREATE TABLE course_class(
	id int not null PRIMARY KEY IDENTITY(1,1),
	semester_id int FOREIGN KEY REFERENCES semester(id),
	course_id int FOREIGN KEY REFERENCES course(id),
	max_class_size int,
	teacher_id int FOREIGN KEY REFERENCES teacher(id),
);

CREATE TABLE class_student(
	id int not null PRIMARY KEY IDENTITY(1,1),
	course_class_id int FOREIGN KEY REFERENCES course_class(id),
	student_id int FOREIGN KEY REFERENCES student(id),
	gpa_score tinyint,
	paper_score tinyint,
	practice_score tinyint,
	score tinyint,
);

CREATE TABLE administor(
	id int not null PRIMARY KEY IDENTITY(1,1),
	name VARCHAR(50),
	acode char(6),
	passwd varchar(20),
)