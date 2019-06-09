# F# OpenKattis

This repository is intended to help the competitive programming site OpenKattis, <https://open.kattis.com>, to offer `F#` in their platform.

By providing these examples I could help speed up the process of making `F#` a supported language was the feedback when I contacted them regarding `F#` support.

## Run Examples on Ubuntu

Tested on Ubuntu 18.04

## Install Mono F# Compiler

```bash
sudo apt-get update
sudo apt-get install fsharp
```

<https://fsharp.org/use/linux> for more information

## Usefull Compiler Flags

```bash
-o # Specify output file
-O # Enable optimization

# Compile input file with name program.fs to output file with name output.run and enable optimization:
fsharpc -o output.run -O program.fs
```

## Compile and Execute on Ubuntu

```bash
# Compile
fsharpc program.fs -o program.run

# Make file executable
chmod +x program.run

# Execute
./program.run
```

## Explore Examples

In this repository there is an example for each of the possible judgements by OpenKattis for the problem `Different`. Each example contains its own readme with expected result.
