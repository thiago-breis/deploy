# Usa a imagem oficial do SDK do .NET 8 como base
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

# Define o diret�rio de trabalho dentro do container
WORKDIR /app

# Copia os arquivos do projeto para o diret�rio de trabalho
COPY . .

# Restaura as depend�ncias e compila o projeto
RUN dotnet restore
RUN dotnet build -c Release -o /app/build

# Define a imagem de publica��o
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime

# Define o diret�rio de trabalho dentro do container
WORKDIR /app

# Copia os arquivos de constru��o do est�gio de compila��o
COPY --from=build /app/build .

# Exponha a porta que sua aplica��o ser� executada
EXPOSE 8080
EXPOSE 8081

# Inicia a aplica��o
ENTRYPOINT ["dotnet", "BoraApi.dll"]
