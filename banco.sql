-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema HenriqueApp
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema HenriqueApp
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `HenriqueApp` DEFAULT CHARACTER SET utf8 ;
USE `HenriqueApp` ;

-- -----------------------------------------------------
-- Table `HenriqueApp`.`Campeonato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `HenriqueApp`.`Campeonato` (
  `idCampeonato` INT NOT NULL,
  `Nome` VARCHAR(50) NULL,
  `Campeonatocol` VARCHAR(45) NULL,
  PRIMARY KEY (`idCampeonato`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `HenriqueApp`.`Times`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `HenriqueApp`.`Times` (
  `idTimes` INT NOT NULL,
  `Nome` VARCHAR(45) NULL,
  PRIMARY KEY (`idTimes`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `HenriqueApp`.`Jogadores`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `HenriqueApp`.`Jogadores` (
  `idJogadores` INT NOT NULL,
  `Nome` VARCHAR(50) NULL,
  `Idade` INT NULL,
  `Gols` INT NULL,
  `Assist` INT NULL,
  `Capitao` INT NULL,
  `Times_idTimes` INT NOT NULL,
  PRIMARY KEY (`idJogadores`),
  INDEX `fk_Jogadores_Times_idx` (`Times_idTimes` ASC) VISIBLE,
  CONSTRAINT `fk_Jogadores_Times`
    FOREIGN KEY (`Times_idTimes`)
    REFERENCES `HenriqueApp`.`Times` (`idTimes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `HenriqueApp`.`Partida`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `HenriqueApp`.`Partida` (
  `idPartida` INT NOT NULL,
  `Gol1` INT NULL,
  `Gol2` INT NULL,
  `Times_idTimes` INT NOT NULL,
  `Times_idTimes1` INT NOT NULL,
  PRIMARY KEY (`idPartida`),
  INDEX `fk_Partida_Times1_idx` (`Times_idTimes` ASC) VISIBLE,
  INDEX `fk_Partida_Times2_idx` (`Times_idTimes1` ASC) VISIBLE,
  CONSTRAINT `fk_Partida_Times1`
    FOREIGN KEY (`Times_idTimes`)
    REFERENCES `HenriqueApp`.`Times` (`idTimes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Partida_Times2`
    FOREIGN KEY (`Times_idTimes1`)
    REFERENCES `HenriqueApp`.`Times` (`idTimes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `HenriqueApp`.`Temporada`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `HenriqueApp`.`Temporada` (
  `idTemporada` INT NOT NULL,
  `Ano` VARCHAR(45) NULL,
  PRIMARY KEY (`idTemporada`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `HenriqueApp`.`TempCamp`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `HenriqueApp`.`TempCamp` (
  `idTempCamp` INT NOT NULL,
  `Premio` VARCHAR(50) NULL,
  `Campeao` VARCHAR(50) NULL,
  `Campeonato_idCampeonato` INT NOT NULL,
  `Temporada_idTemporada` INT NOT NULL,
  PRIMARY KEY (`idTempCamp`),
  INDEX `fk_TempCamp_Campeonato1_idx` (`Campeonato_idCampeonato` ASC) VISIBLE,
  INDEX `fk_TempCamp_Temporada1_idx` (`Temporada_idTemporada` ASC) VISIBLE,
  CONSTRAINT `fk_TempCamp_Campeonato1`
    FOREIGN KEY (`Campeonato_idCampeonato`)
    REFERENCES `HenriqueApp`.`Campeonato` (`idCampeonato`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TempCamp_Temporada1`
    FOREIGN KEY (`Temporada_idTemporada`)
    REFERENCES `HenriqueApp`.`Temporada` (`idTemporada`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `HenriqueApp`.`TimeCampeonato`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `HenriqueApp`.`TimeCampeonato` (
  `idTimeCampeonato` INT NOT NULL,
  `Pontos` INT NULL,
  `Posicao` INT NULL,
  `Golpro` INT NULL,
  `Golcon` INT NULL,
  `Times_idTimes` INT NOT NULL,
  `TempCamp_idTempCamp` INT NOT NULL,
  PRIMARY KEY (`idTimeCampeonato`),
  INDEX `fk_TimeCampeonato_Times1_idx` (`Times_idTimes` ASC) VISIBLE,
  INDEX `fk_TimeCampeonato_TempCamp1_idx` (`TempCamp_idTempCamp` ASC) VISIBLE,
  CONSTRAINT `fk_TimeCampeonato_Times1`
    FOREIGN KEY (`Times_idTimes`)
    REFERENCES `HenriqueApp`.`Times` (`idTimes`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_TimeCampeonato_TempCamp1`
    FOREIGN KEY (`TempCamp_idTempCamp`)
    REFERENCES `HenriqueApp`.`TempCamp` (`idTempCamp`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
