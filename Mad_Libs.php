<?php
  /*
  This PHP program is one of the exercises I did in my Codecademy training for PHP. 
  The idea is to create a Mad-Libs style story where you can use functions and 
  variables to plug in the words. 
  */
function generateStory($singular_noun, $verb, $color, $distance_unit)
{
  $story = "\nThe ${singular_noun}s are lovely, ${color}, and deep.\nBut I have promises to keep,\nAnd ${distance_unit}s to go before I ${verb},\nAnd ${distance_unit}s to go before I ${verb}.";
  return $story;
}
  

echo generateStory("cat", "run", "maroon", "mile");
echo generateStory("tarantula", "eat", "green", "meter");
echo generateStory("lizard", "spit", "beige", "yard");