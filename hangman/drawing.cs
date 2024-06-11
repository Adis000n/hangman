using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hangman
{
    class drawing
    {
        public void draw(int fails)
        {
            var states = new List<string>()
            {
                """
  +---+
  |   |
      |
      |
      |
      |
=========
""", """
  +---+
  |   |
  O   |
      |
      |
      |
=========
""", """
  +---+
  |   |
  O   |
  |   |
      |
      |
=========
""", """
  +---+
  |   |
  O   |
 /|   |
      |
      |
=========
""", """
  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========
""", """
  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========
""", """
  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
=========
"""
            };
            
            Console.WriteLine( states[fails]);

        }
    }
}
