# Api Gateway Test / Envoy

## Application Setup / Ports

Since all is running in containers, default app port is 80/443 and we can leave default Dapr ports (3500/50001/9090).

| Service           | App Port    | Dapr HTTP port | Dapr gRPC port | Dapr metrics port |
|-------------------|-------------|----------------|----------------|-------------------|
| envoy             | 10000       | 10001          | 10002          |                   |
| coffee-api        | 8080,8081   | 3500           | 50001          | 9090              |
| tea-api           | 8082,8083   | 3500           | 50001          | 9090              |

## How to build

### Single containers

`docker build -f API/Tea/Dockerfile . -t tea-api:latest`\
`docker build -f API/Coffee/Dockerfile . -t coffee-api:latest`

### All container via compose

`docker compose up --build`
