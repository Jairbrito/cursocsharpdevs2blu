UPDATE pessoa
	SET datanascimento = '1998-02-22',
		idade = '24'
WHERE id IN (2, 3, 4)
;

UPDATE pessoa
	SET datanascimento = '1995-02-22',
		idade = '27'
WHERE id IN (5, 6 , 7, 8)
;