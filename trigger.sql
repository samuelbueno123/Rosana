use trabalho;

select * from usuario;

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
    
    select * from preferencias;
    
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
