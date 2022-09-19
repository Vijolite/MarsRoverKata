# Mars Rover Kata - C# OOP 

Setting the Scene
Program illustrates movig of rovers around the surface of Mars!
The surface of Mars is represented by a Plateau (assuming that the Plateau is a square/rectangular grid, the lower-left coordinates is (0, 0)).
Rovers navigate the Plateau.

Representation of a Rover’s Position on the Plateau:
The Plateau is divided into a grid. A Rover’s position is represented by x and y co-ordinates and the letters N, S, W, E to represent
North, South, West, East (the four cardinal compass points) respectively.
Example
0 0 N
This means the Rover is at the bottom-left corner facing in the North direction.

Instructing a Rover to Move Around the Plateau:
To move a Rover around the Plateau, a string of letters is sent to a Rover.
Here are the letters and their resultant action:
L - Spins the Rover 90 degrees Left without moving from the current coordinate point/
R - Spins the Rover 90 degrees Right without moving from the current coordinate point/
M - Moves the Rover forward by one grid point, maintaining thesame heading (i.e. from where the Rover is facing (its orientation)).

User input:
- the size of the Plateau
- the number of rovers
- rover N1 initial position
- rover N1 journey instructions
- rover N2 initial position
- rover N2 journey instructions
- ...

Program Output
- rover N1 final position
- rover N2 final position
- ...

Example:

Lines of Input to the Program:

5 5 // the size of the Platea

2 // the number of rovers

1 2 N //rover N1 initial position

LMLMLMLMM //rover N1 journey instructions

3 3 E //rover N2 initial position

MMRMMRMRRM //rover N2 journey instructions


Expected Output:

1 3 N //rover N1 final position

5 1 E //rover N2 final position


For quick testing:

5 5

2

1 2 N

LMLMLMLMM

3 3 E

MMRMMRMRRM

