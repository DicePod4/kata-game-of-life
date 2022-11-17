 <h1>Game of life</h1>
 
 <p>This Kata is about calculating the next generation of Conway’s game of
life, given any starting position. See
<a href="http://en.wikipedia.org/wiki/Conway%27s_Game_of_Life">http://en.wikipedia.org/wiki/Conway%27s_Game_of_Life</a> for background.</p>

<h2>Problem Description</h2>
<p>You start with a two dimensional grid of cells, where each cell is
either alive or dead. In this version of the problem, the grid is
finite, and no life can exist off the edges. When calcuating the next
generation of the grid, follow these rules:</p>
<pre><code>   1. Any live cell with fewer than two live neighbours dies, as if caused by underpopulation.
   2. Any live cell with more than three live neighbours dies, as if by overcrowding.
   3. Any live cell with two or three live neighbours lives on to the next generation.
   4. Any dead cell with exactly three live neighbours becomes a live cell.
</code></pre>
<p>You should write a program that can accept an arbitrary grid of cells,
and will output a similar grid showing the next generation.</p>
<h2 id="clues">Clues</h2>
<p>The input starting position could be a text file that looks like this:</p>
<pre><code>Generation 1:
........
....*...
...**...
........
</code></pre>
<p>And the output could look like this:</p>
<pre><code>Generation 2:
........
...**...
...**...
........
</code></pre>
