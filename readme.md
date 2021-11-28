# Api Gateway Test / Envoy

## Application Setup / Ports

Since all is running in containers, default app port is 80/443 and we can leave default Dapr ports (3500/50001/9090).

| Service           | App Port         | Dapr HTTP port | Dapr gRPC port | Dapr metrics port |
|-------------------|------------------|----------------|----------------|-------------------|
| envoy             | 10000,10001      | 3500           | 50001          | 9090              |
| coffee-api        | 8080:80,8081:443 | 3500           | 50001          | 9090              |
| tea-api           | 8082:80,8083:443 | 3500           | 50001          | 9090              |

## How to build

### Single containers

`docker build -f API/Tea/Dockerfile . -t tea-api:latest`\
`docker build -f API/Coffee/Dockerfile . -t coffee-api:latest`

### All container via compose

`docker compose up --build`

## How to run

Navigate to:

- Coffee: `http://localhost:10000/c/` or `http://localhost:10000/coffee/` or `https://localhost:10000/c/` or `https://localhost:10000/coffee/`
- Tea: `http://localhost:10000/t/` or `http://localhost:10000/tea/` or `https://localhost:10000/t/` or `https://localhost:10000/tea/`

### Certificates

`openssl req -config https.config -new -out csr.pem`

`openssl x509 -req -days 365 -extfile https.config -extensions v3_req -in csr.pem -signkey key.pem -out https.crt`
