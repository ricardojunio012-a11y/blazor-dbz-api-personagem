# blazor-dbz-api-personagem

Lista de Exercícios — Desenvolvimento Web (Usabilidade, Dev. Web, Mobile e Jogos)
Professor Daniel Henrique Matos de Paiva

Aplicação **Blazor** (.NET 8) chamada `BlazorDbzPersonagem` que pede o **id** de um personagem de
Dragon Ball, consome o endpoint `https://dragonball-api.com/api/characters/{id}` e mostra na tela:

- **Nome**
- **Planeta** de origem
- **Transformações** (com o Ki de cada uma)

Exemplo com o id `1`:

```
Nome: Goku
Planeta: Tierra
Transformações:
  Goku SSJ (Ki: 3 Billion)
  Goku SSJ2 (Ki: 6 Billion)
  ...
```

Se o id não existir, a tela avisa que nenhum personagem foi encontrado.

## Como executar

```bash
dotnet run
```

Depois abra o endereço mostrado no terminal (ex.: `http://localhost:5125`).

## Estrutura

- `Models/Personagem.cs` — modelos `Personagem`, `Planeta` e `Transformacao`
- `Services/PersonagemService.cs` — consumo da API com `HttpClient`
- `Program.cs` — registro do serviço
- `Components/Pages/Home.razor` — formulário do id e exibição na tela
