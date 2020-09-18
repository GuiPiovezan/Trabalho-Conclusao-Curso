CREATE DATABASE AGENDA;
USE AGENDA;
#CRIANDO A TABELA UNIDADE
CREATE TABLE UNIDADE
(
  idEscola int auto_increment primary key NOT NULL,
  nomeUnidade varchar(45),
  enderecoUnidade varchar(50),
  emailUnidade varchar(45),
  telefoneUnidade varchar(45)
);
#CRIANDO A TABELA CURSO
CREATE TABLE CURSO
(
 idCurso int primary key auto_increment NOT NULL,
 coordenador varchar(45),
 descricao VARCHAR (45),
 tipoCurso VARCHAR(7),
 anoCurso VARCHAR(4),
 codUnidade int,
 CONSTRAINT FK_CODUNIDADE_CURSO FOREIGN KEY (codUnidade) REFERENCES UNIDADE (idEscola)
);
 #CRIANDO A TABELA PERIODO
 CREATE TABLE PERIODO
 (
  idPeriodo INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  periodo VARCHAR (10)
 );
#CRIANDO A TABELA TURMA
CREATE TABLE TURMA 
(
 idTurma int primary key auto_increment NOT NULL,
 descricao VARCHAR (45),
 codCurso int,
 codPeriodo INT,
 CONSTRAINT FK_COD_TURMA_PERIODO FOREIGN KEY (codPeriodo) REFERENCES PERIODO (idPeriodo),
 CONSTRAINT FK_CODCURSO_TURMA FOREIGN KEY (codCurso) REFERENCES CURSO (idCurso)
);
#CRIANDO A TABELA DISCIPLINA
CREATE TABLE DISCIPLINA
(
 idDisciplina INT PRIMARY KEY NOT NULL AUTO_INCREMENT,
 disciplina VARCHAR (30)
);
#CRIANDO A TABELA AULA 
 CREATE TABLE AULA
 (
  idAula INT PRIMARY KEY AUTO_INCREMENT NOT NULL,
  dataAula VARCHAR(10),
  descricao VARCHAR (45),
  locall VARCHAR(45),
  horaInicio VARCHAR(5),
  horaTermino VARCHAR(5),
  codTurma INT,
  codDisciplina INT,
  CONSTRAINT FK_COD_TURMA_AULA FOREIGN KEY (codTurma) REFERENCES TURMA (idTurma),
  CONSTRAINT fk_COD_DISCIPLINA_AULA FOREIGN KEY (codDisciplina) REFERENCES DISCIPLINA (idDisciplina)
);
DROP TABLE AULA;
 #CRIANDO A TABELA ITENS_TURMA_USUARIO
 CREATE TABLE ITENS_TURMA_USUARIO
 (
  id_Itens_Turma_Usuario INT primary key NOT NULL AUTO_INCREMENT,
  codTurma INT, 
  codUsuario INT,
  CONSTRAINT FK_COD_ITENS_TURMA FOREIGN KEY (codTurma) REFERENCES TURMA (idTurma),
  CONSTRAINT FK_ITENS_USUARIO FOREIGN KEY (codUsuario) REFERENCES USUARIO (idUsuario)
 );
#CRIANDO A TABELA USUARIO
 CREATE TABLE USUARIO
 (
  idUsuario int primary key auto_increment not null,
  email varchar(45),
  senha varchar(20),
  nome varchar(45),
  telefone varchar (14),
  dataNascimento VARCHAR(10),
  codTipoUsuario int,
  CONSTRAINT FK_COD_TIPO_USUARIO foreign key (codTipoUsuario) REFERENCES TIPO_USUARIO (idTipoUsuario)
 );
 #CRIANDO TABELA TIPO_USUARIO
 CREATE TABLE TIPO_USUARIO
 (
  idTipoUsuario int primary key auto_increment not null,
  tipoUsuario varchar(15)
 );
  /*INSERIDO USUÁRIOS DO TIPO ALUNO = 1 E PROFESSOR = 2*/
 INSERT INTO TIPO_USUARIO (idTipoUsuario, tipoUsuario) VALUES (1,'ALUNO');
 INSERT INTO TIPO_USUARIO (idTipoUsuario, tipoUsuario) VALUES (2, 'PROFESSOR');
 SELECT idTipoUsuario AS 'IDENTIFICADOR', tipoUsuario AS 'Tipo de Usuário'  FROM TIPO_USUARIO;
 #CRIANDO A TABELA ITENS MURAL
 CREATE TABLE MURAL
 (
 idMural int primary key auto_increment not null,
 descricao varchar (250), 
 codUsuario int,
 CONSTRAINT FK_CODUSUARIO_MURAL FOREIGN KEY (codUsuario) REFERENCES USUARIO (idUsuario)
 );

