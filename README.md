# Phonemic Spelling Reform

## Introduction

The purpose of this project is to provide users with an easy way to create, update, and test phonemic spelling reforms.

Originally intended specifically for English (thus the name of the projects and solution), it now supports a wealth of languages thanks to the flexibility provided by the phonemizer package and the espeak backend.

### What is a phonemic spelling reform?

A spelling reform for a language is phonemic when it results in a [phonemic ortography](https://en.wikipedia.org/wiki/Phonemic_orthography), that is to say when different written characters or sets of characters consistently correspond to distinct units of sound.

### How it's done

Source text in some language is converted to a string of phonemes, which is then transformed to a reformed spelling according to the phoneme-to-character mapping set by the user.

## Installation

The C# project should only require the .NET 6 runtime.

The Python project requires a bit more involved of an installation due to the dependency on the espeak-ng backend.

Refer to the installation instructions and issues detailed on the [phonemizer package](https://github.com/bootphon/phonemizer) and [espeak-ng backend](https://github.com/espeak-ng/espeak-ng)'s github pages.
