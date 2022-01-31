# Desafio Ajax de c�digo

## Requisitos para o Front-end
1. Escreva utilizando a tecnologia de front-end que mais se sinta � vontade.
2. Utilizar a biblioteca AXIOS para comunica��o com API
3. Utilizar m�scaras para os inputs de CEP e CNPJ
4. Na tela de cadastro (inser��o/manuten��o), ap�s digitar o CEP deve-se utilizar a API do Busca CEP para obter
os demais dados da localidade do fornecedor.
5. Ap�s qualquer altera��o o sistema deve notificar ao utilizador que a opera��o foi ou n�o conclu�da. (Mostrar
um toast ou uma caixa de di�logo
6. O campo Data De Inclus�o n�o deve estar presente nas telas de cadastro
7. O campo CEP n�o deve aceitar letras
8. O campo CNPJ n�o deve aceitar letras e ap�s ser informado deve ser validado no backend

## Requisitos para o Back-end
1. A Api deve ser escrita utilizando C#
2. Usar uma biblioteca de valida��o (ex.: FluentValidation)
3. Usar Inje��o de Depend�ncia nas Controllers e Reposit�rios
4. As opera��es de acesso a dados devem passar por um reposit�rio (usar o REPOSITORIO PATTERN)
	a. Deve haver um reposit�rio base, utilizando o conceito de GENERIC
	b. Os reposit�rios espec�ficos das entidades devem herdar desse reposit�rio base.
5. Usar o ORM de sua prefer�ncia
6. O(s) endpoint(s) de busca devem usar o AUTOMAPPER para retornar um DTO para o frontend