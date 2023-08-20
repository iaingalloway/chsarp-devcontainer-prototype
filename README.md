# .NET 7 Development Container Prototype

This repository contains a prototype for a Visual Studio Code dev container setup for a .NET 7 project. The devcontainer mounts the host's docker port, and provides the kind binary to support development with a local Kubernetes cluster.

## Prerequisites

- Docker
- Visual Studio Code with Dev Containers extension

## Usage

1. Clone this repository
2. Open the repository in Visual Studio Code
3. When prompted, open the repository in a development container

This setup allows development and testing C# (.NET 7) applications in a containerised environment, while also providing the ability to interact with Docker and Kubernetes on the host machine for convenience.

## Useful snippets

To get a terminal inside the container:

```bash
docker exec -it --user vscode dotnet-devcontainer-prototype bash
```
