# PPND16
VB.NET Inverse Normal Cumulative Distribution Formula (a.k.a. NORMSINV)

I had been looking for a way to implement the NORMSINV function into a .NET application.

Research took me to the Peter J. Acklam algorithm for which I adapted some C++ code I found into my .NET application. Later I found that others had done adaptations for various languages including C#.

Sadly, though Acklam's algorithm worked well, I could not get the function to match precision closely enough to my customer's legacy program that I was replacing.

Peter Aklam never published his algorithm in any peer-reviewed journals so, other than some historical web pages, it was not possible to follow up to see if any changes or progress took place. However, those historical pages pointed me to the previous work of others.

Conducting that literature research, I found the seminal paper "Algorithm AS 241: The Percentage Points of the Normal Distribution" by Michael J. Wichura (1988), Applied Statistics, vol. 37, pp. 477-484. This paper included an implementation of a function "to compute the percentage point zp of the standard normal distribution corresponding to a prescribed value p for the lower tail area" in FORTRAN. Wichura's algorithm itself extends previous work by Beasley, J. D. and Springer, S. G. (1977), "The percentage points of the normal distribution", Applied Statistics, vol. 26, pp. 118-121, which introduced the function PPND (Percentage Points of the Normal Distribution) as part of algorithm AS 111, also published in FORTRAN.

I still do not understand why Peter Aklam thought it necessary to develop his own algorithm rather than simply adapting Wichura's, though one of Aklam's old pages mentions something about his own approximation function. So perhaps he needed to develop it in order to prove or support other work. I am not really a mathematician, so I did not dig any deeper.

After a quick crash-course in FORTRAN syntax, I was able to easily (but teadiously) translate Wichura's algorithm to Visual Basic .NET.

Since Wichura's code is published work and all I did was translate it, I am not making any claims to this code other than as a humble contributor. I hope you find it beneficial.
