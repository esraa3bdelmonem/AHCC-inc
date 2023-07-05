CREATE TABLE Employee (
  eid INT PRIMARY KEY,
  ename VARCHAR(50),
  age INT,
  mid INT,
  FOREIGN KEY (mid) REFERENCES Employee(eid)
);