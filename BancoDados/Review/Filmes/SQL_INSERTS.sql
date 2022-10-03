/* INSERT TABELA GENERO*/

insert into genero(nome)
	values ('Acao'), ('Psicologico'), ('Fantasia'), ('Romance')
;

/*INSERT TABELA CLASSIFICACAO
LIVRE - EXIBICAO EM QUALQUER HORARIO
10 ANOS - EXIBICAO EM QUALQUER HORARIO
12 ANOS - A PARTIR DAS 20H
14 ANOS - A PARTIR DAS 21H
16 ANOS - A PARTIR DAS 22H
18 ANOS - A PARTIR DAS 23H
*/

insert into classificacao(label, numlabel, observacao)
	values('Lire', '0', 'exibicao em qualquer horario'),
		  ('10 Anos', '10', 'exibicao em qualquer horario'),
          ('12 Anos', '12', 'A partir das 20h'),
          ('14 Anos', '14', 'A partir das 21h'),
          ('16 Anos', '16', 'A partir das 22h'),
          ('18 Anos', '18', 'A partir das 23h')
;