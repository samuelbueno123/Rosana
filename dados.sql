use trabalho;

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



select * from jogadores;

delete from jogadores where codigo = 16;

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

