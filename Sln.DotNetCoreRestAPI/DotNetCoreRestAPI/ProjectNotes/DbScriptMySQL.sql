CREATE TABLE `personal_info` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `first_name` varchar(150) DEFAULT NULL,
  `last_name` varchar(150) DEFAULT NULL,
  `date_of_birth` datetime DEFAULT NULL,
  `city` varchar(150) DEFAULT NULL,
  `country` varchar(150) DEFAULT NULL,
  `mobile_no` varchar(45) DEFAULT NULL,
  `nid` int(11) DEFAULT NULL,
  `email` varchar(150) DEFAULT NULL,
  `created_date` datetime DEFAULT NULL,
  `creation_user` varchar(150) DEFAULT NULL,
  `last_update_user` varchar(150) DEFAULT NULL,
  `status` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
