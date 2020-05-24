# CyrusBeck
[CyrusBeck line clipping](https://en.wikipedia.org/wiki/Cyrus%E2%80%93Beck_algorithm) in c# - converted from C++ code at [https://www.geeksforgeeks.org/line-clipping-set-2-cyrus-beck-algorithm/](https://www.geeksforgeeks.org/line-clipping-set-2-cyrus-beck-algorithm/)

You can simply create a clipping rectangle (polygon) with a set of Vector3 objects and then pass a start and end Vector3 object which defines the line. Two more Vector3 objects are passed as out variables and will contain the trimmed locations. And a CyrusBeck.CyrusBeckResult enum object which lets you know what was the result.

The boolean result is false if the result is DoesNotIntersect otherwise true.

`bool IntersectsWithRectangle = CyrusBeck.LineClipping(clipRectangle, startVector, endVector, out startVectorTrimmed, out endVectorTrimmed, out result);`

Along with a sample application that shows the result of the line clipping

* DoesNotIntersect,
* NotTrimmed,
* StartTrimmed,
* EndTrimmed,
* StartAndEndTrimmed

This code resolves issues with the original c++ code for horizontal lines not returning correct results.

![Example screen shot](/ScreenShot.PNG)
