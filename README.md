# Screen Sound

O **Screen Sound** é uma aplicação de console desenvolvida em **C#**, com o objetivo de praticar os conceitos de **Programação Orientada a Objetos (POO)**.  
O sistema permite o cadastro e gerenciamento de **bandas**, avaliação de suas músicas, exibição de médias de avaliações e geração de resumos automáticos das bandas através de integração com a **OpenAI API**.

## Funcionalidades

- Cadastrar bandas
- Listar bandas cadastradas
- Avaliar bandas
- Exibir a média de avaliações de uma banda
- Gerar resumos automáticos das bandas usando **OpenAI API**
- Organização orientada a objetos, com classes representando entidades do domínio (como `Banda` e `Avaliacao`)
- Interação via console (menu textual)

## Conceitos de Programação Orientada a Objetos (POO) Utilizados

O projeto aplica os principais pilares da **POO**:

| Conceito         | Descrição                                                                                 |
|-----------------|-------------------------------------------------------------------------------------------|
| **Encapsulamento** | Cada classe possui seus próprios atributos e métodos, garantindo organização e segurança dos dados. |
| **Abstração**      | As classes representam entidades do mundo real, como bandas e avaliações.              |
| **Herança**        | Pode ser aplicada em classes que compartilham comportamentos comuns (caso o projeto tenha sido expandido). |
| **Polimorfismo**   | Métodos podem ser sobrescritos para comportamentos específicos em diferentes contextos. |
