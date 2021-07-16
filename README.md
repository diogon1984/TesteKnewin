## Bem-vindo


### Projetos

***Números Duplicados***

Passando uma lista de números inteiros separados por vírgula (,), o programa informa em qual indíce existe o primeiro número duplicado.

###### _Execução_

- Basta definir como projeto de inicialização ("Set as StartUp Project") e executar.
- É permitido somente números inteiros e separados por vírgula. Letras e caracteres especiais, não é permitido

<br />

***Palindromo***

Passando uma palavra/frase, o programa identifica se a mesma é ou não é um palindromo, desconsiderando espaço, caracteres especiais, acentuação e case sensitive.
Leva em consideração somente letras e números.

###### _Execução_

- Basta definir como projeto de inicialização ("Set as StartUp Project") e executar.

###### _Roadmap_

- Verificar ser palavras/frases com números é palindromo. Hoje é considerado que sim.

<br />

***API Cidade***

Criação de uma API para consulta, atualização e pesquisa de informações de cidades pré-cadastradas.

###### _Execução_

- Basta definir como projeto de inicialização ("Set as StartUp Project") e executar.
- Na classe **CadastroCidade.Dominio.Misc.Constantes.cs**, alterar o valor da constante _DiretorioPrincipal_ para o caminho do jason com as informações das cidades.
- Copiar o arquivo **Cidade.json** do diretório **..\TesteKnewin\CadastroCidade\wwwroot** e colar no diretório que foi configurado na constante _DiretorioPrincipal_

###### _Roadmap_

- Utilizar um banco de dados ao invés de arquivo texto
- Criar interface "base" para reutilização da código/estrutura
- Criar uma tabela para relacionamento N:N para melhorar a relação das Cidades e suas Fronteiras
