![balta](https://baltaio.blob.core.windows.net/static/images/dark/balta-logo.svg)

![Logo do App](https://github.com/balta-io/desafio-balta-may-the-fourth-backend/assets/965305/880fab7e-3998-4a0d-98ad-1d6ffc11298b)

## 🎖️ Desafio
**May the Fourth** é a quarta edição dos **Desafios .NET** realizados pelo [balta.io](https://balta.io). Durante esta jornada, fizemos parte do batalhão backend Renegados, onde unimos forças para entregar um App completo.

## 📱 Projeto
Desenvolvimento de uma API completa, fornecendo recursos como criação, leitura, atualização e exclusão de dados referentes ao universo **Star Wars**.

## Participantes
### 🚀 Capitão
Martinho Sebastião | [GITHUB](https://github.com/martinhosebastiao)

### 💂‍♀️ Batalhão
* Bernardo Meine | [GITHUB](https://github.com/BernardoMeine)
* Mizael Douglas | [GITHUB](https://github.com/mizaeldouglas)
* Mark Souza | [GITHUB](https://github.com/Marksouzza1)


## ⚙️ Tecnologias
* C# 12
* .NET 8
* ASP.NET
* Minimal APIs

## 🥋 Skills Desenvolvidas
* Comunicação
* Trabalho em Equipe
* Networking
* Muito conhecimento técnico

## 🧪 Como testar o projeto com Swagger

##### Link para testar
https://starwars.masinovacoes.com/docs/index.html

##### Endpoint
```c#
  https://starwars.masinovacoes.com/api/v1.1/startwars/
    /getmovies
    /getcharacters
    /getplanets
    /getvehicles
```
##### Endpoint para popular banco de dados
```
https://starwars.masinovacoes.com/api/v1.1/
    /import/fromswapi
```

## 🧪 Como testar o projeto na sua máquina

##### Instalação
- Certifique-se de ter o .NET SDK instalado em sua máquina. Você pode baixar o SDK em https://dotnet.microsoft.com/download.

- A versão do .NET que esta nesse Projeto é o .NET 8.0

- O comando específico para instalar o .NET 8.0 pelo terminal depende do sistema operacional que você está usando.

##### No Windows:
- Com PowerShell:
```bash
  Set-ExecutionPolicy RemoteSigned -Scope CurrentUser
  Install-Module dotnet
  Import-Module dotnet
  Install-Package dotnet-sdk-8.0
  ```
- Com Prompt de Comando:

```bash  
dotnet-install.ps1 -InstallSDK 8.0
```
##### No macOS:
```bash  
brew install dotnet/core/dotnet-sdk8
```
##### No Linux:

- Com Ubuntu:
```bash  
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install dotnet-sdk-8.0
```
- Com outras distros:
- Consulte a documentação do .NET para obter instruções específicas para sua distro: https://docs.microsoft.com/pt-br/dotnet/core/install/linux.

##### Observações:

- Certifique-se de ter um gerenciador de pacotes instalado em sua máquina.
- O comando dotnet-install.ps1 só está disponível no Windows.
- O comando brew só está disponível no macOS.
- Os comandos para Linux podem variar dependendo da sua distro.

##### Clonar o repositorio
```bash
git clone https://github.com/Mizaeldouglas/desafio-balta-may-the-fourth-backend.git
cd desafio-balta-may-the-fourth-backend/StarWars.API
```


##### Iniciar o projeto na sua máquina

```bash
dotnet restore
```
```bash
dotnet clean
```
```bash
dotnet build
```
```bash
dotnet run urls=https://localhost:7271
```

# 💜 Participe
Quer participar dos próximos desafios? Junte-se a [maior comunidade .NET do Brasil 🇧🇷 💜](https://balta.io/discord)
