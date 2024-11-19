#### What is containerization?

Containerization is a lightweight form of virtualization that encapsulates applications and their dependencies into isolated units called containers (W). This method allows multiple containers to run on the same operating system kernel while maintaining their own environment, which enhances portability and consistency across different environments (H). By using containerization, developers can avoid conflicts between applications and streamline deployment processes (Y).

#### What problem are we solving with containerization and/or virtualization?

Containerization and virtualization address issues related to resource utilization, environment consistency, and application isolation (W). They solve the problem of running multiple applications on a single physical server without conflicts, allowing for efficient use of resources (H). This leads to reduced overhead, faster deployment times, and improved scalability in software development and operations (Y).

#### How is containerization different from virtualization?

Containerization differs from virtualization in that it shares the host operating system kernel among multiple containers, while virtualization requires each virtual machine to run its own operating system (W). This results in containers being more lightweight and quicker to start compared to virtual machines, which have higher resource overhead due to running separate OS instances (H). Consequently, containerization is better suited for microservices architectures and rapid deployment scenarios (Y).

#### What is Docker?

Docker is an open-source platform that automates the deployment, scaling, and management of applications within containers (W). It simplifies the process of packaging applications with their dependencies into standardized units for software development (H). Docker enables developers to create consistent environments that can be easily shared and deployed across various systems, enhancing collaboration and efficiency (Y).

#### What is Docker Engine?

The **Docker Engine** is the core component of Docker that enables users to build, run, and manage containers (W). It consists of a server-side daemon that manages container operations and a client-side interface for interacting with the daemon (H). Docker Engine provides the necessary tools for developers to create and manipulate containers effectively within their development workflows (Y).

#### What is a Dockerfile?

A **Dockerfile** is a text file that contains a set of instructions for building a Docker image (W). It specifies the base image, environment variables, dependencies, and commands needed to configure the application within the container (H). By using a Dockerfile, developers can automate the image creation process, ensuring consistency and reproducibility across different environments (Y).

#### What is a .dockerignore file?

A **.dockerignore** file specifies files and directories that should be excluded from the context when building a Docker image (W). This helps reduce the size of the build context by omitting unnecessary files such as logs or local configurations (H). By using a .dockerignore file, developers can improve build performance and prevent sensitive information from being included in images (Y).

#### What is an image?

An **image** in Docker is a lightweight, standalone package that includes everything needed to run an application---code, runtime, libraries, environment variables, and configuration files (W). Images are immutable snapshots used to create containers at runtime (H). They enable consistent deployment of applications across different environments by ensuring that every instance runs with the same configuration (Y).

#### What is a container?

A **container** is a runnable instance of a Docker image that provides an isolated environment for executing applications (W). Containers share the host operating system kernel but maintain their own filesystem, processes, and network stack (H). This isolation allows multiple containers to run concurrently on the same host without interfering with each other or affecting system stability (Y).

#### What is a tag?

A **tag** in Docker refers to a label attached to an image version that helps identify it uniquely within an image repository (W). Tags typically follow a naming convention such as `repository:tag`, allowing users to specify which version of an image they want to pull or run (H). Using tags facilitates better version control and management of images in development workflows (Y).

#### What is an image registry?

An **image registry** is a storage system where Docker images are stored and managed (W). It allows users to upload, download, and share images with others or across different environments (H). Popular registries like Docker Hub provide public repositories for sharing images while also allowing private registries for secure internal use within organizations (Y).

#### What is a base image?

A **base image** is an initial layer upon which other layers are built when creating a Docker image (W). It can be a minimal operating system or an existing application framework that serves as the foundation for further customization through additional layers defined in the Dockerfile (H). Using base images simplifies the process of building new images by providing pre-configured environments tailored for specific applications or services (Y).

### Docker Commands

#### What command do you use to build an image?

To build an image in Docker, you use the command:

```bash

docker build -t <image-name>:<tag> .

```

This command specifies the context directory (`.`) where the Dockerfile resides along with optional tags for versioning.

#### How do you run an image in a container?

To run an image in a container, you use the command:

```bash

docker run <image-name>:<tag>

```

This command creates and starts a new container instance from the specified image.

#### In Dockerfile...

- **What does FROM do?**

The `FROM` instruction specifies the base image from which you are building your new image. It sets up the initial environment for your application.

- **What does WORKDIR do?**

The `WORKDIR` instruction sets the working directory inside the container where subsequent commands will be executed. If it doesn't exist, it will be created.

- **What does RUN do?**

The `RUN` instruction executes commands in a new layer on top of the current image. It's commonly used to install packages or configure software during the build process.

- **What does CMD do?**

The `CMD` instruction provides default arguments for executing your container. It specifies what command should be run when starting a container but can be overridden by user input.

- **What does ENTRYPOINT do?**

The `ENTRYPOINT` instruction defines what executable should run when starting a container. Unlike CMD, it cannot be overridden by command line arguments when running the container.

#### How do you push/pull images from an image registry?

To push an image to an image registry, you use:

```bash

docker push <image-name>:<tag>

```

To pull an image from an image registry, you use:

```bash

docker pull <image-name>:<tag>

```

These commands facilitate sharing images between local environments and remote registries.

