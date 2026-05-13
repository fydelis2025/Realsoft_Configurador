# ⚙️ Realsoft Configurador

<p align="center">
  <img src="https://img.shields.io/github/languages/top/fydelis2025/Realsoft_Configurador?style=for-the-badge&color=6236FF" alt="Language">
  <img src="https://img.shields.io/github/repo-size/fydelis2025/Realsoft_Configurador?style=for-the-badge" alt="Repo Size">
  <img src="https://img.shields.io/github/last-commit/fydelis2025/Realsoft_Configurador?style=for-the-badge" alt="Last Commit">
</p>

## 👤 Autoria e Histórico
Desenvolvido por **Adiel Santos Fontes**, este sistema é o núcleo de integração de dados da família Realsoft.

*   **Autor:** Adiel Santos Fontes
*   **Data Inicial do Projeto:** Setembro de 2011

O **Realsoft Configurador** é o motor responsável pela comunicação entre a Retaguarda Administrativa e a Frente de Caixa. Sua função principal é buscar e sincronizar os dados do dia a dia no banco de dados, garantindo que as informações operacionais estejam sempre disponíveis para a gestão central.

## 🚀 Funcionalidades
- **Sincronização de Dados:** Busca automatizada de transações diárias do Frente de Caixa para a Retaguarda.
- **Configuração de Ambiente:** Centralização de parâmetros do sistema e variáveis de ambiente.
- **Integridade de Dados:** Validação de fluxos de entrada e saída para evitar inconsistências no banco de dados.
- **Monitoramento Operacional:** Interface para acompanhamento da saúde da comunicação entre os módulos do sistema.

## 🛠️ Stack Técnica
- **Linguagem:** C# (.NET)
- **Tecnologia:** ASP.NET Web Forms
- **Integração:** SQL Server / Manipulação de dados via Classes de Negócio.
- **Segurança:** Camada de autenticação para acesso às configurações críticas.

## 📂 Estrutura do Projeto
*   `/App_Code`: Classes responsáveis pela lógica de busca e persistência de dados.
*   `/Consultas`: Telas para visualização do status das integrações.
*   `/Relatorios`: Logs e resumos das sincronizações realizadas.
*   `Web.config`: Definição de strings de conexão e parâmetros de rede.

## ⚙️ Instalação
1. Clone o repositório:
   ```bash
   git clone [https://github.com/fydelis2025/Realsoft_Configurador.git](https://github.com/fydelis2025/Realsoft_Configurador.git)
