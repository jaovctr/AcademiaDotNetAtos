-- criando o banco
create database empresa_db;
use empresa_db;

-- tabela departamento
create table departamento(
	idDepartamento integer primary key,
	nome varchar(50) not null,
	localizacao varchar(20) not null,
	orcamento float
);

-- tabela empregado
create table empregado (
	idEmpregado integer primary key,
	nome varchar(50) not null,
	idGerente integer, 
	funcao varchar(30),
	fk_idDepartamento  integer,
	dataAdmissao date not null,
	salario float not null,
	comissao float,
	
	foreign key (idGerente) references empregado(idEmpregado),
	foreign key (fk_idDepartamento) references departamento(idDepartamento)

);


--inserindo dados nas tabelas
INSERT INTO Departamento VALUES('1','Banco de Dados','Porto Alegre','2346');
INSERT INTO Departamento VALUES('2','Balconistas','Pelotas','10000');
INSERT INTO Departamento VALUES('3','Intelig�ncia Artific','Pelotas','333');
INSERT INTO Departamento VALUES('4','Compiladores','Novo Hamburgo','5050');
INSERT INTO Departamento VALUES('5','Redes','Taquara','12122');

INSERT INTO Empregado VALUES('1','Mariewa',NULL,'Gerente','1','2000-04-05','2300','0');
INSERT INTO Empregado VALUES('2','Zico','1','Oper�rio','1','1999-08-13','100','0');
INSERT INTO Empregado VALUES('3','Lula',NULL,'Presidente','5','1950-01-01','10000','0');
INSERT INTO Empregado VALUES('5','Luana Pyovany',NULL,'Gerente','2','1998-06-23','2300','0');
INSERT INTO Empregado VALUES('4','Vera Fixer','5','Balconista','2','1999-05-05','3300','0');
INSERT INTO Empregado VALUES('6','Daniela Schicarelli',NULL,'Gerente','3','1999-10-10','2300','0');
INSERT INTO Empregado VALUES('7','Luize Altenhofen',NULL,'Gerente','4','1999-04-26','2300','0');
INSERT INTO Empregado VALUES('8','Helo Pinheiro',NULL,'Gerente','5','1997-09-25','2300','0');
INSERT INTO Empregado VALUES('9','Pel�','1','Oper�rio','1','2000-09-09','100',NULL);
INSERT INTO Empregado VALUES('10','Rom�rio','1','Oper�rio','5','2001-12-25','100','0');
INSERT INTO Empregado VALUES('11','Malu Mader','5','Balconista','2','2001-10-20','3400','0');
INSERT INTO Empregado VALUES('12','Ant�nio Fagundes','7','Vendedor','3','2002-12-22','5000','10');


-- Sele��o de todos os campos (ou colunas) da tabela de Departamentos.
select * from departamento;

-- Selecione todos os departamentos cujo or�amento mensal seja maior que 10000. Apresente o Nome de tal departamento
--e seu or�amento anual, que ser� obtido multiplicando-se o or�amento mensal por 12.
select nome,orcamento, (orcamento*12) as 'Or�amento anual' from departamento where orcamento>=10000;

-- Apresente a instru��o anterior por�m ao inv�s dos 'feios' DepNome e DepOrca, os T�tulos Departamento e Or�amento.
select nome as 'Departamento',orcamento as 'Or�amento', (orcamento*12) as 'Or�amento anual' from departamento where orcamento>=10000;

-- Apresente todos os cargos existentes na empresa, por�m omita eventuais duplicidades.
select funcao as 'Cargos' from empregado group by funcao;

-- Apresente os nomes e fun��es da cada funcion�rio contidos na tabela empregado, por�m classificados alfabeticamente (A..Z)
--e depois alfabeticamente invertido (Z..A).
select nome as 'Empregado', funcao as 'Cargo' from empregado order by nome;

-- Selecione os Empregados cujos sal�rios sejam menores que 1000 ou maiores que 3500.
select * from empregado where salario between 1000 and 3500;

-- Apresente todos os funcion�rios com sal�rios entre 3400 e 4000 e que sejam balconistas.
select * from empregado where salario between 3400 and 4000 and funcao='Balconista';

-- Apresente o nome de todos os empregados em letras min�sculas.
select lower(nome) from empregado;

-- Apresente o nome de todos os empregados (somente as 5 primeiras letras).
select SUBSTRING(nome,1,5) from empregado;

-- Apresente a M�dia, o Maior, o Menor e tamb�m a Somat�ria dos Sal�rios pagos aos empregados.
select AVG(salario) as 'M�dia', MIN(salario) as 'Menor', MAX(salario) as 'Maior' from empregado;

-- Apresente a m�dia de comiss�o pagos por departamento.
select departamento.nome as 'Departamento', avg(comissao) as 'Comiss�o' from departamento inner join empregado on idDepartamento=fk_idDepartamento group by departamento.nome; 

--  Retome o problema anterior, por�m apresente resposta
--apenas para departamentos com mais de 2 empregados.
select departamento.nome as 'Departamento', avg(comissao) as 'Comiss�o' from empregado inner join departamento on idDepartamento=fk_idDepartamento group by departamento.nome having count(fk_idDepartamento)>=2; 

-- Listar Nomes de Empregados, Cargos e Nome do Departamento onde o empregado trabalha.
select empregado.nome as 'Funcionario', funcao as 'Cargo', departamento.nome as 'Departamento' from empregado inner join departamento on idDepartamento=fk_idDepartamento;

-- Liste os C�digos de Cada Funcion�rio, seus Nomes, seus Cargos e o nome do Gerente ao qual este se relaciona.
select idEmpregado, nome, funcao, (select nome as 'Gerente' from empregado where idEmpregado=emp.idGerente) from empregado as emp;

-- execute e avalie os comandos
-- INSERT
INSERT INTO Departamento (idDepartamento, nome, localizacao, orcamento) VALUES ('70','PRODUCAO','RIO DE JANEIRO','1200');
-- Adicionou o departamento produ��o no id 70, localiza��o Rio de janeiro e or�amento igual a 1200

-- UPDATE
UPDATE Empregado SET Empregado.salario = Empregado.salario* 1.2 WHERE Empregado.salario< 1000;
-- aumentou o sal�rio dos empregados em 20% para toos aqueles que recebem menos de 1000

-- DELETE
DELETE FROM Empregado WHERE Empregado.salario > 5000;
-- Apagou o Presidente Lula do quadro de empregados pois seu sal�rio era maior que 5000

-- Relacione todos os nomes de funcion�rios e seus respectivos cargos, desde que o or�amento do departamento seja igual a 10000.
select empregado.nome as 'Nome' ,funcao as 'Funcao' from empregado inner join departamento on idDepartamento=fk_idDepartamento where departamento.orcamento>10000;

-- Relacione todos os departamentos que possuem empregados com remunera��o maior que 3000.
select departamento.nome, localizacao, orcamento from departamento inner join empregado on idDepartamento=fk_idDepartamento where empregado.salario>3000 group by departamento.nome,departamento.localizacao,departamento.orcamento;