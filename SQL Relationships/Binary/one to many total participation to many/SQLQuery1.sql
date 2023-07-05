CREATE TABLE employee (
  eid INT PRIMARY KEY,
  ename VARCHAR(50),
  did INT FOREIGN KEY (did) REFERENCES department(did)
);

CREATE TABLE department (
  did INT PRIMARY KEY,
  dname VARCHAR(50)
  
);