CREATE TABLE course_status(
    id int IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(20),
    status INT
);

INSERT INTO course_status(name, status) VALUES('预选', '0');
INSERT INTO course_status(name, status) VALUES('预选完成', '0');
INSERT INTO course_status(name, status) VALUES('正选', '0');
INSERT INTO course_status(name, status) VALUES('正选完成', '0');
INSERT INTO course_status(name, status) VALUES('排课', '0');
INSERT INTO course_status(name, status) VALUES('排课完成', '0');


CREATE TABLE current_semester(
    id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(20),
    status int
);

INSERT INTO current_semester(name, status) VALUES('第1学期','0');
INSERT INTO current_semester(name, status) VALUES('第2学期','0');
INSERT INTO current_semester(name, status) VALUES('第3学期','0');
INSERT INTO current_semester(name, status) VALUES('第4学期','0');
INSERT INTO current_semester(name, status) VALUES('第5学期','0');
INSERT INTO current_semester(name, status) VALUES('第6学期','0');
INSERT INTO current_semester(name, status) VALUES('第7学期','0');
INSERT INTO current_semester(name, status) VALUES('第8学期','0');
