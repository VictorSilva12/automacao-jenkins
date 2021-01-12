# define a imagem base
FROM jenkins/jenkins:lts

# define o mantenedor da imagem
LABEL maintainer="victor.geraldo@concert.com.br"

# Atualiza a imagem com os pacotes
RUN sudo apt-get update && apt-get upgrade -y

RUN sudo apt-get install -y apt-transport-https && \
  sudo apt-get update && \
  sudo apt-get install -y aspnetcore-runtime-3.1
