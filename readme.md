# How to build

## Single containers

`docker build -f API/Tea/Dockerfile . -t teaapi:latest`\
`docker build -f API/Coffee/Dockerfile . -t coffeeapi:latest`

## All container via compose

`docker compose up --build`
