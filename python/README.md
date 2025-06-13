# ShiMart

This is the ShiMart kata in Python. If you have an IDE you're comfortable with, you can run all othese operations from within the IDE. If you prefer command line, guidance is provided below.

## Getting started

### Prerequisites

- Python 3.x

## Run the application

To run the application with the default number of days (31):

```sh
python start.py
```

Please note that depending on your environment, you may have to use `python3` or `py` instead of `python`.

To run with a specific number of days:

```sh
python start.py 10
```

## Run the unit tests

To run the tests:

```sh
python -m unittest test_shi_mart
```

Or simply:

```sh
python test_shi_mart.py
```

For more verbose output:

```sh
python -m unittest -v test_shi_mart
```