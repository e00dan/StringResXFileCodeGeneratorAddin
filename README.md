StringResXFileCodeGeneratorAddin
================================

Addin for MonoDevelop 5.2 which generates Designer.cs files for .resx resource files. Based on [kenkendk/mdresxfilecodegenerator](https://github.com/kenkendk/mdresxfilecodegenerator).

Why this
======
MonoDevelop has built in ResXFileCodeGenerator and PublicResXCodeGenerator but... this returns string instead of objects(DomXNodes). How is it better from original repo? It supports multiple cultures eg. Resources.pl.resx. It produces correct class name - instead of `Resources.pl`(bad syntax, errors) there is `Resources_pl` which is correct class name.

Install
=======
Open MonoDevelop addin manager and click install from file. Select .mpack file you have downloaded from [Releases](https://github.com/Kuzirashi/StringResXFileCodeGeneratorAddin/releases).

Usage
=====
Open .resx file properties and in `CustomTool` field type exactly: `StringResXFileCodeGenerator`. After you edit .resx file or delete Designer.cs file and edit .resx your designer.cs file will be generated.
