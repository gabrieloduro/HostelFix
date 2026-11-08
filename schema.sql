CREATE TABLE complaints (
  id INT AUTO_INCREMENT PRIMARY KEY,
  hostel VARCHAR(50) NOT NULL,
  room VARCHAR(20) NOT NULL,
  category VARCHAR(50) NOT NULL,
  priority ENUM('Medium','High','Emergency') NOT NULL,
  description VARCHAR(500) NULL,
  status ENUM('Pending','Assigned','Resolved') NOT NULL DEFAULT 'Pending',
  technician VARCHAR(100) NULL,
  ip VARCHAR(45) NULL,
  created_at TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  INDEX idx_ip_time (ip, created_at)
);
