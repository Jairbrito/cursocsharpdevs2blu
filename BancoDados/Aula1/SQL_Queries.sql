select	id,
		nome,
		datanascimento,
        idade,
        status
from	pessoa
;

select id,
	   id_pessoa,
       login,
       senha,
       status
from usuario
;

SELECT p.id as id_pessoa,
	   u.id as id_usuario,
	   p.nome,
       p.login,
       p.senha,
       p.datanascimento as nascimento,
       p.status as situacao_pessoa,
       u.login,
       u.senha,
       u.status as status_usuario
FROM pessoa as p
JOIN usuario as u
	ON (p.id = u.id_pessoa)
;

SELECT *
FROM pessoa
WHERE datanascimento < '1998-01-01'
;