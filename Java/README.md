# ShiMart

This is the ShiMart kata in Java. If you have an IDE you're comfortable with, you can run all othese operations from within the IDE. If you prefer command line, guidance is provided below.

## Getting started

### Prerequisites

- Java LTS versions: 8, 11, 17, or 21
- Your preferred IDE (IntelliJ IDEA, Eclipse, VS Code, etc.)

### Running with an IDE (Recommended)

Using your preferred IDE is ideal for development. Most modern IDEs will automatically detect the Gradle or Maven configuration and handle dependencies, running, and testing for you.

### Command Line Tools

If you prefer using the command line, this project includes wrapper scripts for both Gradle and Maven so you don't need to install them separately. 

#### Platform-specific setup

**Linux/Mac:**
- Gradle wrapper: `./gradlew`
- Maven wrapper: `./mvnw`
- You may need to make the scripts executable first:
  ```sh
  chmod +x gradlew mvnw
  ```

**Windows:**
- Gradle wrapper: `gradlew.bat`
- Maven wrapper: `mvnw.cmd`

Dependencies will be automatically downloaded when you run any build command.

## Build the project (Required before first run)

### Using Gradle

```sh
./gradlew build
```

### Using Maven

```sh
./mvnw compile
```

## Run the application

### Using Gradle

To run the application with the default number of days (31):

```sh
./gradlew run
```

To run with a specific number of days:

```sh
./gradlew run --args="10"
```

### Using Maven

To run the application with the default number of days (31):

```sh
./mvnw exec:java
```

To run with a specific number of days:

```sh
./mvnw exec:java -Dexec.args="10"
```

## Run the unit tests from the Command-Line

### Using Gradle

To run all tests:

```sh
./gradlew test
```

To run tests with more detailed output:

```sh
./gradlew test --info
```

To continuously run tests when files change:

```sh
./gradlew test --continuous
```

### Using Maven

To run all tests:

```sh
./mvnw test
```

To run tests with more detailed output:

```sh
./mvnw test -X
```

## Create JAR files (Optional)

### Using Gradle

To create a JAR file:

```sh
./gradlew jar
```

The JAR file will be created in `build/libs/`.

### Using Maven

To create a JAR file:

```sh
./mvnw package
```

The JAR file will be created in `target/`.