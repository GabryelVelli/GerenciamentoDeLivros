# Gerenciamento de Biblioteca

Este é um sistema simples de gerenciamento de biblioteca, desenvolvido em C#, que permite adicionar livros, listar os livros disponíveis e registrar empréstimos.

## Funcionalidades

O programa oferece as seguintes funcionalidades:

1. **Adicionar Livro**: Permite adicionar um livro à biblioteca, incluindo informações como título, autor e código.
2. **Listar Livros**: Lista todos os livros disponíveis na biblioteca.
3. **Registrar Empréstimo**: Registra o empréstimo de um livro a partir de seu código.

## Estrutura do Projeto

O projeto é composto pelas seguintes classes:

- **Program**: Classe principal que gerencia o menu de interação com o usuário.
- **Biblioteca**: Representa a biblioteca e contém métodos para adicionar livros, listar livros e registrar empréstimos.
- **Livro**: Representa um livro com propriedades como título, autor e código, além de um método para exibir informações do livro.

### Classes

#### `Livro`

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
