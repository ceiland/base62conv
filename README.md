# base62conv
DPC #352: Converting a number to its base 62 representation

# Overview
Short links have been all the rage for several years now, spurred in part by Twitter's character limits. Imgur - Reddit's go-to image hosting site - uses a similar style for their links. Monotonically increasing IDs represented in Base62.

# Files
  ### Base62.cs

Contains three different implementations of the base 62 conversion: one iterative, one recursive, and one recursive but in a more condensed form. In practice, the most readable and efficient would probably be the long-form recursive version (for input values that aren't so large that they cause a stack overflow). The conversion is available externally using the public accessor `Convert()`, and the method it uses can be selected on compile.

### Base62Tests.cs

A unit test that confirms the functionality of `Convert()` by feeding it the following input values:
```
15674
7026425611433322325
187621
237860461
2187521
18752
```

The following output should be generated:
```
44O
8n36rbfRcDb
MO9
g62n3
9b4B
4Ss
```
