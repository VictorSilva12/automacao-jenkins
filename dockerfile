# define a imagem base
FROM jenkins/jenkins:lts

# define o mantenedor da imagem
LABEL maintainer="victor.geraldo@concert.com.br"

# Atualiza a imagem com os pacotes
RUN apt-get update && apt-get upgrade -y

# Altera para superuser 
USER root

RUN apt-get install -y apt-transport-https && \
  apt-get update && \
  apt-get install -y aspnetcore-runtime-3.1

# altera para user jenkins
USER jenkins