use agenda;
select * from usuario;
select * from turma;# inner join periodo on turma.codPeriodo = periodo.idPeriodo;
INSERT INTO PERIODO (idPeriodo, periodo) VALUES (1, 'MANHÃ');
INSERT INTO PERIODO (idPeriodo, periodo) VALUES (2, 'TARDE');
INSERT INTO PERIODO (idPeriodo, periodo) VALUES (3, 'NOITE');
select * from 