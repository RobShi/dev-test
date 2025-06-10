# ShiMart

This is the ShiMart kata in Java.

## Getting started

### Prerequisites

- Java 8 or higher
- Your preferred IDE (IntelliJ IDEA, Eclipse, VS Code, etc.)

### Running with an IDE (Recommended)

Using your preferred IDE is ideal for development. Most modern IDEs will automatically detect the Gradle or Maven configuration and handle dependencies, running, and testing for you.

### Command Line Tools

If you prefer using the command line, this project includes wrapper scripts for both Gradle (`gradlew`) and Maven (`mvnw`) so you don't need to install them separately. Dependencies will be automatically downloaded when you run any build command.

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

## Build the project

### Using Gradle

To build the project and create a JAR file:

```sh
./gradlew build
```

The JAR file will be created in `build/libs/`.

### Using Maven

To build the project and create a JAR file:

```sh
./mvnw package
```

The JAR file will be created in `target/`.