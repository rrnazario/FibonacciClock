# FibonacciClock
A simple Fibonacci clock written in WebForm C#.

Q.: How look the time in this clock?
A.: Like this:

The clock has 5 "squares". Theirs values are 1 1 2 3 5. The biggest has value 5 and the two smallest have value 1.

When a square is counting hours, its color will be red. When counting minutes, it will be green color. If it is marking both, it color will be blue. If it is not marking anything, its color will be white.

To see hours:
  - Just sum red and blue square values.
  
To see minutes:
  - Sum green and blue square values and multiply by 5.

Example:

  - Square value 1: green
  - Square value 1: green
  - Square value 2: white
  - Square value 3: red
  - Square value 5: blue
  
  - Hours (sum red and blue): 5 + 3 = 8
  - Minutes (sum green and blue and multiply by 5): 1 + 1 + 5 = 7 * 5 = 35
  
  Then, we have 8:35.
  
  
Enjoy :)

  
