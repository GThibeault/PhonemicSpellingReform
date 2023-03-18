# Phonemic Spelling Reform

## Introduction

The purpose of this project is to provide users with an easy way to create, update, and test phonemic spelling reforms.

Originally intended specifically for English (thus the name of the projects and solution), it now supports a wealth of languages thanks to the flexibility provided by the phonemizer package and the espeak backend.

### What is a phonemic spelling reform?

A spelling reform for a language is phonemic when it results in a [phonemic ortography](https://en.wikipedia.org/wiki/Phonemic_orthography), that is to say when different written characters or sets of characters consistently correspond to units of sound.

### How it's done

Source text in some language is converted to a string of phonemes, which is then transformed to a reformed spelling according to the phoneme-to-character mapping set by the user.

## Installation

The C# project should only require the .NET 6 runtime.

The Python project requires a bit more involved of an installation due to the dependency on the espeak-ng backend.

Refer to the installation instructions and issues detailed on the [phonemizer package](https://github.com/bootphon/phonemizer) and [espeak-ng backend](https://github.com/espeak-ng/espeak-ng)'s github pages.

Alternatively, check out the [containerize](https://github.com/GThibeault/PhonemicSpellingReform/tree/containerize) branch, which runs a working version of the phonemizer in Docker with no further installation required.

## Usage

### Source Text

Enter the desired source text in the text box to the left.

Phonemization of the source text can be performed automatically by pressing the "Phonemize" button.

The language may be adjusted to any supported by the espeak-ng backend through the dropdown to the right.

The resulting phoneme text can be modified (or input manually, if desired) freely through the text box.

Once the desired source text is phonemized as desired, proceed to the Phoneme Mapping page.

### Phoneme Mapping

In this page where spelling reforms can be created or edited.

Define whichever mapping between phonemes (or clusters of phonemes) and resulting characters in the reformed spelling.

You may load any of the available presets as examples or starting points.

The current phoneme mapping can be exported (in JSON format) to the clipboard.
If a phoneme mapping in JSON format is currently on the clipboard, it may be imported as well.

### Reformed Spelling

Here the source text is transformed according to the defined mapping and presented in the desired reformed spelling.

Press the "Toggle Side by Side" button to see the source text next to its reformed spelling.

### The algorithm

If only single phonemes are mapped, the result should be fairly evident.
Slightly more complexity is involved when dealing with clusters of phonemes.

The algorithm employed is rather simple, but surprisingly versatile (see the stressed variant presets, for example).
To wit:

1. Sweep the source text S from left to right.
2. Let i be the index being currently examined.
3. Consider the strings composed of the following characters:
   * the character at index i (i.e. S[i])
   * the characters at index i, and i + 1 (i.e. S[i..i+1])
   * the characters at index i, i + 1, and i + 2 (i.e. S[i..i+2])
   * and so on\*
4. Check if a mapping has been set for any of these strings.
5. If one or more of these strings match:
    1. Select the longest one.
    2. Append the characters mapped for this string to the result.
    3. Advance i by the length of this string.
6. If no matches are found:
    1. Append the source character to the result.
    2. Advance i by 1.
7. Display the result once the entirety of the source text has been swept.

\*: For performance reasons, strings of lengths beyond the largest mapped phoneme cluster are not considered.
