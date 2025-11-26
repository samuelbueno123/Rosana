-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema trabalho
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema trabalho
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `trabalho` DEFAULT CHARACTER SET utf8 ;
USE `trabalho` ;

-- -----------------------------------------------------
-- Table `trabalho`.`jogadores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`jogadores` (
  `codigo` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NULL,
  `esporte` VARCHAR(45) NULL,
  `nascimento` DATE NULL,
  `nacionalidade` VARCHAR(45) NULL,
  `data de estreia` DATE NULL,
  `data de aposentaria` DATE NULL,
  PRIMARY KEY (`codigo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`usuario` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `nome` VARCHAR(45) NOT NULL,
  `email` VARCHAR(45) NOT NULL,
  `senha` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`futebol`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`futebol` (
  `jogadores_codigo` INT NOT NULL,
  `partidas` INT NULL,
  `gols` INT NULL,
  `assistencias` INT NULL,
  `titulos` INT NULL,
  `boladeouro` INT NULL,
  INDEX `fk_futebol_jogadores_idx` (`jogadores_codigo` ASC),
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_futebol_jogadores`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`jogadores` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`basquete`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`basquete` (
  `jogadores_codigo` INT NOT NULL,
  `partidas` INT NULL,
  `pontos` INT NULL,
  `3pontos` INT NULL,
  `rebote` INT NULL,
  `assistencias` INT NULL,
  INDEX `fk_basquete_jogadores1_idx` (`jogadores_codigo` ASC),
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_basquete_jogadores1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`jogadores` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`baseball`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`baseball` (
  `jogadores_codigo` INT NOT NULL,
  `partidas` INT NULL,
  `mediarebatidas` FLOAT NULL,
  `homeruns` INT NULL,
  `basesroubadas` INT NULL,
  `corridas` INT NULL,
  INDEX `fk_baseball_jogadores1_idx` (`jogadores_codigo` ASC),
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_baseball_jogadores1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`jogadores` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`futebol americano`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`futebol americano` (
  `jogadores_codigo` INT NOT NULL,
  `partidas` INT NULL,
  `jardas` INT NULL,
  `mediajardas` FLOAT NULL,
  `pontos` INT NULL,
  `títulos` INT NULL,
  INDEX `fk_futebol americano_jogadores1_idx` (`jogadores_codigo` ASC),
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_futebol americano_jogadores1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`jogadores` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`natacao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`natacao` (
  `jogadores_codigo` INT NOT NULL,
  `melhortempo` TIME NULL,
  `velmedia` FLOAT NULL,
  `títulos` INT NULL,
  INDEX `fk_natacao_jogadores1_idx` (`jogadores_codigo` ASC),
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_natacao_jogadores1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`jogadores` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`atletismo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`atletismo` (
  `jogadores_codigo` INT NOT NULL,
  `melhortempo` TIME NULL,
  `títulos` INT NULL,
  INDEX `fk_atletismo_jogadores1_idx` (`jogadores_codigo` ASC),
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_atletismo_jogadores1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`jogadores` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`golfe`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`golfe` (
  `jogadores_codigo` INT NOT NULL,
  `holeinone` INT NULL,
  `gir` FLOAT NULL,
  INDEX `fk_golfe_jogadores1_idx` (`jogadores_codigo` ASC),
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_golfe_jogadores1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`jogadores` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`esports`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`esports` (
  `jogadores_codigo` INT NOT NULL,
  `jogo` VARCHAR(45) NULL,
  `org` VARCHAR(45) NULL,
  INDEX `fk_e-sports_jogadores1_idx` (`jogadores_codigo` ASC),
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_e-sports_jogadores1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`jogadores` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`valorant`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`valorant` (
  `jogadores_codigo` INT NOT NULL,
  `agente` VARCHAR(45) NULL,
  `kills` INT NULL,
  `mortes` INT NULL,
  `kd` FLOAT NULL,
  `adr` FLOAT NULL,
  `titulos` INT NULL,
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_valorant_e-sports1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`esports` (`jogadores_codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`cs`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`cs` (
  `jogadores_codigo` INT NOT NULL,
  `kills` INT NULL,
  `mortes` INT NULL,
  `kd` FLOAT NULL,
  `adr` FLOAT NULL,
  `títulos` INT NULL,
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_cs_e-sports1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`esports` (`jogadores_codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`cod`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`cod` (
  `jogadores_codigo` INT NOT NULL,
  `kills` INT NULL,
  `mortes` INT NULL,
  `kd` FLOAT NULL,
  `adr` FLOAT NULL,
  `titulos` INT NULL,
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_cod_e-sports1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`esports` (`jogadores_codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`rocket`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`rocket` (
  `jogadores_codigo` INT NOT NULL,
  `golsporjogo` FLOAT NULL,
  `assistporjogo` FLOAT NULL,
  `defesaporjogo` FLOAT NULL,
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_rocket_e-sports1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`esports` (`jogadores_codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`judo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`judo` (
  `jogadores_codigo` INT NOT NULL,
  `faixa` VARCHAR(45) NULL,
  `clube` VARCHAR(45) NULL,
  `ouros` INT NULL,
  `prata` INT NULL,
  `bronze` INT NULL,
  `ippon` INT NULL,
  INDEX `fk_judo_jogadores1_idx` (`jogadores_codigo` ASC),
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_judo_jogadores1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`jogadores` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`boxe`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`boxe` (
  `jogadores_codigo` INT NOT NULL,
  `nocautes` INT NULL,
  `vitorias` INT NULL,
  `derrotas` INT NULL,
  `razaovitorias` FLOAT NULL,
  `ouro` INT NULL,
  `prata` INT NULL,
  `bronze` INT NULL,
  INDEX `fk_boxe_jogadores1_idx` (`jogadores_codigo` ASC),
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_boxe_jogadores1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`jogadores` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`xadrez`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`xadrez` (
  `jogadores_codigo` INT NOT NULL,
  `percentvitoria` INT NULL,
  `elo` INT NULL,
  `aberturafavorita` VARCHAR(45) NULL,
  `titulos` INT NULL,
  INDEX `fk_xadrez_jogadores1_idx` (`jogadores_codigo` ASC),
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_xadrez_jogadores1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`jogadores` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `trabalho`.`formula1`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `trabalho`.`formula1` (
  `jogadores_codigo` INT NOT NULL,
  `podios` INT NULL,
  `polepositions` INT NULL,
  `vitorias` INT NULL,
  INDEX `fk_formula1_jogadores1_idx` (`jogadores_codigo` ASC),
  PRIMARY KEY (`jogadores_codigo`),
  CONSTRAINT `fk_formula1_jogadores1`
    FOREIGN KEY (`jogadores_codigo`)
    REFERENCES `trabalho`.`jogadores` (`codigo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
