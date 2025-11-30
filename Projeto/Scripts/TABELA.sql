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





create table preferencias (
	usuario int(11) primary key,
    atletismo bool,
    baseball bool,
    basquete bool,
    boxe bool,
    cod bool,
    cs bool,
    formula1 bool,
    futebol bool,
    `futebol americano` bool,
    golfe bool,
    judo bool,
    natacao bool,
    rocket bool,
    valorant bool,
    xadrez bool,
    foreign key (usuario) references usuario(id)
    );
    
DELIMITER //

CREATE TRIGGER preferences
AFTER INSERT ON usuario
FOR EACH ROW
BEGIN
    INSERT INTO preferencias (
        usuario,
        atletismo,
        baseball,
        basquete,
        boxe,
        cod,
        cs,
        formula1,
        futebol,
        `futebol americano`,
        golfe,
        judo,
        natacao,
        rocket,
        valorant,
        xadrez
    )
    VALUES (
        NEW.id,
        FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE,
        FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE, FALSE
    );
END;
//

create trigger apagar
before delete on usuario
for each row
begin
    delete from preferencias where usuario = old.id;
end;
//

CREATE PROCEDURE updatepreferences (
    IN p_usuario int,
    IN p_atletismo BOOL,
    IN p_baseball BOOL,
    IN p_basquete BOOL,
    IN p_boxe BOOL,
    IN p_cod BOOL,
    IN p_cs BOOL,
    IN p_formula1 BOOL,
    IN p_futebol BOOL,
    IN p_futebol_americano BOOL,
    IN p_golfe BOOL,
    IN p_judo BOOL,
    IN p_natacao BOOL,
    IN p_rocket BOOL,
    IN p_valorant BOOL,
    IN p_xadrez BOOL
)
BEGIN
    UPDATE preferencias
    SET
        atletismo = p_atletismo,
        baseball = p_baseball,
        basquete = p_basquete,
        boxe = p_boxe,
        cod = p_cod,
        cs = p_cs,
        formula1 = p_formula1,
        futebol = p_futebol,
        `futebol americano` = p_futebol_americano,
        golfe = p_golfe,
        judo = p_judo,
        natacao = p_natacao,
        rocket = p_rocket,
        valorant = p_valorant,
        xadrez = p_xadrez
    WHERE usuario = p_usuario;
END;
//

create procedure updatesenha (in _nome varchar(45), atual bool, nova varchar(255))
begin
    if atual = true then
		update usuario set senha = nova where nome = _nome;
	end if;
end;
//
DELIMITER ;





DELIMITER //


create procedure nfl (in _codigo int, _partidas int, _jardas int, _mediajardas float, _pontos int, _titulos int)
begin
	insert into `futebol americano` values
    (_codigo, _partidas, _jardas, _mediajardas, _pontos, _titulos);
end;
//

create procedure jogadores (in _nome varchar(45), _esporte varchar(45), _nascimento date, _nacionalidade varchar(45), _dataestreia date, _dataAposentadoria date)
begin
	insert into `jogadores` (nome, esporte, nascimento, nacionalidade, `data de estreia`, `data de aposentaria`) values
    (_nome, _esporte, _nascimento, _nacionalidade, _dataestreia, _dataAposentadoria);
end;
//

DELIMITER ;

call jogadores ("Drew Brees", "Futebol americano", "1979-1-15", "Estados Unidos", "2001-11-4", "2021-3-14");
call jogadores ("Tom Brady", "Futebol americano", "1977-8-3", "Estados Unidos", "2000-11-23", "2023-2-1");
call jogadores ("Peyton Manning", "Futebol americano", "1976-3-24", "Estados Unidos", "1998-9-6", "2016-3-7");
call jogadores ("Joe Montana", "Futebol americano", "1956-6-11", "Estados Unidos", "1979-11-11", "1995-4-18");
call jogadores ("Dan Marino", "Futebol americano", "1961-9-15", "Estados Unidos", "1983-9-19", "2000-1-16");

call jogadores ("Lionel Messi", "Futebol", "1987-6-24", "Argentina", "2004-10-16", null);
call jogadores ("Cristiano Ronaldo", "Futebol", "1985-2-5", "Portugal", "2002-09-29", null);
call jogadores ("Miroslav Klose", "Futebol", "1978-6-9", "Polônia", "2000-4-15", "2016-11-1");
call jogadores ("Ronaldo Nazário", "Futebol", "1976-9-18", "Brasil", "1993-5-25", "2011-2-14");
call jogadores ("Erling Haaland", "Futebol", "2000-7-21", "Noruega", "2020-1-18", null);

call jogadores ("Michael Jordan", "Basquete", "1963-2-17", "Estados Unidos", "1984-10-26", "2003-4-16");
call jogadores ("LeBron James", "Basquete", "1984-12-30", "Estados Unidos", "2003-10-29", null);
call jogadores ("Magic Johnson", "Basquete", "1959-08-14","Estados Unidos","1979-10-18","1996-05-14");
call jogadores ("Kobe Bryant","Basquete","1978-08-23","Estados Unidos","1996-11-03","2016-04-13");
call jogadores ("Anthony Edwards","Basquete","2008-08-05"," Estados Unidos","2020-12-23", null);

call jogadores ("Willie Mays", "Baseball", "1931-05-06", "Estados Unidos", "1951-05-25", "1973-10-16");
call jogadores ("Mike Trout", "Baseball", "1991-08-07", "Estados Unidos", "2011-07-08", null);
call jogadores ("Tom Seaver", "Baseball", "1944-11-17", "Estados Unidos", "1967-04-13", "1987-06-20");
call jogadores ("Albert Pujols", "Baseball", "1980-01-16", "República Dominicana", "2001-04-02", "2022-11-01");
call jogadores ("Roberto Clemente", "Baseball", "1934-08-18", "Porto Rico (Estados Unidos)", "1955-04-17", "1972-10-03");


DELIMITER //

create view jogadores_nfl as
	select nome, nascimento, nacionalidade, `data de estreia`, `data de aposentaria`
    from jogadores
    where esporte = "Futebol americano";
//

create view jogadores_futebol as
	select nome, nascimento, nacionalidade, `data de estreia`, `data de aposentaria`
    from jogadores
    where esporte = "Futebol";
//

create view jogadores_basquete as
	select nome, nascimento, nacionalidade, `data de estreia`, `data de aposentaria`
    from jogadores
    where esporte = "basquete";
//

create view jogadores_baseball as
	select nome, nascimento, nacionalidade, `data de estreia`, `data de aposentaria`
    from jogadores
    where esporte = "baseball";
//

