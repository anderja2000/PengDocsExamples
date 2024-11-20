
### Cloud Computing Overview

- **What is Cloud Computing?**

  - On-demand delivery of computing services (servers, storage, databases) over the internet, allowing users to access and manage data remotely, enhancing flexibility and cost efficiency.

- **Benefits of Cloud Computing:**

  - **Cost Optimization**: Reduces capital expenses by eliminating the need for physical data centers.

  - **Speed**: Rapidly deploy resources to meet business needs.

  - **Global Scale**: Easily scale resources up or down based on demand.

  - **Performance**: Improved efficiency through optimized resource allocation.

  - **Security**: Enhanced security measures to protect data.

  - **Flexibility**: Adapt resources quickly as business requirements change.

### Scaling Types

- **Vertical Scaling (Scaling Up)**: Increases the power (CPU, RAM) of existing machines; limited by maximum capacity and can lead to downtime during upgrades.

- **Horizontal Scaling (Scaling Out)**: Adds more machines or instances to handle increased load; improves fault tolerance and can be more cost-effective over time.

### Cloud Types

- **Public Cloud**: Services offered over the internet to multiple users, sharing resources and benefiting from economies of scale.

- **Private Cloud**: A dedicated cloud environment for a single organization, providing enhanced security and control over data and applications.

### PaaS, IaaS, SaaS

- **PaaS (Platform as a Service)**:

  - A platform that allows developers to build, deploy, and manage applications without managing the underlying infrastructure. Ideal for rapid application development (e.g., Heroku).

- **IaaS (Infrastructure as a Service)**:

  - Provides virtualized computing resources over the internet, enabling users to rent servers and storage on a pay-as-you-go basis. Useful for businesses needing scalable infrastructure (e.g., AWS).

- **SaaS (Software as a Service)**:

  - Software applications delivered online via subscription, accessible through web browsers without installation or maintenance. Ideal for organizations seeking easy-to-deploy solutions (e.g., Google Workspace).

### Service Level Agreement (SLA)

- **What is SLA?**

  - A contract between a service provider and customer outlining expected service levels regarding availability, performance, and responsibilities. Ensures accountability and sets clear expectations.

### Regions in Cloud Computing

- **What is a Region?**

  - A specific geographical area where cloud service providers have data centers. Important for optimizing performance, ensuring compliance with local regulations, and planning disaster recovery strategies.

### Major Cloud Providers (Other than Azure)

- **AWS**: Extensive cloud services including computing power and storage.

- **Google Cloud Platform**: Offers various services for computing, storage, machine learning, etc.

- **IBM Cloud**: Focuses on enterprise solutions with strong AI capabilities.

- **Oracle Cloud**: Specializes in database management systems and enterprise applications.

- **Alibaba Cloud**: Leading provider in Asia offering diverse cloud services.

### DevOps Overview

- **What is DevOps?**

  - A set of practices that integrates software development (Dev) and IT operations (Ops) to enhance collaboration, shorten development cycles, and deliver high-quality software continuously.

### Continuous Integration/Delivery/Deployment

- **CI (Continuous Integration)**:

  - Automatically integrates code changes into a shared repository multiple times daily, followed by automated builds and tests to identify integration issues early.

- **CD (Continuous Delivery)**:

  - Prepares code changes for production after automated testing; ensures that every code change is in a deployable state to minimize release risks.

- **Continuous Deployment**:

  - Automatically releases every code change that passes automated testing directly into production without manual intervention, facilitating rapid feature delivery.

### Benefits of CI/CD

- **Faster Releases**: Automation reduces integration time and accelerates deployment cycles.

- **Higher Quality**: Frequent testing catches bugs early in the development process.

- **Reduced Risk**: Smaller changes minimize potential deployment issues.

- **Improved Collaboration**: Enhances communication between development and operations teams.

- **Greater Efficiency**: Automation allows teams to focus on higher-value tasks rather than manual processes.

### YAML Files in CI/CD

- **What is a YAML File?**

  - A human-readable format for configuration files used to define CI/CD pipeline structures including build, test, and deploy stages along with their configurations.

### CI/CD Tools

- **Jenkins**: Open-source automation server that supports building and deploying projects.

- **GitLab CI/CD**: Integrated tool within GitLab for version control and deployment processes.

- **CircleCI**: Automates software development processes in the cloud.

- **Travis CI**: Continuous integration service for building and testing GitHub projects automatically.

- **AWS CodePipeline**: Fully managed continuous delivery service for reliable application updates.

### Static Code Analysis

- **What is Static Code Analysis?**

  - Examination of source code before execution to identify potential errors or deviations from coding standards. Helps catch issues early in the development process.

### Static Code Analysis Tools

- Tools like SonarCloud automate bug detection and enforce coding standards across teams, improving overall code quality and reducing technical debt.

### Code Coverage

- **What is Code Coverage?**

  - Measures the percentage of source code executed during testing. Higher coverage correlates with fewer undetected bugs in production; ensures critical paths are adequately tested.

### Containerization

- **What is Containerization?**

  - A lightweight form of virtualization that encapsulates applications and their dependencies into isolated units called containers. Enhances portability across different environments.

### Problems Solved by Containerization/Virtualization

- Addresses resource utilization issues, ensures environment consistency, and allows multiple applications to run on a single physical server without conflicts.

### Containerization vs. Virtualization

- Containerization shares the host OS kernel among multiple containers; virtualization requires separate OS instances for each VM. Containers are lighter and faster to start compared to VMs.

### Docker Overview

- **What is Docker?**

  - An open-source platform that automates the deployment, scaling, and management of applications within containers. Simplifies packaging applications with their dependencies.

### Docker Engine

- The core component that enables users to build, run, and manage containers through a server-side daemon managing container operations.

### Dockerfile

- A text file containing instructions for building a Docker image; specifies base images, dependencies, and configuration commands needed for the application.

### .dockerignore File

- Specifies files/directories excluded from context when building a Docker image; helps reduce build context size by omitting unnecessary files like logs or local configurations.

### Docker Image

- A lightweight package containing everything needed to run an application---code, runtime libraries---used to create containers at runtime.

### Docker Container

- A runnable instance of a Docker image providing an isolated environment for executing applications while sharing the host OS kernel but maintaining its own filesystem.

### Docker Tag

- A label attached to an image version helping identify it uniquely within an image repository; follows naming conventions like `repository:tag`.

### Image Registry

- Storage system for managing Docker images; allows users to upload/download/share images across environments (e.g., Docker Hub).

### Base Image

- The initial layer upon which other layers are built when creating a Docker image; can be minimal OS or existing application frameworks providing pre-configured environments.

### Docker Commands

1 **Build an Image**:



`docker build -t <image-name>:<tag> .`



2 **Run an Image**:

  

   
`docker run <image-name>:<tag>`


3 **Push/Pull Images**:



   `docker push <image-name>:<tag>`

   `docker pull <image-name>:<tag>`


