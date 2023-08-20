FROM golang:1.17 as go
RUN GO111MODULE="on" go get sigs.k8s.io/kind@v0.18.0

FROM bitnami/kubectl:1.25.4 as kubectl

FROM docker:20.10.22 AS docker-cli

FROM alpine/helm:3.11.3 AS helm

FROM mcr.microsoft.com/devcontainers/dotnet:7.0-jammy
COPY --from=go /go/bin/kind /usr/local/bin/kind
COPY --from=kubectl /opt/bitnami/kubectl/bin/kubectl /usr/local/bin/kubectl
COPY --from=docker-cli /usr/local/bin/docker /usr/local/bin/
COPY --from=helm /usr/bin/helm /usr/local/bin/helm

RUN curl -sS https://starship.rs/install.sh | sh -s -- --yes

WORKDIR /home/vscode
RUN mkdir -p repos
RUN git clone https://github.com/iaingalloway/env.git repos/env
RUN /bin/su -c "cd /home/vscode/repos/env && ./setup-env.sh" - vscode

WORKDIR /workspaces
