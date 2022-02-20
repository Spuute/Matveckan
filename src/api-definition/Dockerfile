FROM alpine:3.14

EXPOSE 35101

RUN apk add --update nodejs npm
RUN npm install -g @stoplight/prism-cli@4.6.1

WORKDIR /app
COPY ./matveckan.oas.yaml ./

ENTRYPOINT ["prism", "mock", "matveckan.oas.yaml", "-h", "0.0.0.0", "--port", "35101"]