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

ALTER TABLE jogadores
ADD foto VARCHAR(255) NULL;



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

use trabalho;

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

use trabalho;

DELIMITER //


create procedure nfl (in _codigo int, _partidas int, _jardas int, _mediajardas float, _pontos int, _titulos int)
begin
	insert into `futebol americano` values
    (_codigo, _partidas, _jardas, _mediajardas, _pontos, _titulos);
end;
//

DROP PROCEDURE IF EXISTS jogadores;
DELIMITER //

CREATE PROCEDURE jogadores (
  IN _nome VARCHAR(45),
  IN _esporte VARCHAR(45),
  IN _nascimento DATE,
  IN _nacionalidade VARCHAR(45),
  IN _dataestreia DATE,
  IN _dataAposentadoria DATE,
  IN _foto VARCHAR(255)
)
BEGIN
  INSERT INTO jogadores (nome, esporte, nascimento, nacionalidade, `data de estreia`, `data de aposentaria`, foto)
  VALUES (_nome, _esporte, _nascimento, _nacionalidade, _dataestreia, _dataAposentadoria, _foto);
END //

create view jogadores_esporte as
	select nome, nascimento, nacionalidade, `data de estreia`, `data de aposentaria`, esporte
    from jogadores;
//

DELIMITER ;
call jogadores ("Drew Brees", "Futebol americano", "1979-1-15", "Estados Unidos", "2001-11-4", "2021-3-14", "drew.jpg");
call jogadores ("Tom Brady", "Futebol americano", "1977-8-3", "Estados Unidos", "2000-11-23", "2023-2-1", "tom.jpg");
call jogadores ("Peyton Manning", "Futebol americano", "1976-3-24", "Estados Unidos", "1998-9-6", "2016-3-7", "peyton.jpg");
call jogadores ("Joe Montana", "Futebol americano", "1956-6-11", "Estados Unidos", "1979-11-11", "1995-4-18", "joe_montana.jpg");
call jogadores ("Dan Marino", "Futebol americano", "1961-9-15", "Estados Unidos", "1983-9-19", "2000-1-16", "dan.jpg");

call jogadores ("Miroslav Klose", "Futebol", "1978-6-9", "Polônia", "2000-4-15", "2016-11-1", "miroslav.jpeg");
call jogadores ("Ronaldo Nazário", "Futebol", "1976-9-18", "Brasil", "1993-5-25", "2011-2-14", "ronaldo.png");
call jogadores ("Erling Haaland", "Futebol", "2000-7-21", "Noruega", "2020-1-18", null, "erling.jpg");

call jogadores ("Michael Jordan", "Basquete", "1963-2-17", "Estados Unidos", "1984-10-26", "2003-4-16", "michael.jpg");
call jogadores ("LeBron James", "Basquete", "1984-12-30", "Estados Unidos", "2003-10-29", null, "lebron.jpg");
call jogadores ("Magic Johnson", "Basquete", "1959-08-14","Estados Unidos","1979-10-18","1996-05-14", "magic.jpg");
call jogadores ("Kobe Bryant","Basquete","1978-08-23","Estados Unidos","1996-11-03","2016-04-13", "kobe.jpg");
call jogadores ("Anthony Edwards","Basquete","2008-08-05"," Estados Unidos","2020-12-23", null, "anthony.jpg");

call jogadores ("Usain Bolt", "atletismo", "1986-08-21", "Jamaica", "2004-07-31", "2017-08-12", "usain.jpg");
call jogadores ("Yohan Blake", "atletismo", "1989-12-26", "Jamaica", "2007-06-13", null, "yohan.jpg");
call jogadores ("Mo Farah", "atletismo", "1983-03-23", "Reino Unido", "2005-03-12", null, "mo.jpg");
call jogadores ("Allyson Felix", "atletismo", "1985-11-18", "Estados Unidos", "2003-07-25", "2022-07-24", "allyson.jpg");
call jogadores ("Carl Lewis", "atletismo", "1961-07-01", "Estados Unidos", "1979-06-01", "1997-08-01", "carl.jpg");

call jogadores ("Babe Ruth", "baseball", "1895-02-06", "Estados Unidos", "1914-07-11", "1935-05-30", "babe.jpg");
call jogadores ("Mickey Mantle", "baseball", "1931-10-20", "Estados Unidos", "1951-04-17", "1968-09-28", "mickey.jpg");
call jogadores ("Ichiro Suzuki", "baseball", "1973-10-22", "Japão", "2001-04-02", "2018-05-03", "ichiro.jpg");
call jogadores ("Jackie Robinson", "baseball", "1919-01-31", "Estados Unidos", "1947-04-15", "1956-09-30", "jackie.jpg");
call jogadores ("Barry Bonds", "baseball", "1964-07-24", "Estados Unidos", "1986-05-30", "2007-09-26", "barry.png");

call jogadores ("Muhammad Ali", "boxe", "1942-01-17", "Estados Unidos", "1960-10-29", "1981-12-11", "muhammad.jpg");
call jogadores ("Mike Tyson", "boxe", "1966-06-30", "Estados Unidos", "1985-03-06", "2005-06-11", "mike.jpg");
call jogadores ("Manny Pacquiao", "boxe", "1978-12-17", "Filipinas", "1995-01-22", "2021-08-21", "manny.jpg");
call jogadores ("Floyd Mayweather Jr.", "boxe", "1977-02-24", "Estados Unidos", "1996-10-11", "2017-08-26", "floyd.jpg");
call jogadores ("Joe Frazier", "boxe", "1944-01-12", "Estados Unidos", "1965-08-16", "1981-12-11", "joe.jpg");

call jogadores ("Ayrton Senna", "formula1", "1960-03-21", "Brasil", "1984-03-25", "1994-05-01", "ayrton.jpg");
call jogadores ("Lewis Hamilton", "formula1", "1985-01-07", "Reino Unido", "2007-03-18", null, "lewis.jpg");
call jogadores ("Michael Schumacher", "formula1", "1969-01-03", "Alemanha", "1991-08-25", "2012-11-25", "schumacher.jpg");
call jogadores ("Sebastian Vettel", "formula1", "1987-07-03", "Alemanha", "2007-06-17", "2022-11-20", "sebastian.jpg");
call jogadores ("Max Verstappen", "formula1", "1997-09-30", "Holanda", "2015-03-15", null, "max.jpg");

call jogadores ("Pelé", "futebol", "1940-10-23", "Brasil", "1956-09-07", "1977-10-01", "pele.jpg");
call jogadores ("Lionel Messi", "futebol", "1987-06-24", "Argentina", "2004-10-16", null, "lionel.jpg");
call jogadores ("Cristiano Ronaldo", "futebol", "1985-02-05", "Portugal", "2002-08-14", null, "cristiano.jpg");
call jogadores ("Neymar Jr.", "futebol", "1992-02-05", "Brasil", "2009-03-07", null, "neymar.jpg");
call jogadores ("Kylian Mbappé", "futebol", "1998-12-20", "França", "2015-12-02", null, "kylian.jpg");

call jogadores ("Tiger Woods", "golfe", "1975-12-30", "Estados Unidos", "1996-08-29", null, "tiger.jpg");
call jogadores ("Jack Nicklaus", "golfe", "1940-01-21", "Estados Unidos", "1962-01-01", "2005-07-15", "jack.jpg");
call jogadores ("Rory McIlroy", "golfe", "1989-05-04", "Irlanda do Norte", "2007-01-01", null, "rory.jpg");
call jogadores ("Phil Mickelson", "golfe", "1970-06-16", "Estados Unidos", "1992-01-01", null, "phil.jpg");
call jogadores ("Jordan Spieth", "golfe", "1993-07-27", "Estados Unidos", "2012-01-01", null, "jordan_spieth.webp");

call jogadores ("Teddy Riner", "judo", "1989-04-07", "França", "2007-09-01", null, "teddy.jpg");
call jogadores ("Ryoko Tani", "judo", "1975-09-06", "Japão", "1993-05-01", "2008-08-15", "ryoko.jpg");
call jogadores ("David Douillet", "judo", "1969-02-17", "França", "1991-09-01", "2000-10-20", "david.jpg");
call jogadores ("Rafaela Silva", "judo", "1992-04-24", "Brasil", "2011-02-01", null, "rafaela.jpg");
call jogadores ("Shohei Ono", "judo", "1992-02-03", "Japão", "2012-01-01", null, "shohei.jpg");

call jogadores ("Michael Phelps", "natacao", "1985-06-30", "Estados Unidos", "2000-09-09", "2016-08-13", "phelps.jpg");
call jogadores ("Katie Ledecky", "natacao", "1997-03-17", "Estados Unidos", "2012-06-30", null, "katie.jpg");
call jogadores ("César Cielo", "natacao", "1987-01-10", "Brasil", "2006-08-02", null, "cesar.jpg");
call jogadores ("Ian Thorpe", "natacao", "1982-10-13", "Austrália", "1997-01-01", "2014-11-01", "ianthorpe.jpg");
call jogadores ("Mark Spitz", "natacao", "1950-02-10", "Estados Unidos", "1968-10-12", "1972-09-04", "mark.jpg");

call jogadores ("Magnus Carlsen", "xadrez", "1990-11-30", "Noruega", "2004-01-01", null, "magnus.png");
call jogadores ("Garry Kasparov", "xadrez", "1963-04-13", "Rússia", "1978-01-01", "2005-03-10", "garry.jpg");
call jogadores ("Hikaru Nakamura", "xadrez", "1987-12-09", "Estados Unidos", "1998-01-01", null, "hikaru.png");
call jogadores ("Bobby Fischer", "xadrez", "1943-03-09", "Estados Unidos", "1957-01-01", "1972-01-01", "bobby.jpg");
call jogadores ("Ian Nepomniachtchi", "xadrez", "1990-07-14", "Rússia", "2006-01-01", null, "ian.png");

-- E-SPORTS --//

call jogadores ("aspas", "valorant", "2003-06-12", "Brasil", "2020-10-01", null, "aspas.png");
call jogadores ("yay", "valorant", "1998-09-09", "Estados Unidos", "2020-04-07", null, "yay.png");
call jogadores ("TenZ", "valorant", "2001-05-05", "Canadá", "2020-04-07", null, "tenz.png");
call jogadores ("Derke", "valorant", "2003-02-06", "Finlândia", "2021-02-26", null, "derke.png");
call jogadores ("Cryocells", "valorant", "2003-09-19", "Estados Unidos", "2021-01-01", null, "cryocells.png");

call jogadores ("jstn", "rocket", "2002-08-05", "Estados Unidos", "2017-10-01", null, "jstn.png");
call jogadores ("GarrettG", "rocket", "2000-04-06", "Estados Unidos", "2016-01-01", null, "garrettg.png");
call jogadores ("SquishyMuffinz", "rocket", "2000-11-29", "Canadá", "2016-07-01", null, "squishy.jpg");
call jogadores ("Firstkiller", "rocket", "2004-10-19", "Estados Unidos", "2019-01-01", null, "firstkiller.jpg");
call jogadores ("Kaydop", "rocket", "1998-05-24", "França", "2015-01-01", null, "kaydop.png");

call jogadores ("s1mple", "cs", "1997-10-02", "Ucrânia", "2013-10-17", null, "s1mple.png");
call jogadores ("coldzera", "cs", "1994-10-31", "Brasil", "2012-02-01", null, "coldzera.png");
call jogadores ("fallen", "cs", "1991-06-02", "Brasil", "2005-01-01", null, "fallen.png");
call jogadores ("ZywOo", "cs", "2000-11-09", "França", "2018-09-01", null, "zywoo.png");
call jogadores ("device", "cs", "1995-12-31", "Dinamarca", "2013-01-01", null, "device.png");

call jogadores ("Scump", "cod", "1995-06-30", "Estados Unidos", "2011-01-01", "2023-01-17", "scump.png");
call jogadores ("Crimsix", "cod", "1993-05-29", "Estados Unidos", "2012-01-01", "2022-11-28", "crimsix.png");
call jogadores ("FormaL", "cod", "1994-12-19", "Estados Unidos", "2013-01-01", "2022-01-01", "formal.png");
call jogadores ("Cellium", "cod", "2000-12-12", "Estados Unidos", "2019-01-01", null, "cellium.png");
call jogadores ("Shotzzy", "cod", "2001-07-04", "Estados Unidos", "2019-01-01", null, "shotzzy.png");