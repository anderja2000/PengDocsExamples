#### What is DevOps? What problem is it solving?

DevOps is a set of practices that combines software development (Dev) and IT operations (Ops) to shorten the development lifecycle and deliver high-quality software continuously (W). It solves the problem of silos between development and operations teams, fostering collaboration and communication throughout the software delivery process (H). This integration leads to faster releases, improved reliability, and a more responsive approach to user feedback (Y).

#### What is CI (Continuous Integration)?

**Continuous Integration (CI)** is the practice of automatically integrating code changes into a shared repository multiple times a day, followed by automated builds and tests (W). This process helps identify integration issues early, enabling developers to address them quickly rather than at the end of a development cycle (H). CI ensures that the codebase remains healthy and reduces the risk of major defects in production environments (Y).

#### What is Continuous Delivery?

**Continuous Delivery (CD)** is a software development practice where code changes are automatically prepared for release to production after passing through various automated tests (W). It allows teams to deploy updates quickly and reliably while maintaining a high level of quality (H). By ensuring that every code change is in a deployable state, CD minimizes the risks associated with software releases and enhances overall efficiency (Y) [1][2][3].

#### What is Continuous Deployment?

**Continuous Deployment** takes Continuous Delivery a step further by automatically releasing every code change that passes automated testing directly into production without manual intervention (W). This approach allows for rapid delivery of new features and fixes to users, making it easier to incorporate feedback quickly (H). Continuous Deployment emphasizes high levels of automation, which can significantly reduce time-to-market for new updates (Y) [2][4].

#### What are benefits of using CI/CD?

The benefits of using CI/CD include:

- **Faster Releases**: Automated processes reduce the time required for integration and testing, enabling quicker deployment cycles.

- **Higher Quality**: Frequent testing helps catch bugs early, leading to more reliable software.

- **Reduced Risk**: Smaller, incremental changes minimize the impact of potential issues during deployment.

- **Improved Collaboration**: Enhanced communication between development and operations teams fosters a culture of shared responsibility.

- **Greater Efficiency**: Automation reduces manual tasks, allowing teams to focus on higher-value activities [1][2][3].

#### What is a YAML file? How do we use it in CI/CD context?

A **YAML file** (YAML Ain't Markup Language) is a human-readable data serialization format often used for configuration files (W). In the context of CI/CD, YAML files define the pipeline's structure, including stages like build, test, and deploy, along with their respective configurations and parameters (H). This allows teams to version control their pipeline configurations alongside their source code, facilitating easier updates and collaboration (Y).

#### What are some tools available to configure CI/CD pipelines?

Various tools are available for configuring CI/CD pipelines, including:

- **Jenkins**: An open-source automation server that supports building, deploying, and automating projects.

- **GitLab CI/CD**: Integrated into GitLab for seamless version control and deployment processes.

- **CircleCI**: A cloud-based tool that automates the software development process.

- **Travis CI**: A continuous integration service used to build and test projects hosted on GitHub.

- **AWS CodePipeline**: A fully managed continuous delivery service for fast and reliable application updates [2][4].

#### What is static code analysis?

**Static code analysis** is the examination of source code before it is executed to identify potential errors, vulnerabilities, or deviations from coding standards (W). This process involves analyzing code structure without running it, allowing for early detection of issues that could lead to runtime errors or security vulnerabilities (H). By incorporating static analysis into the development workflow, teams can improve code quality and maintainability from the outset (Y).

#### Why do we use static code analysis tools, such as SonarCloud?

Static code analysis tools like SonarCloud are used to automate the detection of bugs, vulnerabilities, and code smells in software projects (W). They provide insights into code quality metrics and help enforce coding standards across teams (H). By identifying issues early in the development process, these tools facilitate cleaner codebases and reduce technical debt over time (Y).

#### What is code coverage, why is it important?

**Code coverage** measures the percentage of source code executed during testing (W). It is important because it provides insights into how thoroughly tests exercise the application; higher coverage often correlates with fewer undetected bugs in production (H). Monitoring code coverage helps ensure that critical paths are tested adequately, ultimately leading to more robust software with improved reliability (Y).

