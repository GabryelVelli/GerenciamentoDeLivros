# Gerenciamento de Biblioteca

Este projeto é um sistema de gerenciamento de biblioteca desenvolvido em **C#**. Ele permite adicionar livros, listar os livros cadastrados e registrar empréstimos de forma simples e intuitiva.

## Funcionalidades

- **Adicionar Livro**: Insira informações como título, autor e código do livro para adicioná-lo à biblioteca.
- **Listar Livros**: Veja todos os livros cadastrados, com detalhes como título, autor e código.
- **Registrar Empréstimo**: Empreste um livro informando o código correspondente.
- **Interface Interativa**: Menu no console para navegar entre as opções.

## Estrutura do Projeto

O projeto é organizado da seguinte forma:

### Classes

#### `Program`

Classe principal que gerencia o menu e interações com o usuário. Exibe as opções disponíveis e chama os métodos apropriados da classe `Biblioteca`.

#### `Biblioteca`

Responsável pelo gerenciamento dos livros. Contém os seguintes métodos:

- **`AdicionarLivro(Livro livro)`**: Adiciona um novo livro ao sistema.
- **`ListarLivros()`**: Exibe todos os livros cadastrados.
- **`RegistrarEmprestimo(int codigo)`**: Procura um livro pelo código e registra o empréstimo.

#### `Livro`

Representa um livro com os seguintes atributos:
- **`Titulo`**: Título do livro.
- **`Autor`**: Autor do livro.
- **`Codigo`**: Código único para identificar o livro.

Além disso, inclui o método `ExibirInfo()` para exibir os detalhes do livro.


Representa um livro com as seguintes propriedades:
- `Titulo` (string): Título do livro.
- `Autor` (string): Autor do livro.
- `Codigo` (int): Código único do livro.

Métodos:
- `ExibirInfo()`: Exibe as informações do livro.

#### `Biblioteca`

Representa a biblioteca com as seguintes funcionalidades:
- Armazenamento de livros em um array.
- Métodos para adicionar, listar e registrar empréstimos.
