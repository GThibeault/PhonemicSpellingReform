﻿namespace English.Web.Logic.Phonemes;

public class PythonPhonemizerPhonemeFetcher : IPhonemeFetcher
{
    public Dictionary<String, String> GetPhonemeDict() => new()
    {
        ["p"] = "p",
        ["t"] = "t",
        ["k"] = "k",
        ["f"] = "f",
        ["θ"] = "th",
        ["s"] = "s",
        ["ʃ"] = "sh",
        ["ʧ"] = "ch",
        ["j"] = "y",
        ["ŋ"] = "ng",
        ["b"] = "b",
        ["d"] = "d",
        ["ɡ"] = "ɡ",
        ["v"] = "v",
        ["ð"] = "dh",
        ["z"] = "z",
        ["ʒ"] = "zh",
        ["ʤ"] = "j",
        ["w"] = "w",
        ["h"] = "h",
        ["l"] = "l",
        ["r"] = "r",
        ["m"] = "m",
        ["n"] = "n",
        ["ɪ"] = "i",
        ["i"] = "ii",
        ["ɛ"] = "e",
        ["eɪ"] = "ey",
        ["æ"] = "æ",
        ["aɪ"] = "ay",
        ["ə"] = "ə",
        ["ʌ"] = "a",
        ["ɑ"] = "aa",
        ["oʊ"] = "ow",
        ["ʊ"] = "uu",
        ["u"] = "u",
        ["ɔ"] = "oo",
        ["aʊ"] = "aw",
        ["ɔɪ"] = "oy",
        ["ɑr"] = "ar",
        ["ɔr"] = "or",
        ["ir"] = "ir",
        ["ɜr"] = "er",
        ["ˈ"] = "",
        ["ˌ"] = "",
        ["iː"] = "ii",
        ["ɔː"] = "oo",
        ["uː"] = "uu",
        ["ɑː"] = "aa",
        ["ɑːɹ"] = "ar",
        ["ɹ"] = "r",
        ["ɜːɹ"] = "er",
        ["ɚ"] = "ər",
        ["tʃ"] = "ch",
        ["oːɹ"] = "or",
        ["ʔ"] = "t",
        ["ɜː"] = "er",
        ["dʒ"] = "j",
        ["ɐ"] = "ə",
        ["əl"] = "əl",
    };
}
