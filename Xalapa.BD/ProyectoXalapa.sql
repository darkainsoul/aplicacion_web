-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema proyecto_xalapa
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema proyecto_xalapa
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `proyecto_xalapa` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `proyecto_xalapa` ;

-- -----------------------------------------------------
-- Table `proyecto_xalapa`.`tb_academic_groups`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `proyecto_xalapa`.`tb_academic_groups` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(450) NOT NULL,
  `date_register` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_academic_group_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 8
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `proyecto_xalapa`.`tb_research_centers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `proyecto_xalapa`.`tb_research_centers` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(450) NOT NULL,
  `date_register` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_research_center_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 5
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `proyecto_xalapa`.`tb_research_lines`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `proyecto_xalapa`.`tb_research_lines` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(450) NOT NULL,
  `date_register` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `goals` VARCHAR(4500) NOT NULL,
  `common_objectives` VARCHAR(4500) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_research_lines_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `proyecto_xalapa`.`tb_research_projects`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `proyecto_xalapa`.`tb_research_projects` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(450) NOT NULL,
  `date_register` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `thesis_topics` VARCHAR(450) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_research_projects_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `proyecto_xalapa`.`tb_researchers`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `proyecto_xalapa`.`tb_researchers` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(450) NOT NULL,
  `date_register` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `academic_grade` VARCHAR(450) NOT NULL,
  `speciality` VARCHAR(450) NOT NULL,
  `knowledge_areas` VARCHAR(450) NOT NULL,
  `years_of_experience` INT NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_researchers_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB
AUTO_INCREMENT = 3
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `proyecto_xalapa`.`tb_thesis_directors`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `proyecto_xalapa`.`tb_thesis_directors` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(450) NOT NULL,
  `date_register` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_thesis_director_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `proyecto_xalapa`.`tb_thesis_students`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `proyecto_xalapa`.`tb_thesis_students` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(450) NOT NULL,
  `date_register` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `id_thesis_students_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
