CREATE TABLE employee (
  eid INT PRIMARY KEY,
  ename VARCHAR(50)
);

CREATE TABLE project (
  pid INT PRIMARY KEY,
  pname VARCHAR(50)
);
CREATE TABLE emppro (
  eid INT PRIMARY KEY,
  pid INT 
);