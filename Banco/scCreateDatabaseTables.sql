
CREATE DATABASE dbsistvet2023;

USE dbsistvet2023;

CREATE TABLE tblEspecies
(
	espid   int      not null Primary key,
	espnome varchar  (50) not null
);


CREATE TABLE tblAnimais
(
	aniid          int        not null PRIMARY KEY,
	aninome        varchar(50)not null,
	aniapelido     varchar(25)not null,
	anidatanasc    date       not null,
	aniobservacoes varchar(500),
	aniespid       int        not null,
	FOREIGN KEY (aniespid) REFERENCES tblEspecies (espid)
);

CREATE TABLE tblClientes
(
	cliid           int          not null PRIMARY KEY,
	clinome         varchar(50)  not null,
	clicpf          decimal(11)  not null,
	cliemail        varchar(100) not null,
	clidatacadastro date         not null	
);

CREATE TABLE tblAnimaisClientes
(
	cliid int not null,
	aniid int not null,
	PRIMARY KEY (cliid, aniid), 
	FOREIGN KEY (cliid)REFERENCES tblClientes (cliid),
	FOREIGN KEY (aniid) REFERENCES tblAnimais (aniid)
);

INSERT INTO tblEspecies (espid, espnome) VALUES (1, 'Cachorro');
INSERT INTO tblEspecies (espid, espnome) VALUES (2, 'Gato');
INSERT INTO tblEspecies (espid, espnome) VALUES (3, 'Pássaro');
INSERT INTO tblEspecies (espid, espnome) VALUES (4, 'Coelho');
INSERT INTO tblEspecies (espid, espnome) VALUES (5, 'Peixe');
INSERT INTO tblEspecies (espid, espnome) VALUES (6, 'Cavalo');

SELECT * FROM tblEspecies;



INSERT INTO tblAnimais (aniid, aninome, aniapelido, anidatanasc, aniobservacoes, aniespid) 
VALUES (1, 'Biscoito', 'Cachorro', '2020-05-15', 'Cachorro amigável e brincalhão', 1);
INSERT INTO tblAnimais (aniid, aninome, aniapelido, anidatanasc, aniobservacoes, aniespid) 
VALUES (2, 'Felix', 'Gato', '2019-08-10', 'Gato de pelo longo e preto', 2);
INSERT INTO tblAnimais (aniid, aninome, aniapelido, anidatanasc, aniobservacoes, aniespid) 
VALUES (3, 'Loro', 'Papagaio', '2018-03-20', 'Papagaio falante e colorido', 3);
INSERT INTO tblAnimais (aniid, aninome, aniapelido, anidatanasc, aniespid) 
VALUES (4, 'Tambor', 'Coelho', '2021-02-05', 4);
INSERT INTO tblAnimais (aniid, aninome, aniapelido, anidatanasc, aniobservacoes, aniespid) 
VALUES (5, 'Nemo', 'Peixe-palhaço', '2017-11-25', 'Peixe colorido e amigável', 5);
INSERT INTO tblAnimais (aniid, aninome, aniapelido, anidatanasc, aniespid) 
VALUES (6, 'Açucar', 'Cavalo', '2015-06-08', 6);

SELECT * FROM tblAnimais


INSERT INTO tblClientes (cliid, clinome, clicpf, cliemail, clidatacadastro)
VALUES
  (1, 'Maria Silva', 12345678901, 'maria@email.com', '2022-01-10'),
  (2, 'João Santos', 98765432109, 'joao@email.com', '2021-12-05'),
  (3, 'Ana Pereira', 45678901234, 'ana@email.com', '2022-02-20'),
  (4, 'Pedro Souza', 78901234567, 'pedro@email.com', '2021-11-15'),
  (5, 'Lucia Oliveira', 23456789012, 'lucia@email.com', '2022-03-25'),
  (6, 'Carlos Rodrigues', 56789012345, 'carlos@email.com', '2021-10-30');
  
SELECT * FROM tblClientes;
DELETE FROM tblClientes WHERE cliid = 8;
INSERT INTO tblAnimaisClientes (cliid, aniid)
VALUES
  (1, 3),
  (2, 1),
  (3, 4),
  (4, 6),
  (5, 2),
  (6, 5);
  
  SELECT * FROM tblAnimaisClientes;
  
  SELECT *
FROM tblAnimaisClientes AS AC
INNER JOIN tblClientes AS C ON AC.cliid = C.cliid
INNER JOIN tblAnimais AS A ON AC.aniid = A.aniid;

CREATE TABLE tblUsuarios
(
usuid int not null PRIMARY KEY,
usunome varchar (100) not null,
usulogin varchar (25) not null,
ususenha varchar (25) not null,
usuemail varchar (50) not null,
usuobservacoes varchar (500)
);

insert into tblUsuarios (usuid, usunome, usulogin, ususenha, usuemail, usuobservacoes)
values
(1, 'Ronaldo Caravieri', 'rcsfilho', '16111987', 'ronaldo.fil@aluno.unip.br', 'Usuário Master');

SELECT * FROM tblUsuarios;


SELECT ac.cliid, c.clinome, ac.aniid, a.aninome
FROM tblAnimaisClientes ac
INNER JOIN tblClientes c ON ac.cliid = c.cliid
INNER JOIN tblAnimais a ON ac.aniid = a.aniid;