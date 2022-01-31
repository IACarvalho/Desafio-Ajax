# Desafio Ajax de código

## Requisitos para o Front-end
1. Escreva utilizando a tecnologia de front-end que mais se sinta à vontade.
2. Utilizar a biblioteca AXIOS para comunicação com API
3. Utilizar máscaras para os inputs de CEP e CNPJ
4. Na tela de cadastro (inserção/manutenção), após digitar o CEP deve-se utilizar a API do Busca CEP para obter
os demais dados da localidade do fornecedor.
5. Após qualquer alteração o sistema deve notificar ao utilizador que a operação foi ou não concluída. (Mostrar
um toast ou uma caixa de diálogo
6. O campo Data De Inclusão não deve estar presente nas telas de cadastro
7. O campo CEP não deve aceitar letras
8. O campo CNPJ não deve aceitar letras e após ser informado deve ser validado no backend

## Requisitos para o Back-end
1. A Api deve ser escrita utilizando C#
2. Usar uma biblioteca de validação (ex.: FluentValidation)
3. Usar Injeção de Dependência nas Controllers e Repositórios
4. As operações de acesso a dados devem passar por um repositório (usar o REPOSITORIO PATTERN)
	a. Deve haver um repositório base, utilizando o conceito de GENERIC
	b. Os repositórios específicos das entidades devem herdar desse repositório base.
5. Usar o ORM de sua preferência
6. O(s) endpoint(s) de busca devem usar o AUTOMAPPER para retornar um DTO para o frontend